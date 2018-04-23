namespace WindowsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.productReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new WindowsApplication1.nwindDataSet();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductSales = new DevExpress.XtraPivotGrid.PivotGridField();
            this.productReportsTableAdapter = new WindowsApplication1.nwindDataSetTableAdapters.ProductReportsTableAdapter();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productReportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataSource = this.productReportsBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName,
            this.fieldProductName,
            this.fieldProductSales,
            this.fieldYear});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsChartDataSource.SelectionOnly = false;
            this.pivotGridControl1.OptionsChartDataSource.ShowRowCustomTotals = false;
            this.pivotGridControl1.OptionsChartDataSource.ShowRowGrandTotals = false;
            this.pivotGridControl1.OptionsChartDataSource.ShowRowTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(734, 419);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CustomChartDataSourceData += new DevExpress.XtraPivotGrid.PivotCustomChartDataSourceDataEventHandler(this.pivotGridControl1_CustomChartDataSourceData);
            // 
            // productReportsBindingSource
            // 
            this.productReportsBindingSource.DataMember = "ProductReports";
            this.productReportsBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            this.fieldCategoryName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldProductSales
            // 
            this.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductSales.AreaIndex = 0;
            this.fieldProductSales.Caption = "Sales";
            this.fieldProductSales.FieldName = "ProductSales";
            this.fieldProductSales.Name = "fieldProductSales";
            this.fieldProductSales.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            // 
            // productReportsTableAdapter
            // 
            this.productReportsTableAdapter.ClearBeforeFill = true;
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 419);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            sideBySideBarSeriesLabel1.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl1.Size = new System.Drawing.Size(734, 150);
            this.chartControl1.TabIndex = 1;
            // 
            // fieldYear
            // 
            this.fieldYear.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            this.fieldYear.FieldName = "ShippedDate";
            this.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.Name = "fieldYear";
            this.fieldYear.UnboundFieldName = "pivotGridField5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 569);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productReportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource productReportsBindingSource;
        private WindowsApplication1.nwindDataSetTableAdapters.ProductReportsTableAdapter productReportsTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductSales;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYear;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}

