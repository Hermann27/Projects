Imports System.Data.OleDb
Imports System.IO
Public Class FrmCaissier
    Dim OleAdaptaterEnreg As OleDbDataAdapter
    Dim OleEnregDataset As DataSet
    Dim OledatableEnreg As DataTable
    Dim OleCommandEnreg As OleDbCommand
    Dim Insertion As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Insert As Boolean

        OleAdaptaterEnreg = New OleDbDataAdapter("select * From Utilisateurs WHERE CodeUtilisateur='" & Trim(TXTLOGIN.Text) & "'", sqlConAppli)
        OleEnregDataset = New DataSet
        OleAdaptaterEnreg.Fill(OleEnregDataset)
        OledatableEnreg = OleEnregDataset.Tables(0)
       
        If OledatableEnreg.Rows.Count > 0 Then
            If Trim(TXTLOGIN.Text) <> "" Or Trim(TXTNOM.Text) <> "" Or Trim(TxtPrenom.Text) <> "" Or Trim(tbCodeCatD.Text) <> "" Then
                Insertion = "update Utilisateurs set Nom='" & Trim(TXTNOM.Text) & "',Prenom='" & Trim(TxtPrenom.Text) & "',Service='" & Trim(TXTSERVICE.Text) & "',Fonction='" & Trim(TxtFonction.Text) & "',Email='" & Trim(TxtEmail.Text) & "',CatDemandeur='" & Trim(tbCodeCatD.Text) & "',LibelleCatDemandeur='" & Trim(TbLibelleCatD.Text) & "' where CodeUtilisateur='" & Trim(TXTLOGIN.Text) & "'"
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                ListesCaissiers.affucheUser()
                Insert = True
            Else
                MsgBox("Certains Champs de votre fomulaire sont vides", MsgBoxStyle.Information, "Création Utilisateur")
                TXTLOGIN.Focus()
            End If
        Else
            If Trim(TXTLOGIN.Text) <> "" Or Trim(TXTNOM.Text) <> "" Or Trim(TxtPrenom.Text) <> "" Or Trim(tbCodeCatD.Text) <> "" Then
                Insertion = "INSERT INTO Utilisateurs(CodeUtilisateur,Prenom,Nom,Service,Fonction,Email,CatDemandeur,LibelleCatDemandeur) Values('" & Trim(TXTLOGIN.Text) & "','" & Trim(TXTNOM.Text) & "','" & Trim(TxtPrenom.Text) & "','" & Trim(TXTSERVICE.Text) & "','" & Trim(TxtFonction.Text) & "','" & Trim(TxtEmail.Text) & "','" & Trim(tbCodeCatD.Text) & "','" & Trim(TbLibelleCatD.Text) & "')"
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                ListesCaissiers.affucheUser()
                Insert = True
            Else
                MsgBox("Certains Champs de votre fomulaire sont vides", MsgBoxStyle.Information, "Création Utilisateur")
                TXTLOGIN.Focus()
            End If
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'CategorieDemandeurPossible.MdiParent = frmIndex
        CategorieDemandeurPossible.ShowDialog()
    End Sub
End Class