Public Class admin_books
    Dim windowSwitcher As New windowTools()

    Private Sub dashbrd_btn_Click(sender As Object, e As EventArgs) Handles dashbrd_btn.Click
        windowSwitcher.windowSwitch(Me, New admin_dashboard())
    End Sub

    Private Sub borrowedreturned_btn_Click(sender As Object, e As EventArgs) Handles borrowedreturned_btn.Click
        windowSwitcher.windowSwitch(Me, New admin_entrylog())
    End Sub

    Private Sub Libbooks_btn_Click(sender As Object, e As EventArgs) Handles Libbooks_btn.Click
        windowSwitcher.windowSwitch(Me, New admin_users())
    End Sub

    Private Sub meetingrm_btn_Click(sender As Object, e As EventArgs) Handles meetingrm_btn.Click
        windowSwitcher.windowSwitch(Me, New admin_books())
    End Sub

    Private Sub rooms_btn_Click(sender As Object, e As EventArgs) Handles rooms_btn.Click
        windowSwitcher.windowSwitch(Me, New admin_rooms())
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        windowSwitcher.windowSwitch(Me, New admin_login())
    End Sub
End Class