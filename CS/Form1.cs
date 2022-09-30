using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Dictionary<string, string> productEncodeTable;
        Dictionary<string, string> ProductEncodeTable {
            get {
                if(productEncodeTable == null)
                    productEncodeTable = new Dictionary<string, string>();
                return productEncodeTable;
            }
        }
        Dictionary<string, string> categoryEncodeTable;
        Dictionary<string, string> CategoryEncodeTable {
            get {
                if(categoryEncodeTable == null)
                    categoryEncodeTable = new Dictionary<string, string>();
                return categoryEncodeTable;
            }
        }

        void CreateEncodeTables() {
            int productCounter = 1;
            foreach(object value in fieldProductName.GetUniqueValues()) {
                ProductEncodeTable.Add(value.ToString(), "Products: " + productCounter++);
            }

            int categoryCounter = 1;
            foreach(object value in fieldCategoryName.GetUniqueValues()) {
                CategoryEncodeTable.Add(value.ToString(), "Category: " + categoryCounter++);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.productReportsTableAdapter.Fill(this.nwindDataSet.ProductReports);
            pivotGridControl1.OptionsChartDataSource.ProvideRowFieldValuesAsType = typeof(string);
            pivotGridControl1.OptionsChartDataSource.ProvideColumnFieldValuesAsType = typeof(string);
            pivotGridControl1.OptionsChartDataSource.ProvideCellValuesAsType = typeof(int);
            CreateEncodeTables();
            chartControl1.DataSource = pivotGridControl1;
            fieldCategoryName.CollapseAll();
            fieldCategoryName.ExpandValue("Produce");
        }

        #region #CustomChartDataSourceData
        private void pivotGridControl1_CustomChartDataSourceData(object sender, 
        PivotCustomChartDataSourceDataEventArgs e) {
            if(e.ItemType == PivotChartItemType.RowItem) {
                if(e.FieldValueInfo.Field == fieldCategoryName) {
                    e.Value = CategoryEncodeTable[e.FieldValueInfo.Value.ToString()];
                } else if(e.FieldValueInfo.Field == fieldProductName) {
                    string product =  
                        ProductEncodeTable[e.FieldValueInfo.Value.ToString()];
                    string category = 
                    CategoryEncodeTable[e.FieldValueInfo.GetHigherLevelFieldValue(fieldCategoryName).ToString()];
                    e.Value = product + '[' + category + ']';
                }
            }
            if(e.ItemType == PivotChartItemType.ColumnItem) {
                if(e.FieldValueInfo.ValueType == PivotGridValueType.GrandTotal) {
                    e.Value = "Total Sales";
                }
            }
            if(e.ItemType == PivotChartItemType.CellItem) {
                e.Value = Math.Round(Convert.ToDecimal(e.CellInfo.Value), 0);
            }
        }
        #endregion #CustomChartDataSourceData
    }
}