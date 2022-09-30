Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

'INSTANT VB NOTE: The field productEncodeTable was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private productEncodeTable_Renamed As Dictionary(Of String, String)
		Private ReadOnly Property ProductEncodeTable() As Dictionary(Of String, String)
			Get
				If productEncodeTable_Renamed Is Nothing Then
					productEncodeTable_Renamed = New Dictionary(Of String, String)()
				End If
				Return productEncodeTable_Renamed
			End Get
		End Property
'INSTANT VB NOTE: The field categoryEncodeTable was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private categoryEncodeTable_Renamed As Dictionary(Of String, String)
		Private ReadOnly Property CategoryEncodeTable() As Dictionary(Of String, String)
			Get
				If categoryEncodeTable_Renamed Is Nothing Then
					categoryEncodeTable_Renamed = New Dictionary(Of String, String)()
				End If
				Return categoryEncodeTable_Renamed
			End Get
		End Property

		Private Sub CreateEncodeTables()
			Dim productCounter As Integer = 1
			For Each value As Object In fieldProductName.GetUniqueValues()
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: ProductEncodeTable.Add(value.ToString(), "Products: " + productCounter++);
				ProductEncodeTable.Add(value.ToString(), "Products: " & productCounter)
				productCounter += 1
			Next value

			Dim categoryCounter As Integer = 1
			For Each value As Object In fieldCategoryName.GetUniqueValues()
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: CategoryEncodeTable.Add(value.ToString(), "Category: " + categoryCounter++);
				CategoryEncodeTable.Add(value.ToString(), "Category: " & categoryCounter)
				categoryCounter += 1
			Next value
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Me.productReportsTableAdapter.Fill(Me.nwindDataSet.ProductReports)
			pivotGridControl1.OptionsChartDataSource.ProvideRowFieldValuesAsType = GetType(String)
			pivotGridControl1.OptionsChartDataSource.ProvideColumnFieldValuesAsType = GetType(String)
			pivotGridControl1.OptionsChartDataSource.ProvideCellValuesAsType = GetType(Integer)
			CreateEncodeTables()
			chartControl1.DataSource = pivotGridControl1
			fieldCategoryName.CollapseAll()
			fieldCategoryName.ExpandValue("Produce")
		End Sub

		#Region "#CustomChartDataSourceData"
		Private Sub pivotGridControl1_CustomChartDataSourceData(ByVal sender As Object, ByVal e As PivotCustomChartDataSourceDataEventArgs) Handles pivotGridControl1.CustomChartDataSourceData
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
		#End Region ' #CustomChartDataSourceData
	End Class
End Namespace