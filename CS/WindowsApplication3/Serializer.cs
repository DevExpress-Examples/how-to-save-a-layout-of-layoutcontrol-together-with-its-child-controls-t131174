using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using System.Reflection;
using DevExpress.Utils.Serializing;
using System.Linq;
using System.IO;
using DevExpress.XtraLayout;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using DevExpress.Utils.Serializing.Helpers;
using DevExpress.LookAndFeel;
using DevExpress.Utils;


namespace CustomSerialization
{

    public static class Serializer
    {
        static string appName = Assembly.GetExecutingAssembly().FullName;
        static XmlXtraSerializer serializer = new MyXmlXtraSerializer();


        public static void SaveLayoutExToXml(this LayoutControl layoutControl, string filePath)
        {
            try
            {
                ObjectInfoCollection objects = new ObjectInfoCollection();
                foreach (Control ctrl in layoutControl.Controls)
                    if (layoutControl.GetItemByControl(ctrl) != null)
                        objects.Collection.Add(new ObjectInfo(ctrl));
                string filePathForControls = filePath.Replace(".xml", "Controls.xml");
                layoutControl.SaveLayoutToXml(filePath);
                serializer.SerializeObject(objects, filePathForControls, appName);
            }
            catch (Exception exc)
            {
                XtraMessageBox.Show(exc.Message);
            }
        }


        public static void RestoreLayoutExFromXml(this LayoutControl layoutControl, string filePath)
        {
            try
            {
                ObjectInfoCollection objects = new ObjectInfoCollection();
                string filePathForControls = filePath.Replace(".xml", "Controls.xml");
                serializer.DeserializeObject(objects, filePathForControls, appName);
                foreach (ObjectInfo info in objects.Collection)
                {
                    Control ctrl = info.SerializableObject as Control;
                    if (ctrl != null)
                    {
                        Control[] controls = layoutControl.Controls.Find(ctrl.Name, false);
                        if (controls.Length > 0)
                            layoutControl.Controls.Remove(controls[0]);
                        layoutControl.Controls.Add(ctrl);
                    }
                }
                layoutControl.RestoreLayoutFromXml(filePath);
            }
            catch (Exception exc)
            {
                XtraMessageBox.Show(exc.Message);
            }
        }
    }

    public class MyXmlXtraSerializer : XmlXtraSerializer
    {

        public MyXmlXtraSerializer() { }

        protected override SerializeHelper CreateSerializeHelper(object rootObj, bool useRootObj)
        {
            return useRootObj ? new MySerializeHelper(rootObj) : new MySerializeHelper();
        }

        protected override DeserializeHelper CreateDeserializeHelper(object rootObj, bool useRootObj)
        {
            return useRootObj ? new MyDeserializeHelper(rootObj) : new MyDeserializeHelper();
        }

    }

    public class ObjectInfoCollection : IXtraSupportDeserializeCollectionItem
    {

        public ObjectInfoCollection()
        {
            _Collection = new List<ObjectInfo>();
        }

        // Fields...
        private List<ObjectInfo> _Collection;

        [XtraSerializableProperty(XtraSerializationVisibility.Collection, true)]
        public List<ObjectInfo> Collection
        {
            get { return _Collection; }
            set { _Collection = value; }
        }

        public object CreateCollectionItem(string propertyName, XtraItemEventArgs e)
        {
            ObjectInfo info = new ObjectInfo();
            Collection.Add(info);
            return info;
        }

        public void SetIndexCollectionItem(string propertyName, XtraSetItemIndexEventArgs e) { }
    }

    public class ObjectInfo
    {
        public ObjectInfo(object serializableObject)
        {
            this.SerializableObject = serializableObject;
        }

        public ObjectInfo() { }


        // Fields...
        private string _type;
        private object _SerializableObject;

        [XtraSerializableProperty]
        public string Type1
        {
            get { return _type; }
            set
            {
                _type = value;
                try
                {
                    if (_SerializableObject == null)
                    {
                        int index = _type.LastIndexOf('.');
                        var nameSpace = _type.Substring(0, index);
                        var type = System.Type.GetType(_type + ", " + nameSpace);
                        _SerializableObject = Activator.CreateInstance(type);
                    }
                }
                catch { }
            }
        }

        [XtraSerializableProperty(XtraSerializationVisibility.Content)]
        public object SerializableObject
        {
            get { return _SerializableObject; }
            set
            {
                _SerializableObject = value;
                _type = _SerializableObject.GetType().ToString();
            }
        }

        [XtraSerializableProperty(2)]
        public string SerializableObjectName
        {
            get
            {
                Control ctrl = SerializableObject as Control;
                if (ctrl != null) return ctrl.Name;
                return string.Empty;
            }
            set
            {
                Control ctrl = SerializableObject as Control;
                if (ctrl != null)
                    ctrl.Name = value;
            }
        }
    }

    public class MySerializeHelper : SerializeHelper
    {

        public MySerializeHelper() { }

        public MySerializeHelper(object rootObject)
            : base(rootObject) { }

        public MySerializeHelper(object rootObject, SerializationContext context)
            : base(rootObject, context) { }

        protected override void SerializeProperty(XtraPropertyInfoCollection store, object obj, SerializablePropertyDescriptorPair pair, XtraSerializationFlags parentFlags, DevExpress.Utils.OptionsLayoutBase options)
        {
            PropertyDescriptor prop = pair.Property;
            XtraSerializableProperty attr = pair.Attribute;
            if (attr == null && prop.IsBrowsable && prop.ShouldSerializeValue(obj))
            {
                if (prop.PropertyType != typeof(string) && prop.PropertyType.IsClass)
                    pair = new SerializablePropertyDescriptorPair(prop, new XtraSerializableProperty(XtraSerializationVisibility.Content));
                else
                    pair = new SerializablePropertyDescriptorPair(prop, new XtraSerializableProperty());
            }
            base.SerializeProperty(store, obj, pair, parentFlags, options);
        }
    }

    public class MyDeserializeHelper : DeserializeHelper
    {
        public MyDeserializeHelper(object rootObject)
            : base(rootObject) { }

        public MyDeserializeHelper(object rootObject, bool resetProperties)
            : base(rootObject, resetProperties) { }

        public MyDeserializeHelper(object rootObject, bool resetProperties, SerializationContext context)
            : base(rootObject, resetProperties, context) { }

        public MyDeserializeHelper() { }

        protected override SerializationContext CreateSerializationContext()
        {
            return new MySerializationContext();
        }
    }

    public class MySerializationContext : SerializationContext
    {

        public MySerializationContext() { }

        protected override void CustomGetSerializableProperties(object obj, List<SerializablePropertyDescriptorPair> pairsList, PropertyDescriptorCollection props)
        {
            base.CustomGetSerializableProperties(obj, pairsList, props);
            for (int i = 0; i < pairsList.Count; i++)
            {
                SerializablePropertyDescriptorPair pair = pairsList[i];
                PropertyDescriptor prop = pair.Property;
                XtraSerializableProperty attr = pair.Attribute;
                if (attr == null && prop.IsBrowsable)
                {
                    if (prop.PropertyType != typeof(string) && prop.PropertyType.IsClass)
                        pair = new SerializablePropertyDescriptorPair(prop, new XtraSerializableProperty(XtraSerializationVisibility.Content));
                    else
                        pair = new SerializablePropertyDescriptorPair(prop, new XtraSerializableProperty());
                    pairsList.RemoveAt(i);
                    pairsList.Insert(i, pair);
                }
            }
        }

        protected override PropertyDescriptorCollection GetProperties(object obj, IXtraPropertyCollection store)
        {
            PropertyDescriptorCollection propertyDescriptors = base.GetProperties(obj, store);
            if (store == null) return propertyDescriptors;
            PropertyDescriptorCollection newPropertyDescriptors = new PropertyDescriptorCollection(null);
            foreach (XtraPropertyInfo info in store)
            {
                PropertyDescriptor pd = propertyDescriptors[info.Name];
                if (pd != null)
                    newPropertyDescriptors.Add(pd);
            }
            return newPropertyDescriptors;
        }
    }
}
