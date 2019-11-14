Imports System.Data.OleDb
Public Class Form1

    Dim con As New OleDbConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source =C:\Users\User\Desktop\Search Engine\Database.mdb"

        'TODO: This line of code loads data into the 'DatabaseDataSet.Location' table. You can move, or remove it, as needed.
        Me.LocationTableAdapter.Fill(Me.DatabaseDataSet.Location)

        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("Select * from location where ID like '%" & TextBox1.Text & "%'" &
                "OR (Building LIKE '" & TextBox1.Text & "') OR (Place LIKE '" & TextBox1.Text & "')" &
                "OR (Street LIKE '" & TextBox1.Text & "') OR (Suburb LIKE '" & TextBox1.Text & "')" &
                "OR (City LIKE '" & TextBox1.Text & "') OR (Country LIKE '" & TextBox1.Text & "')", con)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView

        con.Close()


    End Sub
End Class
