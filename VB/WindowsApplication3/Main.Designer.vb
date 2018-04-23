Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Main))
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.simpleButton4 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.simpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.simpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "1.jpg")
			Me.imageList1.Images.SetKeyName(1, "2.jpg")
			Me.imageList1.Images.SetKeyName(2, "3.jpg")
			Me.imageList1.Images.SetKeyName(3, "4.jpg")
			Me.imageList1.Images.SetKeyName(4, "5.jpg")
			Me.imageList1.Images.SetKeyName(5, "6.jpg")
			Me.imageList1.Images.SetKeyName(6, "7.jpg")
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.buttonEdit1)
			Me.layoutControl1.Controls.Add(Me.memoEdit1)
			Me.layoutControl1.Controls.Add(Me.textEdit2)
			Me.layoutControl1.Controls.Add(Me.simpleButton4)
			Me.layoutControl1.Controls.Add(Me.simpleButton3)
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(502, 377)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' memoEdit1
			' 
			Me.memoEdit1.Location = New System.Drawing.Point(66, 36)
			Me.memoEdit1.Name = "memoEdit1"
			Me.memoEdit1.Size = New System.Drawing.Size(424, 303)
			Me.memoEdit1.StyleController = Me.layoutControl1
			Me.memoEdit1.TabIndex = 11
			Me.memoEdit1.UseOptimizedRendering = True
			' 
			' textEdit2
			' 
			Me.textEdit2.Location = New System.Drawing.Point(307, 12)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(255))))))
			Me.textEdit2.Properties.Appearance.Options.UseBackColor = True
			Me.textEdit2.Properties.NullText = "Last Name"
			Me.textEdit2.Size = New System.Drawing.Size(183, 20)
			Me.textEdit2.StyleController = Me.layoutControl1
			Me.textEdit2.TabIndex = 10
			' 
			' simpleButton4
			' 
			Me.simpleButton4.Location = New System.Drawing.Point(253, 343)
			Me.simpleButton4.Name = "simpleButton4"
			Me.simpleButton4.Size = New System.Drawing.Size(237, 22)
			Me.simpleButton4.StyleController = Me.layoutControl1
			Me.simpleButton4.TabIndex = 9
			Me.simpleButton4.Text = "Cancel"
			' 
			' simpleButton3
			' 
			Me.simpleButton3.Location = New System.Drawing.Point(12, 343)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(237, 22)
			Me.simpleButton3.StyleController = Me.layoutControl1
			Me.simpleButton3.TabIndex = 8
			Me.simpleButton3.Text = "OK"
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.Location = New System.Drawing.Point(66, 12)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(255))))))
			Me.buttonEdit1.Properties.Appearance.Options.UseBackColor = True
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit1.Properties.NullText = "First Name"
			Me.buttonEdit1.Size = New System.Drawing.Size(183, 20)
			Me.buttonEdit1.StyleController = Me.layoutControl1
			Me.buttonEdit1.TabIndex = 5
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem5, Me.layoutControlItem7, Me.layoutControlItem6, Me.layoutControlItem1, Me.layoutControlItem2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(502, 377)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.simpleButton3
			Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 331)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(241, 26)
			Me.layoutControlItem5.Text = "layoutControlItem5"
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextToControlDistance = 0
			Me.layoutControlItem5.TextVisible = False
			' 
			' layoutControlItem7
			' 
			Me.layoutControlItem7.Control = Me.textEdit2
			Me.layoutControlItem7.CustomizationFormText = "Last Name"
			Me.layoutControlItem7.Location = New System.Drawing.Point(241, 0)
			Me.layoutControlItem7.Name = "layoutControlItem7"
			Me.layoutControlItem7.Size = New System.Drawing.Size(241, 24)
			Me.layoutControlItem7.Text = "Last Name"
			Me.layoutControlItem7.TextSize = New System.Drawing.Size(51, 13)
			' 
			' layoutControlItem6
			' 
			Me.layoutControlItem6.Control = Me.simpleButton4
			Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
			Me.layoutControlItem6.Location = New System.Drawing.Point(241, 331)
			Me.layoutControlItem6.Name = "layoutControlItem6"
			Me.layoutControlItem6.Size = New System.Drawing.Size(241, 26)
			Me.layoutControlItem6.Text = "layoutControlItem6"
			Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem6.TextToControlDistance = 0
			Me.layoutControlItem6.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.memoEdit1
			Me.layoutControlItem1.CustomizationFormText = "Details"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(482, 307)
			Me.layoutControlItem1.Text = "Details"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(51, 13)
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(643, 383)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(168, 22)
			Me.simpleButton2.TabIndex = 7
			Me.simpleButton2.Text = "Restore Layout"
'			Me.simpleButton2.Click += New System.EventHandler(Me.OnRestoreLayoutButtonClick);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(154, 383)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(170, 22)
			Me.simpleButton1.TabIndex = 6
			Me.simpleButton1.Text = "Save Layout"
'			Me.simpleButton1.Click += New System.EventHandler(Me.OnSaveLayoutButtonClick);
			' 
			' layoutControl2
			' 
			Me.layoutControl2.Location = New System.Drawing.Point(516, 11)
			Me.layoutControl2.Name = "layoutControl2"
			Me.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(974, 181, 250, 350)
			Me.layoutControl2.Root = Me.layoutControlGroup2
			Me.layoutControl2.Size = New System.Drawing.Size(408, 351)
			Me.layoutControl2.TabIndex = 1
			Me.layoutControl2.Text = "layoutControl3"
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.CustomizationFormText = "Root"
			Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup2.GroupBordersVisible = False
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.simpleLabelItem1})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup2.Name = "Root"
			Me.layoutControlGroup2.Size = New System.Drawing.Size(408, 351)
			Me.layoutControlGroup2.Text = "Root"
			Me.layoutControlGroup2.TextVisible = False
			' 
			' simpleLabelItem1
			' 
			Me.simpleLabelItem1.AllowHotTrack = False
			Me.simpleLabelItem1.CustomizationFormText = "Empty Layout Control"
			Me.simpleLabelItem1.Location = New System.Drawing.Point(0, 0)
			Me.simpleLabelItem1.Name = "simpleLabelItem1"
			Me.simpleLabelItem1.Size = New System.Drawing.Size(388, 331)
			Me.simpleLabelItem1.Text = "Empty Layout Control"
			Me.simpleLabelItem1.TextSize = New System.Drawing.Size(104, 13)
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.buttonEdit1
			Me.layoutControlItem2.CustomizationFormText = "First Name"
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(241, 24)
			Me.layoutControlItem2.Text = "First Name"
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(51, 13)
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(934, 403)
			Me.Controls.Add(Me.layoutControl2)
			Me.Controls.Add(Me.layoutControl1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.simpleButton2)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.MaximumSize = New System.Drawing.Size(942, 431)
			Me.MinimumSize = New System.Drawing.Size(942, 431)
			Me.Name = "Main"
			Me.Text = "Save LayoutControl with controls"
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.simpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageList1 As System.Windows.Forms.ImageList
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
		Private simpleButton4 As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControl2 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private simpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace

