Imports System.Data.Entity
Imports System.Web.Security
Imports System.Data.Linq

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None
        If (IsPostBack) Then

        Else
            errorLoginLabel.Text = ""
        End If
    End Sub

    Protected Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        If ValidateUser() Then
            If (remeberMeCheckBox.Checked) Then
                Session.Add("UserName", userNameTextBox.Text)
                Session.Timeout = 300 '6 hours for
            Else
                Session.Add("UserName", userNameTextBox.Text)
                Session.Timeout = 1
            End If
            Response.Redirect("~/Protected/RewardsMember.aspx", True)
        End If
    End Sub

    Private Function ValidateUser() As Boolean
        Try
            Dim dbContext As New MegaResortsWeb.RewardsMembersEntities()
            Dim query = (From aUser In dbContext.Users
                         Where aUser.userName = userNameTextBox.Text
                         Select aUser).ToList()
            dbContext.Dispose()
            Dim PasswdStr As String = query.First.password
            If (query.Count > 0) AndAlso (passwordTextBox.Text = PasswdStr) Then
                Return True
            Else
                errorLoginLabel.Text = "Invalid user name or password"
                Return False
            End If
        Catch ex As Exception
            errorLoginLabel.Text = ex.Message
            Return False
        End Try
    End Function
End Class