Imports System.ComponentModel
Public Class FrmAdd
    Private Sub ResetForm()
        mskPostcode.Clear()
        txtLocation.Clear()
        txtState.Clear()
        txtPostOffice.Clear()
        err.Clear()
    End Sub

    Private Sub FrmInsert_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ResetForm()
    End Sub



    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim c As New Location()
        c.Location = txtLocation.Text
        c.Post_Office = txtPostOffice.Text
        c.State = txtState.Text
        c.Postcode = mskPostcode.Text

        Dim db As New LocationDataContext()
        db.Locations.InsertOnSubmit(c)
        db.SubmitChanges()
        MessageBox.Show("Location [" & c.Location & "] added", "Add Location", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ResetForm()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class