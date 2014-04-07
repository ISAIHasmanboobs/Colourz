Public Class frmColourPicker

    Private Sub frmColourPicker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmColourPicker_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Cursor = Cursors.Cross
    End Sub
End Class