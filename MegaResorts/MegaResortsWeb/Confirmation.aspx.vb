Public Class Confirmation
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'RefresH()
    End Sub
    'Private Sub DisplaySignout()
    '    LoginHyperLink.Visible = True
    '    registerHyperLink.Visible = True
    '    LoginLabel.Visible = False
    '    signOutButton.Visible = False
    'End Sub

    'Private Sub DisplaySignIn()
    '    LoginLabel.Visible = True
    '    signOutButton.Visible = True
    '    LoginHyperLink.Visible = False
    '    registerHyperLink.Visible = False
    '    LoginLabel.Text = String.Format("hi, {0}   ", Session("UserName"))
    'End Sub
    'Public Sub RefresH()
    '    If (Session("UserName") = Nothing) Then
    '        DisplaySignout()
    '    Else
    '        DisplaySignIn()
    '    End If
    'End Sub

    'Protected Sub signOutButton_Click(sender As Object, e As EventArgs) Handles signOutButton.Click
    '    Session.Clear()
    '    RefresH()
    'End Sub

End Class