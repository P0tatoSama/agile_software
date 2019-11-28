Imports System.ComponentModel

Public Class FrmUpdate
    Public SelectedId As String
    Private Sub ResetForm()

        txtLocation.Clear()
        mskPostcode.Clear()
        txtState.Clear()
        txtPostOffice.Clear()

        Err.Clear()
    End Sub

    Private Sub FrmUpdate_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ResetForm()

        Dim db As New LocationDataContext()
        Dim c As Location = db.Locations.FirstOrDefault(Function(o) o.Location = SelectedId)

        If c Is Nothing Then
            MessageBox.Show("Location not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        txtLocation.Text = c.Location
        txtState.Text = c.State
        txtPostOffice.Text = c.Post_Office
        'mskPostcode = c.Postcode


    End Sub

    Private Sub txtLocation_Validating(sender As Object, e As CancelEventArgs) Handles txtLocation.Validating
        Dim name As String = If(txtLocation.Text, "")

        If name = "" Then
            err.SetError(txtLocation, "Please enter valid [Location]")
            e.Cancel = True
        Else
            err.SetError(txtLocation, Nothing)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim db As New LocationDataContext()
        Dim c As Location = db.Locations.FirstOrDefault(Function(o) o.Location = SelectedId)

        If c Is Nothing Then
            MessageBox.Show("Location not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        c.Location = txtLocation.Text
        txtState.Text = c.State
        txtPostOffice.Text = c.Post_Office
        'mskPostcode = c.Postcode

        db.SubmitChanges()
        MessageBox.Show("Details Location [" & c.Location & "] updated", "Updated Location", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim db As New LocationDataContext()
        Dim c As Location = db.Locations.FirstOrDefault(Function(o) o.Location = SelectedId)

        If c Is Nothing Then
            MessageBox.Show("Location not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        db.Locations.DeleteOnSubmit(c)
        db.SubmitChanges()
        MessageBox.Show("Location [" & c.Location & "] deleted", " Location Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class