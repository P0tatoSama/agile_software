Public Class FrmList
    Private Sub BindData()
        Dim location As String = txtLocation.Text


        Dim db As New LocationDataContext()
        Dim rs = From c In db.Locations Where c.Location.Contains(txtLocation.Text)

        dgv.DataSource = rs

        lblCount.Text = rs.count().toString("0 record(s)")
    End Sub

    Private Sub txtLocation_TextChanged(sender As Object, e As EventArgs) Handles txtLocation.TextChanged
        BindData()
    End Sub

    Private Sub frmList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmAdd.ShowDialog()
        BindData()
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            FrmUpdate.SelectedId = id
            FrmUpdate.ShowDialog(Me)
            BindData()
        End If
    End Sub

End Class
