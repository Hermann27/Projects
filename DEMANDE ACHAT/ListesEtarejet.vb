Imports System.Data.OleDb
Imports System.IO
Public Class ListesEtarejet
    Public NewSaisie As Boolean
    Public OpenRejet As Boolean
    Private Sub ListesCircuit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AffichEtapRejet()
    End Sub
    Public Sub AffichEtapRejet()
        Try
            Dim i As Integer
            Dim OleAdaptaterschema As OleDbDataAdapter
            Dim OleSchemaDataset As DataSet
            Dim OledatableSchema As DataTable
            DataListeSchema.Rows.Clear()
            OleAdaptaterschema = New OleDbDataAdapter("select * from Etape where IDOetap=1002", sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)
            DataListeSchema.RowCount = OledatableSchema.Rows.Count
            For i = 0 To OledatableSchema.Rows.Count - 1
                DataListeSchema.Rows(i).Cells("Code").Value = OledatableSchema.Rows(i).Item("CodeEtape")
                DataListeSchema.Rows(i).Cells("Libelle").Value = OledatableSchema.Rows(i).Item("Intitule")
                If OledatableSchema.Rows(i).Item("Definitif") = True Then
                    DataListeSchema.Rows(i).Cells("Definitif").Value = True
                Else
                    DataListeSchema.Rows(i).Cells("Definitif").Value = False
                End If
            Next i
            Btouvrir.Enabled = False
            BtSupprimer.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataListeSchema_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListeSchema.CellClick
        if e.RowIndex >=0
        DataListeSchema.Rows(e.RowIndex).Selected = True
        Btouvrir.Enabled = True
        BtSupprimer.Enabled = True
        End If
    End Sub
    Private Sub DataListeSchema_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListeSchema.CellDoubleClick
        If DataListeSchema.RowCount > 0 Then
            OpenRejet = True
            affiche1EtapeRejet()
            EtapeRejet.ShowDialog()
        End If
    End Sub
    Private Sub affiche1EtapeRejet()
        Dim i As Integer
        Dim OleAdaptaterschema As OleDbDataAdapter
        Dim OleSchemaDataset As DataSet
        Dim OledatableSchema As DataTable

        OleAdaptaterschema = New OleDbDataAdapter("select * from Etape where CodeEtape='" & Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Code").Value) & "'", sqlConAppli)
        OleSchemaDataset = New DataSet
        OleAdaptaterschema.Fill(OleSchemaDataset)
        OledatableSchema = OleSchemaDataset.Tables(0)

        If OledatableSchema.Rows.Count <> 0 Then
            EtapeRejet.TxtCodeIni.Enabled = False
            EtapeRejet.TxtCodeIni.Text = OledatableSchema.Rows(0).Item("CodeEtape")
            EtapeRejet.TxtLibelleIni.Text = OledatableSchema.Rows(0).Item("Intitule")
            If OledatableSchema.Rows(i).Item("Definitif") = True Then
                EtapeRejet.CheckBox1.Checked = True
            Else
                EtapeRejet.CheckBox1.Checked = False
            End If
        End If

    End Sub
    Private Sub BtFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFermer.Click
        Me.Close()
    End Sub

    Private Sub Btouvrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btouvrir.Click
        OpenRejet = True
        affiche1EtapeRejet()
        EtapeRejet.MdiParent = frmIndex
        EtapeRejet.Show()
    End Sub

    Private Sub BtNouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNouveau.Click
        NewSaisie = True
        EtapeRejet.MdiParent = frmIndex
        EtapeRejet.Show()
    End Sub
    Private Sub BtSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSupprimer.Click
        Dim OleCommandEnreg As OleDbCommand
        Dim Insertion As String
        Dim OleAdaptaterschema As OleDbDataAdapter
        Dim OleSchemaDataset As DataSet
        Dim OledatableSchema As DataTable
        If DataListeSchema.RowCount > 0 Then
            OleAdaptaterschema = New OleDbDataAdapter("select * from DETAILMVTSORTIE where CodeEtape='" & Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Code").Value) & "'", sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)
            If OledatableSchema.Rows.Count > 0 Then
                MessageBox.Show("Cette étape est déja impliquée dans une demande", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Insertion = "DELETE Etape WHERE CodeEtape='" & Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Code").Value) & "' and IDOetap=1002"
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                AffichEtapRejet()
                Btouvrir.Enabled = False
                BtSupprimer.Enabled = False
            End If
            Me.Refresh()
        End If
    End Sub
End Class