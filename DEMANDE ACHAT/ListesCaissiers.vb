Imports System.Data.OleDb
Imports System.IO
Public Class ListesCaissiers
    Dim OleAdaptaterEnreg As OleDbDataAdapter
    Dim OleEnregDataset As DataSet
    Dim OledatableEnreg As DataTable
    Dim OleCommandEnreg As OleDbCommand
    Dim Supression As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmCaissier.MdiParent = frmIndex
        FrmCaissier.Show()
    End Sub
    Private Sub ListesCaissiers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        Button3.Enabled = False
        affucheUser()
    End Sub
    Public Sub affucheUser()
        Dim i As Integer
        DataListeSchema.Rows.Clear()
        OleAdaptaterEnreg = New OleDbDataAdapter("select * From Utilisateurs ", sqlConAppli)
        OleEnregDataset = New DataSet
        OleAdaptaterEnreg.Fill(OleEnregDataset)
        OledatableEnreg = OleEnregDataset.Tables(0)
        DataListeSchema.RowCount = OledatableEnreg.Rows.Count
        If OledatableEnreg.Rows.Count <> 0 Then
            For i = 0 To OledatableEnreg.Rows.Count - 1
                DataListeSchema.Rows(i).Cells("Login").Value = OledatableEnreg.Rows(i).Item("CodeUtilisateur")
                DataListeSchema.Rows(i).Cells("Noms").Value = OledatableEnreg.Rows(i).Item("Nom")
                DataListeSchema.Rows(i).Cells("Prenom").Value = OledatableEnreg.Rows(i).Item("Prenom")
                DataListeSchema.Rows(i).Cells("fonction").Value = OledatableEnreg.Rows(i).Item("Fonction")
            Next i
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        deleteUser()
        affucheUser()
    End Sub
    Private Sub deleteUser()
        Dim sup As Boolean
        Supression = "DELETE Utilisateurs  WHERE CodeUtilisateur='" & Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Login").Value) & "'"
        OleCommandEnreg = New OleDbCommand(Supression)
        OleCommandEnreg.Connection = sqlConAppli
        OleCommandEnreg.ExecuteNonQuery()
        sup = True
        If sup = True Then
            MsgBox("Suppression Reussie", MsgBoxStyle.Information, "Suppression Utilisdateur")
        End If
    End Sub
    Private Sub DataListeSchema_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListeSchema.CellClick
        Button1.Enabled = True
        Button3.Enabled = True
        IF e.rowindex>=0
        DataListeSchema.Rows(e.RowIndex).Selected = True
        End If
    End Sub
    Private Sub DataListeSchema_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListeSchema.CellDoubleClick
        affaiche1User()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        affaiche1User()
    End Sub
    Private Sub affaiche1User()
        OleAdaptaterEnreg = New OleDbDataAdapter("select * From Utilisateurs WHERE CodeUtilisateur='" & Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Login").Value) & "'", sqlConAppli)
        OleEnregDataset = New DataSet
        OleAdaptaterEnreg.Fill(OleEnregDataset)
        OledatableEnreg = OleEnregDataset.Tables(0)
        If OledatableEnreg.Rows.Count <> 0 Then
            'If IsDBNull(OledatableEnreg.Rows(0).Item("Adresse")) = True Then
            '    FrmCaissier.TxtAdres.Text = ""
            'Else
            '    FrmCaissier.TxtAdres.Text = OledatableEnreg.Rows(0).Item("Adresse")
            'End If
            If IsDBNull(OledatableEnreg.Rows(0).Item("Email")) = True Then
                FrmCaissier.TxtEmail.Text = ""
            Else
                FrmCaissier.TxtEmail.Text = OledatableEnreg.Rows(0).Item("Email")
            End If
            If IsDBNull(OledatableEnreg.Rows(0).Item("Fonction")) = True Then
                FrmCaissier.TxtFonction.Text = ""
            Else
                FrmCaissier.TxtFonction.Text = OledatableEnreg.Rows(0).Item("Fonction")
            End If
            If IsDBNull(OledatableEnreg.Rows(0).Item("CodeUtilisateur")) = True Then
                FrmCaissier.TXTLOGIN.Text = ""
            Else
                FrmCaissier.TXTLOGIN.Text = OledatableEnreg.Rows(0).Item("CodeUtilisateur")
            End If
            If IsDBNull(OledatableEnreg.Rows(0).Item("Nom")) = True Then
                FrmCaissier.TXTNOM.Text = ""
            Else
                FrmCaissier.TXTNOM.Text = OledatableEnreg.Rows(0).Item("Nom")
            End If
            If IsDBNull(OledatableEnreg.Rows(0).Item("Prenom")) = True Then
                FrmCaissier.TxtPrenom.Text = ""
            Else
                FrmCaissier.TxtPrenom.Text = OledatableEnreg.Rows(0).Item("Prenom")
            End If
            If IsDBNull(OledatableEnreg.Rows(0).Item("Service")) = True Then
                FrmCaissier.TXTSERVICE.Text = ""
            Else
                FrmCaissier.TXTSERVICE.Text = OledatableEnreg.Rows(0).Item("Service")
            End If
            
            If IsDBNull(OledatableEnreg.Rows(0).Item("CatDemandeur")) = True Then
                FrmCaissier.tbCodeCatD.Text = ""
            Else
                FrmCaissier.tbCodeCatD.Text = OledatableEnreg.Rows(0).Item("CatDemandeur")
            End If
            If IsDBNull(OledatableEnreg.Rows(0).Item("LibelleCatDemandeur")) = True Then
                FrmCaissier.TbLibelleCatD.Text = ""
            Else
                FrmCaissier.TbLibelleCatD.Text = OledatableEnreg.Rows(0).Item("LibelleCatDemandeur")
            End If
            FrmCaissier.MdiParent = frmIndex
            FrmCaissier.Show()
            'FrmCaissier.ShowDialog()
        End If
    End Sub
    Private Sub DataListeSchema_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListeSchema.CellContentClick
        if e.RowIndex >=0
        DataListeSchema.Rows(e.RowIndex).Selected = True
        End If
    End Sub
End Class