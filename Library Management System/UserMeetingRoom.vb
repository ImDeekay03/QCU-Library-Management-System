Public Class UserMeetingRoom
    Dim windowSwitcher As New windowTools()
    Private Sub dashbrd_btn_Click(sender As Object, e As EventArgs) Handles dashbrd_btn.Click
        windowSwitcher.windowSwitch(Me, New UserHomePage())
    End Sub
    Private Sub meetingrm_btn_Click(sender As Object, e As EventArgs) Handles meetingrm_btn.Click
        windowSwitcher.windowSwitch(Me, New UserBorrowedbooks())
    End Sub

    Private Sub borrow_books_btn_Click(sender As Object, e As EventArgs) Handles borrow_books_btn.Click
        windowSwitcher.windowSwitch(Me, New UserBorrowBooks())
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        windowSwitcher.windowSwitch(Me, New UserPopUp())
    End Sub

    Private Sub rooms_btn_Click(sender As Object, e As EventArgs) Handles rooms_btn.Click
        windowSwitcher.windowSwitch(Me, New UserMeetingRoom())
    End Sub
End Class