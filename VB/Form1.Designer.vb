Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.productReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New WindowsApplication1.nwindDataSet()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductSales = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.productReportsTableAdapter = New WindowsApplication1.nwindDataSetTableAdapters.ProductReportsTableAdapter()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataSource = Me.productReportsBindingSource
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName, Me.fieldProductName, Me.fieldProductSales, Me.fieldYear})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsChartDataSource.SelectionOnly = False
			Me.pivotGridControl1.OptionsChartDataSource.ShowRowCustomTotals = False
			Me.pivotGridControl1.OptionsChartDataSource.ShowRowGrandTotals = False
			Me.pivotGridControl1.OptionsChartDataSource.ShowRowTotals = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(734, 419)
			Me.pivotGridControl1.TabIndex = 0
'			Me.pivotGridControl1.CustomChartDataSourceData += New DevExpress.XtraPivotGrid.PivotCustomChartDataSourceDataEventHandler(Me.pivotGridControl1_CustomChartDataSourceData);
			' 
			' productReportsBindingSource
			' 
			Me.productReportsBindingSource.DataMember = "ProductReports"
			Me.productReportsBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 0
			Me.fieldCategoryName.Caption = "Category"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			Me.fieldCategoryName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.Caption = "Product"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			Me.fieldProductName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False
			' 
			' fieldProductSales
			' 
			Me.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldProductSales.AreaIndex = 0
			Me.fieldProductSales.Caption = "Sales"
			Me.fieldProductSales.FieldName = "ProductSales"
			Me.fieldProductSales.Name = "fieldProductSales"
			Me.fieldProductSales.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False
			' 
			' productReportsTableAdapter
			' 
			Me.productReportsTableAdapter.ClearBeforeFill = True
			' 
			' chartControl1
			' 
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Location = New System.Drawing.Point(0, 419)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.SeriesDataMember = "Series"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
			sideBySideBarSeriesLabel1.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
			Me.chartControl1.Size = New System.Drawing.Size(734, 150)
			Me.chartControl1.TabIndex = 1
			' 
			' fieldYear
			' 
			Me.fieldYear.AllowedAreas = (CType((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea Or DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea), DevExpress.XtraPivotGrid.PivotGridAllowedAreas))
			Me.fieldYear.AreaIndex = 0
			Me.fieldYear.Caption = "Year"
			Me.fieldYear.FieldName = "ShippedDate"
			Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldYear.Name = "fieldYear"
			Me.fieldYear.UnboundFieldName = "pivotGridField5"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(734, 569)
			Me.Controls.Add(Me.chartControl1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private nwindDataSet As nwindDataSet
		Private productReportsBindingSource As System.Windows.Forms.BindingSource
		Private productReportsTableAdapter As WindowsApplication1.nwindDataSetTableAdapters.ProductReportsTableAdapter
		Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductSales As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField
		Private chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

