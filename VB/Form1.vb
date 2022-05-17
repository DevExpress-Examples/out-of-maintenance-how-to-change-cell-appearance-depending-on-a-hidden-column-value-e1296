Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace HowToChangeCellColor

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Dim table As DataTable = New DataTable()
            table.Columns.Add("column", GetType(String))
            table.Columns.Add("data", GetType(Integer))
            table.Columns.Add("hidden", GetType(Integer))
            table.Rows.Add("col1", 1, 2)
            table.Rows.Add("col2", 1, -2)
            pivotGridControl1.DataSource = table
        End Sub

        Private Sub pivotGridControl1_CustomDrawCell(ByVal sender As Object, ByVal e As PivotCustomDrawCellEventArgs)
            If e.DataField Is fieldData Then
                Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
                Dim hiddenValue As Integer = CInt(ds.GetValue(0, "hidden"))
                If hiddenValue > 0 Then e.Appearance.BackColor = Color.Green
                If hiddenValue < 0 Then e.Appearance.BackColor = Color.Red
            End If
        End Sub
    End Class
End Namespace
