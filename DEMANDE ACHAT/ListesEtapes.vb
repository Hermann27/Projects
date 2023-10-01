Imports System.Data.OleDb
Imports System.IO
Public Class ListesEtapes
    Public NewSaisie As Boolean
    Public OpenRejet As Boolean
    Private Sub ListesCircuit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AffichEtapes()
    End Sub
    Public Sub AffichEtapes()
        Try
            Dim i As Integer
            Dim OleAdaptaterschema As OleDbDataAdapter
            Dim OleSchemaDataset As DataSet
            Dim OledatableSchema As DataTable
            DataListeSchema.Rows.Clear()
            OleAdaptaterschema = New OleDbDataAdapter("select * from Etape where IDOetap=1000", sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)
            DataListeSchema.RowCount = OledatableSchema.Rows.Count
            If OledatableSchema.Rows.Count <> 0 Then
                For i = 0 To OledatableSchema.Rows.Count - 1
                    DataListeSchema.Rows(i).Cells("Code").Value = OledatableSchema.Rows(i).Item("CodeEtape")
                    DataListeSchema.Rows(i).Cells("Libelle").Value = OledatableSchema.Rows(i).Item("Intitule")
                Next i
                Btouvrir.Enabled = False
                BtSupprimer.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataListeSchema_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListeSchema.CellClick
if e.rowindex>=0
        DataListeSchema.Rows(e.RowIndex).Selected = True
        Btouvrir.Enabled = True
        BtSupprimer.Enabled = True
End If
    End Sub
    Private Sub DataListeSchema_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListeSchema.CellDoubleClick
        If DataListeSchema.RowCount > 0 Then
            OpenRejet = True
            affiche1EtapeValidation()
            EtapeValidation.ShowDialog()
        End If

    End Sub
    Private Sub affiche1EtapeValidation()
        Dim OleAdaptaterschema As OleDbDataAdapter
        Dim OleSchemaDataset As DataSet
        Dim OledatableSchema As DataTable

        OleAdaptaterschema = New OleDbDataAdapter("select * from Etape where CodeEtape='" & Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Code").Value) & "' AND IDOetap=1000", sqlConAppli)
        OleSchemaDataset = New DataSet
        OleAdaptaterschema.Fill(OleSchemaDataset)
        OledatableSchema = OleSchemaDataset.Tables(0)

        If OledatableSchema.Rows.Count <> 0 Then
            EtapeValidation.TxtCodeIni.Enabled = False
            EtapeValidation.TxtCodeIni.Text = OledatableSchema.Rows(0).Item("CodeEtape")
            EtapeValidation.TxtLibelleIni.Text = OledatableSchema.Rows(0).Item("Intitule")
        End If

    End Sub
    Private Sub BtFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFermer.Click
        Me.Close()
    End Sub

    Private Sub Btouvrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btouvrir.Click
        OpenRejet = True
        affiche1EtapeValidation()
        EtapeValidation.MdiParent = frmIndex
        EtapeValidation.Show()
    End Sub

    Private Sub BtNouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNouveau.Click
        NewSaisie = True
        EtapeValidation.ShowDialog()
    End Sub
    Private Sub BtSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSupprimer.Click
        Dim OleCommandEnreg As OleDbCommand
        Dim Insertion As String
        Dim OleAdaptaterschema As OleDbDataAdapter
        Dim OleSchemaDataset As DataSet
        Dim OledatableSchema As DataTable
        If DataListeSchema.RowCount > 0 Then
            OleAdaptaterschema = New OleDbDataAdapter("select * from EtapePossible where CodeEtapeCourant='" & Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Code").Value) & "'", sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)
            If OledatableSchema.Rows.Count > 0 Then
                MsgBox("Impossible de supprimer des circuits y sont li�es", MsgBoxStyle.Information, "ETAPE VALIDATION")
            Else
                Insertion = "DELETE Etape WHERE CodeEtape='" & Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Code").Value) & "' AND IDOetap=1000"
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                AffichEtapes()
                Btouvrir.Enabled = False
                BtSupprimer.Enabled = False
                Me.Refresh()
            End If
        End If
    End Sub

    Private Sub DataListeSchema_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListeSchema.CellContentClick

    End Sub
End Class