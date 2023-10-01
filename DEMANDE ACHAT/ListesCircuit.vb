Imports System.Data.OleDb
Imports System.IO
Public Class ListesCircuit
    Public NewSaisie As Boolean
    Public OpenRejet As Boolean
    Private Sub ListesCircuit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AfficheCircuit()
    End Sub
    Public Sub AfficheCircuit()
        Try
            Dim i As Integer
            Dim OleAdaptaterschema As OleDbDataAdapter
            Dim OleSchemaDataset As DataSet
            Dim OledatableSchema As DataTable
            DataListeSchema.Rows.Clear()
            OleAdaptaterschema = New OleDbDataAdapter("select * from CIRCUITVALIDATION", sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)
            DataListeSchema.RowCount = OledatableSchema.Rows.Count
            If OledatableSchema.Rows.Count <> 0 Then
                For i = 0 To OledatableSchema.Rows.Count - 1
                    DataListeSchema.Rows(i).Cells("Code").Value = OledatableSchema.Rows(i).Item("CodeCircuitVa")
                    DataListeSchema.Rows(i).Cells("Libelle").Value = OledatableSchema.Rows(i).Item("Intitule")
                Next i
                'DataListeSchema.Rows(0).Selected = True
            End If
            Btouvrir.Enabled = False
            BtSupprimer.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataListeSchema_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListeSchema.CellClick
        DataListeSchema.Rows(e.RowIndex).Selected = True
        Btouvrir.Enabled = True
        BtSupprimer.Enabled = True
    End Sub
    Private Sub DataListeSchema_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListeSchema.CellDoubleClick
        If DataListeSchema.RowCount > 0 Then
            OpenRejet = True
            CreationCircuit.Etapefin = 0
            affiche1CircuitValidation()
            CreationCircuit.ShowDialog()
        End If
    End Sub
    Private Sub affiche1CircuitValidation()
        Dim i As Integer
        Dim OleAdaptaterschema As OleDbDataAdapter
        Dim OleSchemaDataset As DataSet
        Dim OledatableSchema As DataTable
        Dim OleAdaptaterschema1 As OleDbDataAdapter
        Dim OleSchemaDataset1 As DataSet
        Dim OledatableSchema1 As DataTable

        OleAdaptaterschema = New OleDbDataAdapter("select * from CIRCUITVALIDATION where CodeCircuitVa='" & Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Code").Value) & "'", sqlConAppli)
        OleSchemaDataset = New DataSet
        OleAdaptaterschema.Fill(OleSchemaDataset)
        OledatableSchema = OleSchemaDataset.Tables(0)
        If OledatableSchema.Rows.Count <> 0 Then
            Dim IsUse As Boolean = False
            'OleAdaptaterschema1 = New OleDbDataAdapter("select * from DETAILMVTSORTIE where CodeCircuitVa='" & Trim(OledatableSchema.Rows(0).Item("CodeCircuitVa")) & "'", sqlConAppli)
            'OleSchemaDataset1 = New DataSet
            'OleAdaptaterschema1.Fill(OleSchemaDataset1)
            'OledatableSchema1 = OleSchemaDataset1.Tables(0)
            'If OledatableSchema1.Rows.Count > 0 Then
            '    IsUse = True
            'End If
            CreationCircuit.TxtCodeCir.Enabled = False
            CreationCircuit.CodeIni.Enabled = False
            CreationCircuit.LibelleIni.Enabled = False
            CreationCircuit.ComboEtapefin.Enabled = False
            CreationCircuit.ComboEtapefin.BackColor = Color.Gray
            CreationCircuit.TxtLibelleFinal.Enabled = False
            CreationCircuit.TxtCodeCir.Text = OledatableSchema.Rows(0).Item("CodeCircuitVa")
            CreationCircuit.TxtLibelleCir.Text = OledatableSchema.Rows(0).Item("Intitule")
            CreationCircuit.CodeIni.Text = OledatableSchema.Rows(0).Item("CodeEtapeInitial")
            CreationCircuit.ComboEtapefin.Text = OledatableSchema.Rows(0).Item("CodeEtapeFin")
            CreationCircuit.LibelleIni.Text = LibelleEtape(Trim(OledatableSchema.Rows(0).Item("CodeEtapeInitial")))
            CreationCircuit.TxtLibelleFinal.Text = LibelleEtape(Trim(OledatableSchema.Rows(0).Item("CodeEtapeFin")))
            CreationCircuit.DataListeSchema.Rows.Clear()
            OleAdaptaterschema1 = New OleDbDataAdapter("select * from EtapePossible where CodeCircuitVa='" & Trim(OledatableSchema.Rows(0).Item("CodeCircuitVa")) & "' ORDER BY ordre", sqlConAppli)
            OleSchemaDataset1 = New DataSet
            OleAdaptaterschema1.Fill(OleSchemaDataset1)
            OledatableSchema1 = OleSchemaDataset1.Tables(0)
            If OledatableSchema1.Rows.Count > 0 Then
                Dim last As Integer
                For i = 0 To OledatableSchema1.Rows.Count - 1
                    CreationCircuit.DataListeSchema.Rows.Add()
                    last = i
                    CreationCircuit.DataListeSchema.Rows(last).Cells("Ordre").Value = Trim(OledatableSchema1.Rows(i).Item("ordre"))
                    CreationCircuit.DataListeSchema.Rows(last).Cells("EtapeCourante").Value = Trim(OledatableSchema1.Rows(i).Item("CodeEtapeCourant"))
                    CreationCircuit.DataListeSchema.Rows(last).Cells("LibelleEtapeCourante").Value = LibelleEtape(Trim(OledatableSchema1.Rows(i).Item("CodeEtapeCourant")))
                    If Trim(OledatableSchema1.Rows(i).Item("CodeEtapeSuivant")) <> "" Then
                        CreationCircuit.alimentationComboDatagrid(last)
                        CreationCircuit.DataListeSchema.Rows(last).Cells("EtapeSuivante").Value = Trim(OledatableSchema1.Rows(i).Item("CodeEtapeSuivant"))
                        CreationCircuit.DataListeSchema.Rows(last).Cells("LibelleEtapeSuivante").Value = LibelleEtape(Trim(OledatableSchema1.Rows(i).Item("CodeEtapeSuivant")))
                    Else
                        CreationCircuit.DataListeSchema.Rows(last).Cells("fin").Value = "fin"
                        CreationCircuit.DataListeSchema.Rows(last).Cells("EtapeSuivante").ReadOnly = True
                        CreationCircuit.DataListeSchema.Rows(last).Cells("LibelleEtapeSuivante").Value = ""
                    End If
                    If IsUse = True Then
                        CreationCircuit.DataListeSchema.Rows(last).Cells("EtapeSuivante").ReadOnly = False
                    End If
                Next i
                If IsUse = True Then
                    CreationCircuit.BT_DelRow.Enabled = False
                Else
                    CreationCircuit.BT_DelRow.Enabled = True
                End If
            End If
        End If

    End Sub
    Private Sub BtFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtFermer.Click
        Me.Close()
    End Sub

    Private Sub Btouvrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btouvrir.Click
        If DataListeSchema.RowCount > 0 Then
            OpenRejet = True
            NewSaisie = False
            CreationCircuit.Etapefin = 0
            affiche1CircuitValidation()
            CreationCircuit.MdiParent = frmIndex
            CreationCircuit.Show()
        End If
    End Sub

    Private Sub BtNouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNouveau.Click
        NewSaisie = True
        OpenRejet = False
        CreationCircuit.Etapefin = 0
        CreationCircuit.ShowDialog()
    End Sub
    Private Sub BtSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSupprimer.Click
        Dim OleCommandEnreg As OleDbCommand
        Dim Insertion As String
        If DataListeSchema.RowCount > 0 Then
            Insertion = "DELETE CIRCUITVALIDATION WHERE CodeCircuitVa='" & Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Code").Value) & "'"
            OleCommandEnreg = New OleDbCommand(Insertion)
            OleCommandEnreg.Connection = sqlConAppli
            OleCommandEnreg.ExecuteNonQuery()
            Insertion = "DELETE EtapePossible WHERE CodeCircuitVa='" & Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Code").Value) & "'"
            OleCommandEnreg = New OleDbCommand(Insertion)
            OleCommandEnreg.Connection = sqlConAppli
            OleCommandEnreg.ExecuteNonQuery()
            AfficheCircuit()
            Me.Refresh()
        End If
    End Sub
    Private Function LibelleEtape(ByVal CodeEtape As String) As String
        Dim OleAdaptaterschema As OleDbDataAdapter
        Dim OleSchemaDataset As DataSet
        Dim OledatableSchema As DataTable
        Dim resultat As String
        resultat = ""
        OleAdaptaterschema = New OleDbDataAdapter("select * from Etape where CodeEtape='" & Trim(CodeEtape) & "'", sqlConAppli)
        OleSchemaDataset = New DataSet
        OleAdaptaterschema.Fill(OleSchemaDataset)
        OledatableSchema = OleSchemaDataset.Tables(0)
        If OledatableSchema.Rows.Count > 0 Then
            resultat = Trim(OledatableSchema.Rows(0).Item("Intitule"))
        End If
        Return resultat
    End Function

End Class