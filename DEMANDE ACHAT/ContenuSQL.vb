#Region " IMPORTS "
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.Sql
Imports Microsoft.VisualBasic.FileIO.SearchOption
Imports System.IO.Path
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Data.SqlDbType
Imports System.Data.SqlTypes
Imports System.IO
#End Region

Public Class ContenuSQL

#Region "Fichier de configuration"
    'Lecture dans le fichier .ini
    
    Private Sub chargeSource()
        Try
            LirefichierConfig()
            TbServer.Text = Trim(serveurSql)
            TbBase.Text = Trim(baseSql)
            TbLogin.Text = Trim(userSql)
            TbPassword.Text = Trim(pwdSql)
            TbBaseAPPLI.Text = Trim(baseAppli)
            TbCheminCpta.Text = Trim(cheminCpta)
            UserCpta.Text = Trim(utilisateurCpta)
            PwdCpta.Text = Trim(motdepasseCpta)
            TBsoucheDec.Text = Trim(Souche)
            TextBox1.Text = Trim(cheminGescom)
            TextBox2.Text = Trim(utilisateurGescom)
            TextBox3.Text = Trim(motdepasseGescom)
        Catch ex As Exception
            MessageBox.Show("Erreur Chargement des Fichiers Sources, CAISSE WAZA: " & ex.Message, "CAISSE WAZA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Form"
    Private Sub BtEnreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtEnreg.Click
        Dim Bool As Boolean
        Dim dossierAppli As String = My.Application.Info.DirectoryPath
        If Trim(TbServer.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "SERVEUR SQL", Trim(TbServer.Text), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "SERVEUR SQL", "", fichierini)
        End If
        If Trim(TbBase.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "BASE SQL", Trim(TbBase.Text), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "BASE SQL", "", fichierini)
        End If
        If Trim(TbBaseAPPLI.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "BASE Application", Trim(TbBaseAPPLI.Text), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "BASE Application", "", fichierini)
        End If
        If Trim(TbLogin.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "USER SQL", Trim(TbLogin.Text), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "USER SQL", "", fichierini)
        End If
        If Trim(TbPassword.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "PWD SQL", Trim(Base64Encode(Trim(TbPassword.Text))), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "PWD SQL", "", fichierini)
        End If
        If Trim(TbCheminCpta.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "CHEMIN BASE COMPTA", Trim(TbCheminCpta.Text), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "CHEMIN BASE COMPTA", "", fichierini)
        End If
        If Trim(UserCpta.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "USER COMPTA", Trim(UserCpta.Text), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "USER COMPTA", "", fichierini)
        End If
        If Trim(PwdCpta.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "PWD COMPTA", Trim(Base64Encode(Trim(PwdCpta.Text))), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "PWD COMPTA", "", fichierini)
        End If

        If Trim(TextBox1.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "CHEMIN BASE GESCOM", Trim(TextBox1.Text), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "CHEMIN BASE GESCOM", "", fichierini)
        End If
        If Trim(TextBox2.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "USER GESCOM", Trim(TextBox2.Text), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "USER GESCOM", "", fichierini)
        End If
        If Trim(TextBox3.Text) <> "" Then
            Bool = WritePrivateProfileString("CONNEXION", "PWD GESCOM", Trim(Base64Encode(Trim(TextBox3.Text))), fichierini)
        Else
            Bool = WritePrivateProfileString("CONNEXION", "PWD GESCOM", "", fichierini)
        End If

        If Trim(TBsoucheDec.Text) <> "" Then
            If IsNumeric(Strings.Right(Trim(TBsoucheDec.Text), 6)) = True And IsNumeric(Strings.Left(Trim(TBsoucheDec.Text), 3)) = False Then
                Bool = WritePrivateProfileString("CONNEXION", "SOUCHE", Trim(Trim(TBsoucheDec.Text)), fichierini)
            Else
                MessageBox.Show("La souche doit respectée le format AAA000000", "CAISSE WAZA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else
            MessageBox.Show("La souche doit respectée le format AAA000000", "CAISSE WAZA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        MessageBox.Show("Modification(s) Effectuée(s)", "CAISSE WAZA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        chargeSource()
    End Sub

    Private Sub BtClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtClose.Click
        Me.Close()
    End Sub

    Private Sub TbCheminCpta_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TbCheminCpta.MouseClick
        Try

            FindFile = New OpenFileDialog
            FindFile.Title = "Selection du fichier comptable"
            FindFile.Multiselect = False
            FindFile.Filter = "Fichiers de Base de Données (*.mae)|*.mae"
            If Directory.Exists("C:") Then
                FindFile.InitialDirectory = "C:"
            Else
                FindFile.InitialDirectory = My.Application.Info.DirectoryPath
            End If
            If FindFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                If File.Exists(FindFile.FileName) Then
                    TbCheminCpta.Text = FindFile.FileName
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        Try

            FindFile = New OpenFileDialog
            FindFile.Title = "Selection du fichier comptable"
            FindFile.Multiselect = False
            FindFile.Filter = "Fichiers de Base de Données (*.gcm)|*.gcm"
            If Directory.Exists("C:") Then
                FindFile.InitialDirectory = "C:"
            Else
                FindFile.InitialDirectory = My.Application.Info.DirectoryPath
            End If
            If FindFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                If File.Exists(FindFile.FileName) Then
                    TextBox1.Text = FindFile.FileName
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
 
    Private Sub ContenuSQL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chargeSource()
    End Sub
End Class
