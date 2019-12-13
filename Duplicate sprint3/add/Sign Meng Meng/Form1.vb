Imports System.Data.SqlClient

Public Class Form1
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.DataSet.table1)

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Location.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

        disp_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into table1 values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')"
        cmd.ExecuteNonQuery()

        MessageBox.Show("Record Inserted Successfully")
        disp_data()

    End Sub

    Private Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from table1"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "WITH CTE AS
(
SELECT *,ROW_NUMBER() OVER (PARTITION BY Street,Suburb,City ORDER BY Street,Suburb,City) AS RN
FROM table1
)

DELETE FROM CTE WHERE RN<>1"

        '"DELETE FROM table1 WHERE Street  In
        ''(SELECT Street FROM table1
        ''WHERE street = 'East')"







        cmd.ExecuteNonQuery()

        MessageBox.Show("Record Deleted Successfully")
        disp_data()
    End Sub
End Class
