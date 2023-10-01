Imports System.Data.OleDb
Imports System.IO
Public Class ListesCatDemandeurs
    Public NewSaisie As Boolean
    Public OpenRejet As Boolean

    Private Sub ListesCatDemandeurs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        afficheCatDemandeurs()
    End Sub
    Public Sub afficheCatDemandeurs()
        Try
            Dim i As Integer
            Dim OleAdaptaterschema As OleDbDataAdapter
            Dim OleSchemaDataset As DataSet
            Dim OledatableSchema As DataTable
            DataListeSchema.Rows.Clear()
            OleAdaptaterschema = New OleDbDataAdapter("select * from NatureValidation", sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)
            DataListeSchema.RowCount = OledatableSchema.Rows.Count
            If OledatableSchema.Rows.Count <> 0 Then
                For i = 0 To OledatableSchema.Rows.Count - 1
                    DataListeSchema.Rows(i).Cells("Code").Value = OledatableSchema.Rows(i).Item("CodeNatureVa")
                    DataListeSchema.Rows(i).Cells("Libelle").Value = OledatableSchema.Rows(i).Item("Intitule")
                Next i
                DataListeSchema.Rows(0).Selected = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btouvrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btouvrir.Click
        OpenRejet = True
        NewSaisie = False
        affiche1CatDemandeur()
        CategorieDemandeur.MdiParent = frmIndex
        CategorieDemandeur.Show()
        OpenRejet = False
    End Sub
    Private Sub affiche1CatDemandeur()
        Try
            Dim OleAdaptaterschema As OleDbDataAdapter
            Dim OleSchemaDataset As DataSet
            Dim OledatableSchema As DataTable

            OleAdaptaterschema = New OleDbDataAdapter("select * from NatureValidation WHERE CodeNatureVa='" & Trim(Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Code").Value)) & "'", sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)

            If OledatableSchema.Rows.Count <> 0 Then
                CategorieDemandeur.TxtCodeIni.Enabled = False
                CategorieDemandeur.TxtCodeIni.Text = OledatableSchema.Rows(0).Item("CodeNatureVa")
                CategorieDemandeur.TxtLibelleIni.Text = OledatableSchema.Rows(0).Item("Intitule")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFermer.Click
        Me.Close()
    End Sub

    Private Sub BtNouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNouveau.Click
        NewSaisie = True
        CategorieDemandeur.MdiParent = frmIndex
        CategorieDemandeur.Show()
    End Sub

    Private Sub BtSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSupprimer.Click
        Try
            Dim OleAdaptaterschema, OleAdaptaterschema1 As OleDbDataAdapter
            Dim OleSchemaDataset, OleSchemaDataset1 As DataSet
            Dim OledatableSchema, OledatableSchema1 As DataTable
            Dim OleCommandEnreg As OleDbCommand
            Dim Insertion As String
            Dim i, j As Integer
            If DataListeSchema.RowCount > 0 Then
                If Trim(Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Code").Value)) <> "" Then
                    Insertion = "DELETE NatureValidation WHERE CodeNatureVa='" & Trim(Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Code").Value)) & "'"
                    OleCommandEnreg = New OleDbCommand(Insertion)
                    OleCommandEnreg.Connection = sqlConAppli
                    OleCommandEnreg.ExecuteNonQuery()
                    OleAdaptaterschema = New OleDbDataAdapter("select * from NatureValidationDetail where CodeNatureVa='" & Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Code").Value) & "'", sqlConAppli)
                    OleSchemaDataset = New DataSet
                    OleAdaptaterschema.Fill(OleSchemaDataset)
                    OledatableSchema = OleSchemaDataset.Tables(0)
                    If OledatableSchema.Rows.Count > 0 Then
                        For i = 0 To OledatableSchema.Rows.Count - 1
                            Insertion = "DELETE RegleValidation WHERE NautoRegleVa=" & OledatableSchema.Rows(i).Item("NautoRegleVa")
                            OleCommandEnreg = New OleDbCommand(Insertion)
                            OleCommandEnreg.Connection = sqlConAppli
                            OleCommandEnreg.ExecuteNonQuery()
                            Insertion = "DELETE RegleValidationDetail WHERE NautoRegleVa=" & OledatableSchema.Rows(i).Item("NautoRegleVa")
                            OleCommandEnreg = New OleDbCommand(Insertion)
                            OleCommandEnreg.Connection = sqlConAppli
                            OleCommandEnreg.ExecuteNonQuery()
                            OleAdaptaterschema1 = New OleDbDataAdapter("select * from ValidationEtape where NautoRegleVa=" & OledatableSchema.Rows(i).Item("NautoRegleVa"), sqlConAppli)
                            OleSchemaDataset1 = New DataSet
                            OleAdaptaterschema1.Fill(OleSchemaDataset1)
                            OledatableSchema1 = OleSchemaDataset1.Tables(0)
                            If OledatableSchema1.Rows.Count > 0 Then
                                For j = 0 To OledatableSchema1.Rows.Count - 1
                                    Insertion = "DELETE ValideurPossible WHERE NautoVe=" & OledatableSchema1.Rows(j).Item("NautoVe")
                                    OleCommandEnreg = New OleDbCommand(Insertion)
                                    OleCommandEnreg.Connection = sqlConAppli
                                    OleCommandEnreg.ExecuteNonQuery()
                                Next j
                                Insertion = "DELETE ValidationEtape WHERE NautoRegleVa=" & OledatableSchema.Rows(i).Item("NautoRegleVa")
                                OleCommandEnreg = New OleDbCommand(Insertion)
                                OleCommandEnreg.Connection = sqlConAppli
                                OleCommandEnreg.ExecuteNonQuery()
                            End If
                        Next i
                        Insertion = "DELETE NatureValidationDetail where CodeNatureVa='" & Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Code").Value) & "'"
                        OleCommandEnreg = New OleDbCommand(Insertion)
                        OleCommandEnreg.Connection = sqlConAppli
                        OleCommandEnreg.ExecuteNonQuery()
                    End If
                    afficheCatDemandeurs()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "CAISSE WAZA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataListeSchema_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListeSchema.CellClick
        If e.RowIndex >= 0 Then
            DataListeSchema.Rows(e.RowIndex).Selected = True
        End If
    End Sub
End Class