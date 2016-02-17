
Partial Class _Default
    Inherits System.Web.UI.Page

    'On "Page Load" code:
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Page H1 Title:
        Session("Header") = "Please Login here"
    End Sub

    'Click the "OK" button to do this:
    Protected Sub butOK_Click(sender As Object, e As EventArgs) Handles butOK.Click
        'If name/password match, hide login panel and show message.
        If txtUsername.Text = "groblera" And txtPassword.Text = "password" Then
            pnlLogon.Visible = False
            Response.Redirect("Default2.aspx")
        End If

        If txtUsername.Text = "thomasc" And txtPassword.Text = "password" Then
            pnlLogon.Visible = False
            Response.Redirect("Default2.aspx")
        End If

        If txtUsername.Text = "lawrencem" And txtPassword.Text = "password" Then
            pnlLogon.Visible = False
            Response.Redirect("Default2.aspx")
            'End If

        Else
            txtPassword.Text = ""
            'vldPassword.Validate()
        End If
    End Sub

    Protected Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class
