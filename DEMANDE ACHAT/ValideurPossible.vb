Imports System.Data.OleDb
Imports System.IO
Public Class ValideurPossible
    Dim OleAdaptaterEnreg, OleAdaptaterEnreg1, OleAdaptaterEnreg2 As OleDbDataAdapter
    Dim OleEnregDataset, OleEnregDataset1, OleEnregDataset2 As DataSet
    Dim OledatableEnreg, OledatableEnreg1, OledatableEnreg2 As DataTable
    Dim OleCommandEnreg As OleDbCommand
    Dim insertion As String
    Private Sub ValideurPossible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        afficheValideur()
    End Sub
    Private Sub BSup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSup.Click
        Me.Close()
    End Sub
    Private Sub afficheValideur()
        Dim i As Integer
        OleAdaptaterEnreg = New OleDbDataAdapter("select * From Utilisateurs", sqlConAppli)
        OleEnregDataset = New DataSet
        OleAdaptaterEnreg.Fill(OleEnregDataset)
        OledatableEnreg = OleEnregDataset.Tables(0)
        GrvTraitement.Rows.Clear()
        GrvTraitement.RowCount = OledatableEnreg.Rows.Count
        If OledatableEnreg.Rows.Count > 0 Then
            For i = 0 To OledatableEnreg.Rows.Count - 1
                GrvTraitement.Rows(i).Cells("NomPrenom").Value = OledatableEnreg.Rows(i).Item("Nom") & " " & OledatableEnreg.Rows(i).Item("Prenom")
                GrvTraitement.Rows(i).Cells("Fonction").Value = OledatableEnreg.Rows(i).Item("Fonction")
                GrvTraitement.Rows(i).Cells("Login").Value = OledatableEnreg.Rows(i).Item("CodeUtilisateur")
            Next
        End If
    End Sub
    Private Sub BtValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtValider.Click
        Dim Nomprenom As String
        Dim Last As Integer
        Dim premierEtape As Integer
        If Trim(FrmRegleValidation.CircuitVa) <> "" And Trim(FrmRegleValidation.CodeEtapeSuivant) <> "" Then
            If GrvTraitement.SelectedRows.Count > 0 Then
                OleAdaptaterEnreg = New OleDbDataAdapter("select * From Signataire WHERE (CodeCircuitVa='" & Trim(FrmRegleValidation.CircuitVa) & "' And CodeEtape='" & Trim(FrmRegleValidation.CodeEtapeSuivant) & "') And Signataire='" & GrvTraitement.Rows(GrvTraitement.CurrentRow.Index).Cells("Login").Value & "'", sqlConAppli)
                OleEnregDataset = New DataSet
                OleAdaptaterEnreg.Fill(OleEnregDataset)
                OledatableEnreg = OleEnregDataset.Tables(0)
                If OledatableEnreg.Rows.Count > 0 Then

                Else
                    premierEtape = FrmRegleValidation.DataListEtapeCourante.Rows.GetFirstRow(DataGridViewElementStates.Displayed)
                    If IndexEtapeC = premierEtape Then
                        Nomprenom = GrvTraitement.Rows(GrvTraitement.CurrentRow.Index).Cells("NomPrenom").Value
                        insertion = "Insert into Signataire (CodeCircuitVa,LibelleEtape,Signataire,NomPrenom,CodeEtape,NautoEpo) values('" & Trim(FrmRegleValidation.CircuitVa) & "','" & Trim(FrmRegleValidation.LibelleEtapeSuivant) & "','" & GrvTraitement.Rows(GrvTraitement.CurrentRow.Index).Cells("Login").Value & "','" & Nomprenom & "','" & Trim(FrmRegleValidation.CodeEtapeSuivant) & "'," & FrmRegleValidation.DataListEtapeCourante.Rows(FrmRegleValidation.DataListEtapeCourante.CurrentRow.Index).Cells("NautoEtapePo").Value & ")"
                        OleCommandEnreg = New OleDbCommand(insertion)
                        OleCommandEnreg.Connection = sqlConAppli
                        OleCommandEnreg.ExecuteNonQuery()
                        FrmRegleValidation.DataListeSchema.Rows.Add()
                        Last = FrmRegleValidation.DataListeSchema.Rows.GetLastRow(DataGridViewElementStates.Displayed)
                        FrmRegleValidation.DataListeSchema.Rows(Last).Cells("EtapeValide").Value = Trim(FrmRegleValidation.LibelleEtapeSuivant)
                        FrmRegleValidation.DataListeSchema.Rows(Last).Cells("Signataire").Value = Nomprenom
                        FrmRegleValidation.DataListeSchema.Rows(Last).Cells("CodeEtape").Value = Trim(FrmRegleValidation.CodeEtapeSuivant)
                        FrmRegleValidation.DataListeSchema.Rows(Last).Cells("Login").Value = Trim(GrvTraitement.Rows(GrvTraitement.CurrentRow.Index).Cells("Login").Value)
                        FrmRegleValidation.BT_DelRow.Enabled = True
                    ElseIf IndexEtapeC > premierEtape Then
                        Dim indepreced As Integer
                        Dim CodeEtape As String
                        indepreced = FrmRegleValidation.DataListEtapeCourante.Rows.GetPreviousRow(IndexEtapeC, DataGridViewElementStates.Displayed)
                        CodeEtape = FrmRegleValidation.DataListEtapeCourante.Rows(indepreced).Cells("EtapeCourante").Value
                        OleAdaptaterEnreg2 = New OleDbDataAdapter("select * From EtapePossible WHERE (CodeCircuitVa='" & Trim(FrmRegleValidation.CircuitVa) & "' And CodeEtapeCourant='" & Trim(CodeEtape) & "')", sqlConAppli)
                        OleEnregDataset2 = New DataSet
                        OleAdaptaterEnreg2.Fill(OleEnregDataset2)
                        OledatableEnreg2 = OleEnregDataset2.Tables(0)
                        If OledatableEnreg2.Rows.Count > 0 Then
                            Nomprenom = GrvTraitement.Rows(GrvTraitement.CurrentRow.Index).Cells("NomPrenom").Value
                            insertion = "Insert into Signataire (CodeCircuitVa,LibelleEtape,Signataire,NomPrenom,CodeEtape,NautoEpo) values('" & Trim(FrmRegleValidation.CircuitVa) & "','" & Trim(FrmRegleValidation.LibelleEtapeSuivant) & "','" & GrvTraitement.Rows(GrvTraitement.CurrentRow.Index).Cells("Login").Value & "','" & Nomprenom & "','" & Trim(FrmRegleValidation.CodeEtapeSuivant) & "'," & FrmRegleValidation.DataListEtapeCourante.Rows(FrmRegleValidation.DataListEtapeCourante.CurrentRow.Index).Cells("NautoEtapePo").Value & ")"
                            OleCommandEnreg = New OleDbCommand(insertion)
                            OleCommandEnreg.Connection = sqlConAppli
                            OleCommandEnreg.ExecuteNonQuery()
                            FrmRegleValidation.DataListeSchema.Rows.Add()
                            Last = FrmRegleValidation.DataListeSchema.Rows.GetLastRow(DataGridViewElementStates.Displayed)
                            FrmRegleValidation.DataListeSchema.Rows(Last).Cells("EtapeValide").Value = Trim(FrmRegleValidation.LibelleEtapeSuivant)
                            FrmRegleValidation.DataListeSchema.Rows(Last).Cells("Signataire").Value = Nomprenom
                            FrmRegleValidation.DataListeSchema.Rows(Last).Cells("CodeEtape").Value = Trim(FrmRegleValidation.CodeEtapeSuivant)
                            FrmRegleValidation.DataListeSchema.Rows(Last).Cells("Login").Value = Trim(GrvTraitement.Rows(GrvTraitement.CurrentRow.Index).Cells("Login").Value)
                            FrmRegleValidation.BT_DelRow.Enabled = True

                            'OleAdaptaterEnreg1 = New OleDbDataAdapter("select * From Signataire WHERE (CodeCircuitVa='" & Trim(FrmRegleValidation.CircuitVa) & "' And CodeEtape='" & Trim(OledatableEnreg2.Rows(0).Item("CodeEtapeSuivant")) & "') And Signataire='" & GrvTraitement.Rows(GrvTraitement.CurrentRow.Index).Cells("Login").Value & "'", sqlConAppli)
                            'OleEnregDataset1 = New DataSet
                            'OleAdaptaterEnreg1.Fill(OleEnregDataset1)
                            'OledatableEnreg1 = OleEnregDataset1.Tables(0)
                            'If OledatableEnreg1.Rows.Count > 0 Then
                            '    MessageBox.Show("CET utilisateur est valideur de l'etape précedente", "Choix valideur", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Else
                            '    Nomprenom = GrvTraitement.Rows(GrvTraitement.CurrentRow.Index).Cells("NomPrenom").Value
                            '    insertion = "Insert into Signataire (CodeCircuitVa,LibelleEtape,Signataire,NomPrenom,CodeEtape,NautoEpo) values('" & Trim(FrmRegleValidation.CircuitVa) & "','" & Trim(FrmRegleValidation.LibelleEtapeSuivant) & "','" & GrvTraitement.Rows(GrvTraitement.CurrentRow.Index).Cells("Login").Value & "','" & Nomprenom & "','" & Trim(FrmRegleValidation.CodeEtapeSuivant) & "'," & FrmRegleValidation.DataListEtapeCourante.Rows(FrmRegleValidation.DataListEtapeCourante.CurrentRow.Index).Cells("NautoEtapePo").Value & ")"
                            '    OleCommandEnreg = New OleDbCommand(insertion)
                            '    OleCommandEnreg.Connection = sqlConAppli
                            '    OleCommandEnreg.ExecuteNonQuery()
                            '    FrmRegleValidation.DataListeSchema.Rows.Add()
                            '    Last = FrmRegleValidation.DataListeSchema.Rows.GetLastRow(DataGridViewElementStates.Displayed)
                            '    FrmRegleValidation.DataListeSchema.Rows(Last).Cells("EtapeValide").Value = Trim(FrmRegleValidation.LibelleEtapeSuivant)
                            '    FrmRegleValidation.DataListeSchema.Rows(Last).Cells("Signataire").Value = Nomprenom
                            '    FrmRegleValidation.DataListeSchema.Rows(Last).Cells("CodeEtape").Value = Trim(FrmRegleValidation.CodeEtapeSuivant)
                            '    FrmRegleValidation.DataListeSchema.Rows(Last).Cells("Login").Value = Trim(GrvTraitement.Rows(GrvTraitement.CurrentRow.Index).Cells("Login").Value)
                            '    FrmRegleValidation.BT_DelRow.Enabled = True
                            'End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class