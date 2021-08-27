<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581478/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2214)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# Customize Pivot Grid control's data before displaying it in a Chart Control


<p>The following example demonstrates how to add custom text to data prepared by the <strong>PivotGridControl</strong>, to display it in a <strong>ChartControl</strong>.</p>


<h3>Description</h3>

<p>For this, it is necessary to handle the <strong>PivotGridControl.CustomChartDataSourceData</strong> event. In this event handler you can determine the item type via the e.ItemType property and change the e.Value according to your custom requirements.</p>

<br/>


