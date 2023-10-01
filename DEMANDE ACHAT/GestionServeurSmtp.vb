Imports System.Data.OleDb
Imports System.Collections
Imports System.Windows.Forms
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Public Class GestionServeurSmtp
    Private Const SC_CLOSE = &HF060&
    Private Const MF_BYCOMMAND = &H0&

    Private Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Long, ByVal bRevert As Long) As Long
    Private Declare Function RemoveMenu Lib "user32" (ByVal hMenu As Long, ByVal nPosition As Long, _
        ByVal wFlags As Long) As Long
    Private Sub GestionServeurSmtp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chargeSource()
    End Sub

    Private Sub BtAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAnnuler.Click
        Me.Close()
    End Sub

    Private Sub BtValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtValider.Click
        Dim Bool As Boolean
        If Trim(TxtServeur.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "SERVEURSMTP", Trim(TxtServeur.Text), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "SERVEURSMTP", "", fichierini)
        End If
        If Trim(txtport.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "PORTSMTP", Trim(txtport.Text), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "PORTSMTP", "", fichierini)
        End If
        If Trim(TxtUserMail.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "USERSMTP", Trim(TxtUserMail.Text), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "USERSMTP", "", fichierini)
        End If
        If Trim(TxtPwdMail.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "PWDSMTP", Trim(Base64Encode(Trim(TxtPwdMail.Text))), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "PWDSMTP", "", fichierini)
        End If
        Bool = WritePrivateProfileString("CONNEXION", "SSL", Trim(ckSsl.Checked.ToString), fichierini)
        MessageBox.Show("Informations enregistrées", "Serveur Smtp", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub chargeSource()
        LirefichierConfig()
        TxtServeur.Text = ServeurSmtp
        txtport.Text = PortSmtp
        TxtUserMail.Text = UserSmtp
        TxtPwdMail.Text = PwdSmtp
        If Trim(Ssl) = "" Then
            ckSsl.Checked = False
        Else
            ckSsl.Checked = Trim(Ssl)
        End If
    End Sub
    Function TestMail() As Boolean
        Try
            Dim Smtp As New SmtpClient(Trim(TxtServeur.Text), CInt(Trim(txtport.Text)))
            Dim EmailMessage As New MailMessage
            Try
                With EmailMessage
                    .From = New MailAddress(Trim(TxtUserMail.Text))
                    .To.Add(Trim(TxtUserMail.Text))
                    .Subject = "Test Caisse WAZA SOLUTIONS"
                    .Body = "Ce mail permet de verifier l'intégrider des informations saisies dans l'application CAISSE pour l'envoie des mails"
                End With
            Catch ex As Exception
                Return False
            End Try
            Try
                With Smtp
                    .DeliveryMethod = SmtpDeliveryMethod.Network
                    .Timeout = 360000
                    If ckSsl.Checked = False Then
                        .EnableSsl = False
                    Else
                        .EnableSsl = True
                    End If
                    .Credentials = New Net.NetworkCredential(Trim(TxtUserMail.Text), Trim(TxtPwdMail.Text))
                    .Send(EmailMessage)
                    MsgBox("Message Test envoyé avec succès", MsgBoxStyle.Information)
                End With
                EmailMessage.Dispose()
                Smtp = Nothing
                Return True
            Catch ex As Exception
                MsgBox("Aucun Message Envoyé", MsgBoxStyle.Information)
                Return False
            End Try
        Catch ex As Exception
            MsgBox("Aucun Message Envoyé", MsgBoxStyle.Information)
            Return False
        End Try
    End Function
    Private Sub BtTester_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtTester.Click
        TestMail()
    End Sub
End Class
