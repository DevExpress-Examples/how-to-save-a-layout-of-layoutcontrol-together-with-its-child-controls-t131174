Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Collections
Imports System.Reflection
Imports DevExpress.Utils.Serializing
Imports System.Linq
Imports System.IO
Imports DevExpress.XtraLayout
Imports System.Xml.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports DevExpress.Utils.Serializing.Helpers
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils


Namespace CustomSerialization

	Public Module Serializer
        Private appName As String = System.Reflection.Assembly.GetExecutingAssembly().FullName
        Private serializer As XmlXtraSerializer = New MyXmlXtraSerializer()

	
        <System.Runtime.CompilerServices.Extension> _
        Public Sub SaveLayoutExToXml(ByVal layoutControl As LayoutControl, ByVal filePath As String)
            Try
                Dim objects As New ObjectInfoCollection()
                For Each ctrl As Control In layoutControl.Controls
                    If layoutControl.GetItemByControl(ctrl) IsNot Nothing Then
                        objects.Collection.Add(New ObjectInfo(ctrl))
                    End If
                Next ctrl
                Dim filePathForControls As String = filePath.Replace(".xml", "Controls.xml")
                layoutControl.SaveLayoutToXml(filePath)
                serializer.SerializeObject(objects, filePathForControls, appName)
            Catch exc As Exception
                XtraMessageBox.Show(exc.Message)
            End Try
        End Sub


        <System.Runtime.CompilerServices.Extension> _
        Public Sub RestoreLayoutExFromXml(ByVal layoutControl As LayoutControl, ByVal filePath As String)
            Try
                Dim objects As New ObjectInfoCollection()
                Dim filePathForControls As String = filePath.Replace(".xml", "Controls.xml")
                serializer.DeserializeObject(objects, filePathForControls, appName)
                For Each info As ObjectInfo In objects.Collection
                    Dim ctrl As Control = TryCast(info.SerializableObject, Control)
                    If ctrl IsNot Nothing Then
                        Dim controls() As Control = layoutControl.Controls.Find(ctrl.Name, False)
                        If controls.Length > 0 Then
                            layoutControl.Controls.Remove(controls(0))
                        End If
                        layoutControl.Controls.Add(ctrl)
                    End If
                Next info
                layoutControl.RestoreLayoutFromXml(filePath)
            Catch exc As Exception
                XtraMessageBox.Show(exc.Message)
            End Try
        End Sub
	End Module

	Public Class MyXmlXtraSerializer
		Inherits XmlXtraSerializer

		Public Sub New()
		End Sub

		Protected Overrides Function CreateSerializeHelper(ByVal rootObj As Object, ByVal useRootObj As Boolean) As SerializeHelper
			Return If(useRootObj, New MySerializeHelper(rootObj), New MySerializeHelper())
		End Function

		Protected Overrides Function CreateDeserializeHelper(ByVal rootObj As Object, ByVal useRootObj As Boolean) As DeserializeHelper
			Return If(useRootObj, New MyDeserializeHelper(rootObj), New MyDeserializeHelper())
		End Function

	End Class

	Public Class ObjectInfoCollection
		Implements IXtraSupportDeserializeCollectionItem

		Public Sub New()
			_Collection = New List(Of ObjectInfo)()
		End Sub

		' Fields...
		Private _Collection As List(Of ObjectInfo)

		<XtraSerializableProperty(XtraSerializationVisibility.Collection, True)> _
		Public Property Collection() As List(Of ObjectInfo)
			Get
				Return _Collection
			End Get
			Set(ByVal value As List(Of ObjectInfo))
				_Collection = value
			End Set
		End Property

        Public Function CreateCollectionItem(ByVal propertyName As String, ByVal e As XtraItemEventArgs) As Object Implements IXtraSupportDeserializeCollectionItem.CreateCollectionItem
            Dim info As New ObjectInfo()
            Collection.Add(info)
            Return info
        End Function

        Public Sub SetIndexCollectionItem(ByVal propertyName As String, ByVal e As XtraSetItemIndexEventArgs) Implements IXtraSupportDeserializeCollectionItem.SetIndexCollectionItem
        End Sub
	End Class

	Public Class ObjectInfo
		Public Sub New(ByVal serializableObject As Object)
			Me.SerializableObject = serializableObject
		End Sub

		Public Sub New()
		End Sub


		' Fields...
		Private _Type As Type
		Private _SerializableObject As Object

		<XtraSerializableProperty> _
		Public Property Type() As Type
			Get
				Return _Type
			End Get
			Set(ByVal value As Type)
				_Type = value
				Try
					If _SerializableObject Is Nothing Then
						_SerializableObject = Activator.CreateInstance(_Type)
					End If
				Catch
				End Try
			End Set
		End Property

		<XtraSerializableProperty(XtraSerializationVisibility.Content)> _
		Public Property SerializableObject() As Object
			Get
				Return _SerializableObject
			End Get
			Set(ByVal value As Object)
				_SerializableObject = value
				_Type = _SerializableObject.GetType()
			End Set
		End Property

		<XtraSerializableProperty(2)> _
		Public Property SerializableObjectName() As String
			Get
				Dim ctrl As Control = TryCast(SerializableObject, Control)
				If ctrl IsNot Nothing Then
					Return ctrl.Name
				End If
				Return String.Empty
			End Get
			Set(ByVal value As String)
				Dim ctrl As Control = TryCast(SerializableObject, Control)
				If ctrl IsNot Nothing Then
					ctrl.Name = value
				End If
			End Set
		End Property
	End Class

	Public Class MySerializeHelper
		Inherits SerializeHelper

		Public Sub New()
		End Sub

		Public Sub New(ByVal rootObject As Object)
			MyBase.New(rootObject)
		End Sub

		Public Sub New(ByVal rootObject As Object, ByVal context As SerializationContext)
			MyBase.New(rootObject, context)
		End Sub

		Protected Overrides Sub SerializeProperty(ByVal store As XtraPropertyInfoCollection, ByVal obj As Object, ByVal pair As SerializablePropertyDescriptorPair, ByVal parentFlags As XtraSerializationFlags, ByVal options As DevExpress.Utils.OptionsLayoutBase)
			Dim prop As PropertyDescriptor = pair.Property
			Dim attr As XtraSerializableProperty = pair.Attribute
			If attr Is Nothing AndAlso prop.IsBrowsable AndAlso prop.ShouldSerializeValue(obj) Then
				If prop.PropertyType IsNot GetType(String) AndAlso prop.PropertyType.IsClass Then
					pair = New SerializablePropertyDescriptorPair(prop, New XtraSerializableProperty(XtraSerializationVisibility.Content))
				Else
					pair = New SerializablePropertyDescriptorPair(prop, New XtraSerializableProperty())
				End If
			End If
			MyBase.SerializeProperty(store, obj, pair, parentFlags, options)
		End Sub
	End Class

	Public Class MyDeserializeHelper
		Inherits DeserializeHelper
		Public Sub New(ByVal rootObject As Object)
			MyBase.New(rootObject)
		End Sub

		Public Sub New(ByVal rootObject As Object, ByVal resetProperties As Boolean)
			MyBase.New(rootObject, resetProperties)
		End Sub

		Public Sub New(ByVal rootObject As Object, ByVal resetProperties As Boolean, ByVal context As SerializationContext)
			MyBase.New(rootObject, resetProperties, context)
		End Sub

		Public Sub New()
		End Sub

		Protected Overrides Function CreateSerializationContext() As SerializationContext
			Return New MySerializationContext()
		End Function
	End Class

	Public Class MySerializationContext
		Inherits SerializationContext

		Public Sub New()
		End Sub

		Protected Overrides Sub CustomGetSerializableProperties(ByVal obj As Object, ByVal pairsList As List(Of SerializablePropertyDescriptorPair), ByVal props As PropertyDescriptorCollection)
			MyBase.CustomGetSerializableProperties(obj, pairsList, props)
			Dim i As Integer = 0
			Do While i < pairsList.Count
				Dim pair As SerializablePropertyDescriptorPair = pairsList(i)
				Dim prop As PropertyDescriptor = pair.Property
				Dim attr As XtraSerializableProperty = pair.Attribute
				If attr Is Nothing AndAlso prop.IsBrowsable Then
					If prop.PropertyType IsNot GetType(String) AndAlso prop.PropertyType.IsClass Then
						pair = New SerializablePropertyDescriptorPair(prop, New XtraSerializableProperty(XtraSerializationVisibility.Content))
					Else
						pair = New SerializablePropertyDescriptorPair(prop, New XtraSerializableProperty())
					End If
					pairsList.RemoveAt(i)
					pairsList.Insert(i, pair)
				End If
				i += 1
			Loop
		End Sub

		Protected Overrides Function GetProperties(ByVal obj As Object, ByVal store As IXtraPropertyCollection) As PropertyDescriptorCollection
			Dim propertyDescriptors As PropertyDescriptorCollection = MyBase.GetProperties(obj, store)
			If store Is Nothing Then
				Return propertyDescriptors
			End If
			Dim newPropertyDescriptors As New PropertyDescriptorCollection(Nothing)
			For Each info As XtraPropertyInfo In store
				Dim pd As PropertyDescriptor = propertyDescriptors(info.Name)
				If pd IsNot Nothing Then
					newPropertyDescriptors.Add(pd)
				End If
			Next info
			Return newPropertyDescriptors
		End Function
	End Class
End Namespace
