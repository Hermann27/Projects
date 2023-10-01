Imports System
Imports System.Data.OleDb
Imports System.Collections
Imports System.Windows.Forms
Imports System.IO
Imports System.Xml
Imports Microsoft.VisualBasic

Public Class login

    Private Sub valider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valider.Click
        Dim OleAdaptater As OleDbDataAdapter
        Dim OleAfficheDataset As DataSet
        Dim Oledatable As DataTable
        If Trim(CLogin.Text) = "" Then
            MessageBox.Show("Veuillez saisir le champ [Login]!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CLogin.Focus()
        Else
            If Trim(CPwd.Text) = "" Then
                OleAdaptater = New OleDbDataAdapter("select * from Utilisateurs where CodeUtilisateur='" & Trim(CLogin.Text) & "' and (pwd IS NULL OR pwd='')", sqlConAppli)
                OleAfficheDataset = New DataSet
                OleAdaptater.Fill(OleAfficheDataset)
                Oledatable = OleAfficheDataset.Tables(0)
            Else
                OleAdaptater = New OleDbDataAdapter("select * from Utilisateurs where CodeUtilisateur='" & Trim(CLogin.Text) & "' and pwd ='" & Base64Encode(Trim(CPwd.Text)) & "'", sqlConAppli)
                OleAfficheDataset = New DataSet
                OleAdaptater.Fill(OleAfficheDataset)
                Oledatable = OleAfficheDataset.Tables(0)
            End If
            If Oledatable.Rows.Count > 0 Then
                Dim bool As Boolean
                frmIndex.ToolStripStatusLabel.Text = "Connexion de la Session :" & CLogin.Text
                frmIndex.Refresh()
                Bool = WritePrivateProfileString("CONNEXION", "DERNIERUSER", Trim(CLogin.Text), fichierini)
                'If Oledatable.Rows(0).Item("satut") = "Administrateur" Then

                'Else
                '    MenuPrincipal.NewToolStripMenuItem.Enabled = False
                '    'MenuPrincipal.SaveToolStripMenuItem.Enabled = False
                '    MenuPrincipal.UndoToolStripMenuItem.Enabled = False
                'End If
                frmIndex.Show()
                Me.Close()
            Else
                'Call fermeAccess()
                MessageBox.Show("Connexion échouée, vérifiez le Login/Mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                CLogin.Focus()
            End If
        End If

    End Sub

    Private Sub annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles annuler.Click
        Me.Close()
        End
    End Sub

End Class