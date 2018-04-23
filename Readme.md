# Customize Pivot Grid control's data before displaying it in a Chart Control


<p>The following example demonstrates how to add custom text to data prepared by the <strong>PivotGridControl</strong>, to display it in a <strong>ChartControl</strong>.</p>


<h3>Description</h3>

<p>For this, it is necessary to handle the <strong>PivotGridControl.CustomChartDataSourceData</strong> event. In this event handler you can determine the item type via the e.ItemType property and change the e.Value according to your custom requirements.</p>

<br/>


