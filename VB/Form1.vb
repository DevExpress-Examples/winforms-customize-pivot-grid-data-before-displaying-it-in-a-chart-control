Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace WindowsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private productEncodeTableField As Dictionary(Of String, String)

        Private ReadOnly Property ProductEncodeTable As Dictionary(Of String, String)
            Get
                If productEncodeTableField Is Nothing Then productEncodeTableField = New Dictionary(Of String, String)()
                Return productEncodeTableField
            End Get
        End Property

        Private categoryEncodeTableField As Dictionary(Of String, String)

        Private ReadOnly Property CategoryEncodeTable As Dictionary(Of String, String)
            Get
                If categoryEncodeTableField Is Nothing Then categoryEncodeTableField = New Dictionary(Of String, String)()
                Return categoryEncodeTableField
            End Get
        End Property

        Private Sub CreateEncodeTables()
            Dim productCounter As Integer = 1
            For Each value As Object In fieldProductName.GetUniqueValues()
                ProductEncodeTable.Add(value.ToString(), "P" & Math.Min(Threading.Interlocked.Increment(productCounter), productCounter - 1))
            Next

            Dim categoryCounter As Integer = 1
            For Each value As Object In fieldCategoryName.GetUniqueValues()
                CategoryEncodeTable.Add(value.ToString(), "C" & Math.Min(Threading.Interlocked.Increment(categoryCounter), categoryCounter - 1))
            Next
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' TODO: This line of code loads data into the 'nwindDataSet.ProductReports' table. 
            ' You can move, or remove it, as needed.
            productReportsTableAdapter.Fill(nwindDataSet.ProductReports)
            pivotGridControl1.OptionsChartDataSource.ProvideRowFieldValuesAsType = GetType(String)
            pivotGridControl1.OptionsChartDataSource.ProvideColumnFieldValuesAsType = GetType(String)
            pivotGridControl1.OptionsChartDataSource.ProvideCellValuesAsType = GetType(Integer)
            CreateEncodeTables()
            chartControl1.DataSource = pivotGridControl1
            fieldCategoryName.CollapseAll()
            fieldCategoryName.ExpandValue("Produce")
        End Sub

#Region "#CustomChartDataSourceData"
        Private Sub pivotGridControl1_CustomChartDataSourceData(ByVal sender As Object, ByVal e As PivotCustomChartDataSourceDataEventArgs)
            If e.ItemType = PivotChartItemType.RowItem Then
                If e.FieldValueInfo.Field Is fieldCategoryName Then
                    e.Value = CategoryEncodeTable(e.FieldValueInfo.Value.ToString())
                ElseIf e.FieldValueInfo.Field Is fieldProductName Then
                    Dim product As String = ProductEncodeTable(e.FieldValueInfo.Value.ToString())
                    Dim category As String = CategoryEncodeTable(e.FieldValueInfo.GetHigherLevelFieldValue(fieldCategoryName).ToString())
                    e.Value = product & "["c & category & "]"c
                End If
            End If

            If e.ItemType = PivotChartItemType.ColumnItem Then
                If e.FieldValueInfo.ValueType = PivotGridValueType.GrandTotal Then
                    e.Value = "Total Sales"
                End If
            End If

            If e.ItemType = PivotChartItemType.CellItem Then
                e.Value = Math.Round(Convert.ToDecimal(e.CellInfo.Value), 0)
            End If
        End Sub
#End Region  ' #CustomChartDataSourceData
    End Class
End Namespace
