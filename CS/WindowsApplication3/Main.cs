using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
using CustomSerialization;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils.Paint;
using DevExpress.XtraGrid.Views.Grid;
using DXSample.Properties;


namespace DXSample
{
    public partial class Main : XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        string filePath = "Layout.xml";
        private void OnSaveLayoutButtonClick(object sender, EventArgs e)
        {
            layoutControl1.SaveLayoutExToXml(filePath);
        }

        private void OnRestoreLayoutButtonClick(object sender, EventArgs e)
        {
            layoutControl2.RestoreLayoutExFromXml(filePath);
        }
    }
}

   