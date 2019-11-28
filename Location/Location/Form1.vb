Imports System.Data.DataTable
Public Class Form1
    Dim table As New DataTable("Table")
    Dim index As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.Database1DataSet.Table)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        TextBox1.Text = selectedRow.Cells(0).Value.ToString()
        TextBox2.Text = selectedRow.Cells(1).Value.ToString()
        TextBox3.Text = selectedRow.Cells(2).Value.ToString()
        TextBox4.Text = selectedRow.Cells(3).Value.ToString()
        TextBox5.Text = selectedRow.Cells(4).Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim newDataRow As DataGridViewRow
        newDataRow = DataGridView1.Rows(index)
        newDataRow.Cells(0).Value = TextBox1.Text
        newDataRow.Cells(1).Value = TextBox2.Text
        newDataRow.Cells(2).Value = TextBox3.Text
        newDataRow.Cells(3).Value = TextBox4.Text
        newDataRow.Cells(4).Value = TextBox5.Text

    End Sub
End Class
