<!-- default file list -->
*Files to look at*:

* **[Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))**
* [Serializer.cs](./CS/WindowsApplication3/Serializer.cs) (VB: [Serializer.vb](./VB/WindowsApplication3/Serializer.vb))
<!-- default file list end -->
# How to save a layout of LayoutControl together with its child controls


<p>By default, if you save a layout of <a href="https://documentation.devexpress.com/#windowsforms/clsDevExpressXtraLayoutLayoutControltopic">LayoutControl</a>, settings of layout items are saved (<a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument2179">Save and Restore Layout</a> ). When you load the saved layout, layout items will be created with saved settings only if <strong>LayoutControl</strong> contains <strong>child controls</strong>, whose <strong>names</strong> exist in the saved layout. Otherwise, layout items will not be created. </p>
<p><br />This example illustrates how to save settings of the child controls, too. For this, we have created two extension methods: <strong>SaveLayoutExToXml</strong> and <strong>RestoreLayoutExFromXml</strong>. These methods allow you to save and load child controls' settings. It makes sense to use these methods if it is necessary to re-create child controls from the saved layout with the saved settings. If a child control with the same name exists in <strong>LayoutControl</strong>, it will be removed and replaced by a new one retrieved from the saved layout. This approach is based on using a custom <strong>XmlXtraSerializer</strong> class. </p>

<br/>


