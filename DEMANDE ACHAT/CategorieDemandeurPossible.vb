Imports System.Data.OleDb
Imports System.IO
Public Class CategorieDemandeurPossible
    Dim OleAdaptaterEnreg As OleDbDataAdapter
    Dim OleEnregDataset As DataSet
    Dim OledatableEnreg As DataTable
    Dim OleCommandEnreg As OleDbCommand
    Dim insertion As String
    Private Sub CategorieDemandeurPossible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        afficheCategorieDemandeur()
    End Sub
    Private Sub BSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSup.Click
        Me.Close()
    End Sub
    Private Sub afficheCategorieDemandeur()
        Dim i As Integer
        OleAdaptaterEnreg = New OleDbDataAdapter("select * From NatureValidation ", sqlConAppli)
        OleEnregDataset = New DataSet
        OleAdaptaterEnreg.Fill(OleEnregDataset)
        OledatableEnreg = OleEnregDataset.Tables(0)
        GrvTraitement.Rows.Clear()
        GrvTraitement.RowCount = OledatableEnreg.Rows.Count
        If OledatableEnreg.Rows.Count > 0 Then
            For i = 0 To OledatableEnreg.Rows.Count - 1
                GrvTraitement.Rows(i).Cells("CodeNature").Value = OledatableEnreg.Rows(i).Item("CodeNatureVa")
                GrvTraitement.Rows(i).Cells("Libelle").Value = OledatableEnreg.Rows(i).Item("Intitule")
            Next i
        End If
    End Sub
    Private Sub BtValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtValider.Click
        If GrvTraitement.SelectedRows.Count > 0 Then
            FrmCaissier.tbCodeCatD.Text = Trim(GrvTraitement.Rows(GrvTraitement.CurrentRow.Index).Cells("CodeNature").Value)
            FrmCaissier.TbLibelleCatD.Text = Trim(GrvTraitement.Rows(GrvTraitement.CurrentRow.Index).Cells("Libelle").Value)
            Me.Close()
        End If
    End Sub
End Class