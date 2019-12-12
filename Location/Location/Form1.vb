Imports System.Data.DataTable
Public Class Form1
    Dim table As New DataTable("Table")
    Public index As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.Database1DataSet.Table)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        ' Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        'TextBox1.Text = selectedRow.Cells(0).Value.ToString()
        TextBox1.Text = selectedRow.Cells(4).Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim index As Integer
        Dim newDataRow As DataGridViewRow
        newDataRow = DataGridView1.Rows(index)
        'newDataRow.Cells(4).Value = TextBox1.Text
        Dim searchValue As String
        searchValue = TextBox1.Text

        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        If (newDataRow.Cells(4).Value.ToString().Equals(searchValue)) Then

            newDataRow.Selected = True

        End If


        Dim Result As String = TextBox1.Text
        Dim query As String = String.Empty
        query &= "INSERT INTO History (Result) "
        query &= "VALUES (@Result)"

        Using conn As New SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Desktop\Location\Location\Database1.mdf;Integrated Security=True")
            Using comm As New SqlClient.SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Result", Result)
                End With

                conn.Open()
                comm.ExecuteNonQuery()

            End Using
        End Using

        Dim MySource As New AutoCompleteStringCollection()
        With TextBox1
            .AutoCompleteCustomSource = MySource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With
        MySource.Add(TextBox1.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub
End Class
