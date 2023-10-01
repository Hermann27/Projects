Imports System.Data.OleDb
Imports System.IO
Public Class FrmRegleValidation
    Dim OleAdaptaterschema, OleAdaptaterschema1, OleAdaptaterschema2, OleAdaptaterschema3 As OleDbDataAdapter
    Dim OleSchemaDataset, OleSchemaDataset1, OleSchemaDataset2, OleSchemaDataset3 As DataSet
    Dim OledatableSchema, OledatableSchema1, OledatableSchema2, OledatableSchema3 As DataTable
    Dim OleCommandEnreg As OleDbCommand
    Public LibelleEtapeSuivant As String
    Public CodeEtapeSuivant
    Public CircuitVa As String
    Dim Insertion As String
    Dim NumAutoRegleVa, GesComCir As Integer
    Private Sub FrmRegleValidation_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Insertion = "Delete Signataire"
        OleCommandEnreg = New OleDbCommand(Insertion)
        OleCommandEnreg.Connection = sqlConAppli
        OleCommandEnreg.ExecuteNonQuery()
    End Sub
    Private Sub FrmRegleValidation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If NatureValidation.ModficationRegle = True Then
            GesComCir = 0
            alimComboDevise()
            Devise.Text = NatureValidation.Devise
            alimComboCircuit()
            ComboCircuit.Text = NatureValidation.Circuit
            ComboCircuit.Enabled = False
            ComboCircuit.BackColor = Color.Gray
            affichEtapeCourante(Trim(NatureValidation.Circuit))
            afficheValideur()
        ElseIf NatureValidation.CreationRegle = True Then
            GesComCir = 0
            alimComboDevise()
            alimComboCircuit()
            ComboCircuit.Enabled = True
            ComboCircuit.Text = ""
            Devise.Text = ""
            GesComCir = GesComCir + 1
        End If
    End Sub
    Private Sub alimComboDevise()
        OleAdaptaterschema = New OleDbDataAdapter("select * from P_DEVISE", sqlCon)
        OleSchemaDataset = New DataSet
        OleAdaptaterschema.Fill(OleSchemaDataset)
        OledatableSchema = OleSchemaDataset.Tables(0)
        If OledatableSchema.Rows.Count > 0 Then
            Devise.DataSource = OledatableSchema
            Devise.DisplayMember = "D_Monnaie"
        End If
    End Sub
    Private Sub alimComboCircuit()
        OleAdaptaterschema = New OleDbDataAdapter("select * from CIRCUITVALIDATION", sqlConAppli)
        OleSchemaDataset = New DataSet
        OleAdaptaterschema.Fill(OleSchemaDataset)
        OledatableSchema = OleSchemaDataset.Tables(0)
        If OledatableSchema.Rows.Count > 0 Then
            ComboCircuit.DataSource = OledatableSchema
            ComboCircuit.DisplayMember = "CodeCircuitVa"
        End If
    End Sub

    Private Sub ComboCircuit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboCircuit.SelectedIndexChanged
        If NatureValidation.ModficationRegle = True Then
         
        ElseIf NatureValidation.CreationRegle = True Then
            If Trim(ComboCircuit.Text) <> "" And GesComCir >= 1 Then
                OleAdaptaterschema = New OleDbDataAdapter("select * from CIRCUITVALIDATION where CodeCircuitVa='" & Trim(ComboCircuit.Text) & "'", sqlConAppli)
                OleSchemaDataset = New DataSet
                OleAdaptaterschema.Fill(OleSchemaDataset)
                OledatableSchema = OleSchemaDataset.Tables(0)
                If OledatableSchema.Rows.Count > 0 Then
                    LibelleCircuit.Text = OledatableSchema.Rows(0).Item("Intitule")
                    Intitule.Text = "Circuit :" & Trim(LibelleCircuit.Text) & " ,montant " & Trim(montant.Text)
                    affichEtapeCourante(Trim(ComboCircuit.Text))
                End If
            End If
        End If
    End Sub

    Private Sub montant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles montant.TextChanged
        If NatureValidation.ModficationRegle = True Then

        ElseIf NatureValidation.CreationRegle = True Then
            If Intitule.Text.Contains("Circuit") = True Then
                Intitule.Text = "Circuit :" & Trim(LibelleCircuit.Text) & " ,montant " & Trim(montant.Text)
            Else
                Intitule.Text = " ,montant " & Trim(montant.Text)
            End If
        End If
    End Sub
    Private Sub affichEtapeCourante(ByVal CodeCircuit As String)
        Dim Dernier, i As Integer
        If Trim(CodeCircuit) <> "" Then
            OleAdaptaterschema = New OleDbDataAdapter("select * from EtapePossible where CodeCircuitVa='" & Trim(CodeCircuit) & "' ORDER BY ordre", sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)
            DataListEtapeCourante.Rows.Clear()
            DataListEtapeCourante.RowCount = OledatableSchema.Rows.Count - 1
            Dernier = OledatableSchema.Rows.Count - 1
            If OledatableSchema.Rows.Count > 0 Then
                For i = 0 To OledatableSchema.Rows.Count - 1
                    If i <> Dernier Then
                        DataListEtapeCourante.Rows(i).Cells("EtapeCourante").Value = OledatableSchema.Rows(i).Item("CodeEtapeCourant")
                        OleAdaptaterschema1 = New OleDbDataAdapter("select * from Etape where CodeEtape='" & Trim(OledatableSchema.Rows(i).Item("CodeEtapeSuivant")) & "'", sqlConAppli)
                        OleSchemaDataset1 = New DataSet
                        OleAdaptaterschema1.Fill(OleSchemaDataset1)
                        OledatableSchema1 = OleSchemaDataset1.Tables(0)
                        If OledatableSchema1.Rows.Count > 0 Then
                            DataListEtapeCourante.Rows(i).Cells("CodeEtapeSuivante").Value = Trim(OledatableSchema.Rows(i).Item("CodeEtapeSuivant"))
                            DataListEtapeCourante.Rows(i).Cells("IntituleEtapeSuivant").Value = Trim(OledatableSchema1.Rows(0).Item("Intitule"))
                            DataListEtapeCourante.Rows(i).Cells("NautoEtapePo").Value = Trim(OledatableSchema.Rows(i).Item("NautoEpo"))
                        End If
                    End If
                Next i
                DataListEtapeCourante.Rows(0).Selected = True
                IndexEtapeC = 0
            End If
        End If
    End Sub

    Private Sub BT_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ADD.Click
        If DataListEtapeCourante.Rows.Count > 0 Then
            CodeEtapeSuivant = DataListEtapeCourante.Rows(DataListEtapeCourante.CurrentRow.Index).Cells("CodeEtapeSuivante").Value
            LibelleEtapeSuivant = DataListEtapeCourante.Rows(DataListEtapeCourante.CurrentRow.Index).Cells("IntituleEtapeSuivant").Value
            CircuitVa = Trim(ComboCircuit.Text)
            ValideurPossible.ShowDialog()
        End If
    End Sub
    Public Sub DataListEtapeCourante_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListEtapeCourante.CellClick
        IndexEtapeC = DataListEtapeCourante.CurrentRow.Index
        BT_DelRow.Enabled = False
        afficheValideur()
    End Sub

    Private Sub BT_DelRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_DelRow.Click
        If DataListeSchema.SelectedCells.Count > 0 Then
            Insertion = "Delete Signataire  WHERE (CodeCircuitVa='" & Trim(ComboCircuit.Text) & "' And Signataire='" & DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Login").Value & "') AND CodeEtape='" & DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("CodeEtape").Value & "'"
            OleCommandEnreg = New OleDbCommand(Insertion)
            OleCommandEnreg.Connection = sqlConAppli
            OleCommandEnreg.ExecuteNonQuery()
            afficheValideur()
        End If
    End Sub
    Public Sub afficheValideur()
        Dim i As Integer
        BT_DelRow.Enabled = False
        DataListeSchema.Rows.Clear()
        OleAdaptaterschema = New OleDbDataAdapter("select * from Signataire where CodeCircuitVa='" & Trim(ComboCircuit.Text) & "' AND CodeEtape='" & DataListEtapeCourante.Rows(IndexEtapeC).Cells("CodeEtapeSuivante").Value & "'", sqlConAppli)
        OleSchemaDataset = New DataSet
        OleAdaptaterschema.Fill(OleSchemaDataset)
        OledatableSchema = OleSchemaDataset.Tables(0)
        DataListeSchema.RowCount = OledatableSchema.Rows.Count
        If OledatableSchema.Rows.Count > 0 Then
            BT_DelRow.Enabled = True
            For i = 0 To OledatableSchema.Rows.Count - 1
                DataListeSchema.Rows(i).Cells("EtapeValide").Value = Trim(OledatableSchema.Rows(i).Item("LibelleEtape"))
                DataListeSchema.Rows(i).Cells("Signataire").Value = Trim(OledatableSchema.Rows(i).Item("NomPrenom"))
                DataListeSchema.Rows(i).Cells("CodeEtape").Value = Trim(OledatableSchema.Rows(i).Item("CodeEtape"))
                DataListeSchema.Rows(i).Cells("Login").Value = Trim(OledatableSchema.Rows(i).Item("Signataire"))
                DataListeSchema.Rows(i).Cells("NautoEpo").Value = Trim(DataListEtapeCourante.Rows(IndexEtapeC).Cells("NautoEtapePo").Value)
            Next i
        End If
    End Sub
    Private Sub Enreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enreg.Click
        If NatureValidation.ModficationRegle = True Then
            Dim i, j As Integer
            Dim listNautoEpo As List(Of Integer)
            listNautoEpo = New List(Of Integer)
            OleAdaptaterschema1 = New OleDbDataAdapter("select * from RegleValidationDetail where (MontantRegle=" & Trim(montant.Text) & " AND DeviseMontant='" & Trim(Devise.Text) & "') AND (NautoRegleVa <>" & NatureValidation.NautoReglVa & "AND CodeNatureVa='" & Trim(NatureValidation.ComboNatureVa.Text) & "')", sqlConAppli)
            OleSchemaDataset1 = New DataSet
            OleAdaptaterschema1.Fill(OleSchemaDataset1)
            OledatableSchema1 = OleSchemaDataset1.Tables(0)
            If OledatableSchema1.Rows.Count > 0 Then
                MsgBox("Une Règle avec ce montant existe deja", MsgBoxStyle.Information, "Règle de validation")
            Else
                If Trim(Intitule.Text) <> "" Then
                    If Trim(ComboCircuit.Text) <> "" Then
                        If IsNumeric(montant.Text) = True Then
                            If Trim(Devise.Text) <> "" Then
                                NumAutoRegleVa = NatureValidation.NautoReglVa
                                Insertion = "Update RegleValidation SET Intitule='" & Trim(Intitule.Text) & "' WHERE NautoRegleVa=" & NumAutoRegleVa
                                OleCommandEnreg = New OleDbCommand(Insertion)
                                OleCommandEnreg.Connection = sqlConAppli
                                OleCommandEnreg.ExecuteNonQuery()
                                Insertion = "Update RegleValidationDetail SET CodeCircuitVa='" & Trim(ComboCircuit.Text) & "',Intitule='" & Trim(Intitule.Text) & "',MontantRegle=" & Trim(montant.Text) & ",DeviseMontant='" & Trim(Devise.Text) & "' WHERE NautoRegleVa=" & NumAutoRegleVa
                                OleCommandEnreg = New OleDbCommand(Insertion)
                                OleCommandEnreg.Connection = sqlConAppli
                                OleCommandEnreg.ExecuteNonQuery()
                                OleAdaptaterschema = New OleDbDataAdapter("select * From Signataire  where CodeCircuitVa='" & Trim(ComboCircuit.Text) & "'", sqlConAppli)
                                OleSchemaDataset = New DataSet
                                OleAdaptaterschema.Fill(OleSchemaDataset)
                                OledatableSchema = OleSchemaDataset.Tables(0)
                                If OledatableSchema.Rows.Count > 0 Then
                                    For i = 0 To OledatableSchema.Rows.Count - 1
                                        Dim NautoEpo As Integer
                                        OleAdaptaterschema2 = New OleDbDataAdapter("select * From ValidationEtape  where NautoRegleVA=" & NumAutoRegleVa & " AND NautoEpo=" & OledatableSchema.Rows(i).Item("NautoEpo"), sqlConAppli)
                                        OleSchemaDataset2 = New DataSet
                                        OleAdaptaterschema2.Fill(OleSchemaDataset2)
                                        OledatableSchema2 = OleSchemaDataset2.Tables(0)
                                        If OledatableSchema2.Rows.Count > 0 Then
                                            NautoEpo = OledatableSchema2.Rows(0).Item("NautoVe")
                                            If listNautoEpo.Count > 0 Then
                                                Dim Estla As Boolean = False
                                                For j = 0 To listNautoEpo.Count - 1
                                                    If listNautoEpo.Item(j) = NautoEpo Then
                                                        Estla = True
                                                        Exit For
                                                    End If
                                                Next j
                                                If Estla = False Then
                                                    Insertion = "Delete ValideurPossible WHERE NautoVe=" & NautoEpo & " AND CodeEtapeSuivant='" & OledatableSchema.Rows(i).Item("CodeEtape") & "'"
                                                    OleCommandEnreg = New OleDbCommand(Insertion)
                                                    OleCommandEnreg.Connection = sqlConAppli
                                                    OleCommandEnreg.ExecuteNonQuery()
                                                    listNautoEpo.Add(NautoEpo)
                                                ElseIf Estla = True Then

                                                End If
                                            Else
                                                Insertion = "Delete ValideurPossible WHERE NautoVe=" & NautoEpo & " AND CodeEtapeSuivant='" & OledatableSchema.Rows(i).Item("CodeEtape") & "'"
                                                OleCommandEnreg = New OleDbCommand(Insertion)
                                                OleCommandEnreg.Connection = sqlConAppli
                                                OleCommandEnreg.ExecuteNonQuery()
                                                listNautoEpo.Add(NautoEpo)
                                            End If
                                        Else
                                            Insertion = "Insert into ValidationEtape (NautoRegleVA,NautoEpo) VALUES(" & NumAutoRegleVa & "," & OledatableSchema.Rows(i).Item("NautoEpo") & ")"
                                            OleCommandEnreg = New OleDbCommand(Insertion)
                                            OleCommandEnreg.Connection = sqlConAppli
                                            OleCommandEnreg.ExecuteNonQuery()
                                            OleAdaptaterschema3 = New OleDbDataAdapter("select max(NautoVe)as ValidEtape From ValidationEtape", sqlConAppli)
                                            OleSchemaDataset3 = New DataSet
                                            OleAdaptaterschema3.Fill(OleSchemaDataset3)
                                            OledatableSchema3 = OleSchemaDataset3.Tables(0)
                                            NautoEpo = OledatableSchema1.Rows(0).Item("ValidEtape")
                                        End If
                                        Insertion = "Insert into ValideurPossible (NautoVe,CodeUtilisateur,CodeEtapeSuivant) VALUES(" & NautoEpo & ",'" & OledatableSchema.Rows(i).Item("Signataire") & "','" & OledatableSchema.Rows(i).Item("CodeEtape") & "')"
                                        OleCommandEnreg = New OleDbCommand(Insertion)
                                        OleCommandEnreg.Connection = sqlConAppli
                                        OleCommandEnreg.ExecuteNonQuery()
                                    Next i
                                End If
                                For i = 0 To NatureValidation.DataListeIntegrer.Rows.Count - 1
                                    If NatureValidation.DataListeIntegrer.Rows(i).Cells("NoAuto").Value = NumAutoRegleVa Then
                                        NatureValidation.DataListeIntegrer.Rows(i).Cells("Apartirde").Value = Trim(montant.Text)
                                        NatureValidation.DataListeIntegrer.Rows(i).Cells("RegleValidation").Value = Trim(Intitule.Text)
                                        Exit For
                                    End If
                                Next i
                                NatureValidation.ModficationRegle = False
                                Me.Close()
                            Else
                                MsgBox("Veuillez La Devise", MsgBoxStyle.Information, "Règle de validation")
                                Devise.Focus()
                            End If
                        Else
                            MsgBox("Le Montant Renseigné n'est pas numeric", MsgBoxStyle.Information, "Règle de validation")
                            montant.Focus()
                        End If
                    Else
                        MsgBox("Veuillez Renseigner un circuit de validation", MsgBoxStyle.Information, "Règle de validation")
                        ComboCircuit.Focus()
                    End If
                Else
                    MsgBox("Veuillez Renseigner le Libelle de la Règle de validation", MsgBoxStyle.Information, "Règle de validation")
                    Intitule.Focus()
                End If
            End If
        ElseIf NatureValidation.CreationRegle = True Then
            Dim i, last As Integer
            OleAdaptaterschema1 = New OleDbDataAdapter("select * from RegleValidationDetail where (MontantRegle=" & Trim(montant.Text) & " AND DeviseMontant='" & Trim(Devise.Text) & "') AND CodeNatureVa='" & Trim(NatureValidation.ComboNatureVa.Text) & "'", sqlConAppli)
            OleSchemaDataset1 = New DataSet
            OleAdaptaterschema1.Fill(OleSchemaDataset1)
            OledatableSchema1 = OleSchemaDataset1.Tables(0)
            If OledatableSchema1.Rows.Count > 0 Then
                MsgBox("Une Règle avec ce montant existe deja", MsgBoxStyle.Information, "Règle de validation")
            Else
                If Trim(Intitule.Text) <> "" Then
                    If Trim(ComboCircuit.Text) <> "" Then
                        If IsNumeric(montant.Text) = True Then
                            If Trim(Devise.Text) <> "" Then
                                Insertion = "Insert into RegleValidation (Intitule) VALUES('" & Trim(Intitule.Text) & "')"
                                OleCommandEnreg = New OleDbCommand(Insertion)
                                OleCommandEnreg.Connection = sqlConAppli
                                OleCommandEnreg.ExecuteNonQuery()
                                OleAdaptaterschema = New OleDbDataAdapter("select max(NautoRegleVa)as Regle From RegleValidation", sqlConAppli)
                                OleSchemaDataset = New DataSet
                                OleAdaptaterschema.Fill(OleSchemaDataset)
                                OledatableSchema = OleSchemaDataset.Tables(0)
                                NumAutoRegleVa = OledatableSchema.Rows(0).Item("Regle")
                                Insertion = "Insert into RegleValidationDetail (CodeCircuitVa,NautoRegleVa,Intitule,MontantRegle,DeviseMontant,CodeNatureVa) VALUES('" & Trim(ComboCircuit.Text) & "'," & OledatableSchema.Rows(0).Item("Regle") & ",'" & Trim(Intitule.Text) & "'," & Trim(montant.Text) & ",'" & Trim(Devise.Text) & "','" & Trim(NatureValidation.ComboNatureVa.Text) & "')"
                                OleCommandEnreg = New OleDbCommand(Insertion)
                                OleCommandEnreg.Connection = sqlConAppli
                                OleCommandEnreg.ExecuteNonQuery()
                                Insertion = "Delete NatureValidationDetail WHERE NautoRegleVa=" & NumAutoRegleVa
                                OleCommandEnreg = New OleDbCommand(Insertion)
                                OleCommandEnreg.Connection = sqlConAppli
                                OleCommandEnreg.ExecuteNonQuery()
                                Insertion = "INSERT INTO NatureValidationDetail (CodeNatureVa,NautoRegleVa) VALUES('" & Trim(NatureValidation.ComboNatureVa.Text) & "'," & NumAutoRegleVa & ")"
                                OleCommandEnreg = New OleDbCommand(Insertion)
                                OleCommandEnreg.Connection = sqlConAppli
                                OleCommandEnreg.ExecuteNonQuery()
                                OleAdaptaterschema = New OleDbDataAdapter("select * From Signataire  where CodeCircuitVa='" & Trim(ComboCircuit.Text) & "'", sqlConAppli)
                                OleSchemaDataset = New DataSet
                                OleAdaptaterschema.Fill(OleSchemaDataset)
                                OledatableSchema = OleSchemaDataset.Tables(0)
                                If OledatableSchema.Rows.Count > 0 Then
                                    For i = 0 To OledatableSchema.Rows.Count - 1
                                        Dim NautoEpo As Integer
                                        OleAdaptaterschema2 = New OleDbDataAdapter("select * From ValidationEtape  where NautoRegleVA=" & NumAutoRegleVa & " AND NautoEpo=" & OledatableSchema.Rows(i).Item("NautoEpo"), sqlConAppli)
                                        OleSchemaDataset2 = New DataSet
                                        OleAdaptaterschema2.Fill(OleSchemaDataset2)
                                        OledatableSchema2 = OleSchemaDataset2.Tables(0)
                                        If OledatableSchema2.Rows.Count > 0 Then
                                            NautoEpo = OledatableSchema2.Rows(0).Item("NautoVe")
                                        Else
                                            Insertion = "Insert into ValidationEtape (NautoRegleVA,NautoEpo) VALUES(" & NumAutoRegleVa & "," & OledatableSchema.Rows(i).Item("NautoEpo") & ")"
                                            OleCommandEnreg = New OleDbCommand(Insertion)
                                            OleCommandEnreg.Connection = sqlConAppli
                                            OleCommandEnreg.ExecuteNonQuery()
                                            OleAdaptaterschema3 = New OleDbDataAdapter("select max(NautoVe)as ValidEtape From ValidationEtape", sqlConAppli)
                                            OleSchemaDataset3 = New DataSet
                                            OleAdaptaterschema3.Fill(OleSchemaDataset3)
                                            OledatableSchema3 = OleSchemaDataset3.Tables(0)
                                            NautoEpo = OledatableSchema3.Rows(0).Item("ValidEtape")
                                        End If
                                        Insertion = "Insert into ValideurPossible (NautoVe,CodeUtilisateur,CodeEtapeSuivant) VALUES(" & NautoEpo & ",'" & OledatableSchema.Rows(i).Item("Signataire") & "','" & OledatableSchema.Rows(i).Item("CodeEtape") & "')"
                                        OleCommandEnreg = New OleDbCommand(Insertion)
                                        OleCommandEnreg.Connection = sqlConAppli
                                        OleCommandEnreg.ExecuteNonQuery()
                                    Next i
                                End If
                                NatureValidation.DataListeIntegrer.Rows.Add()
                                last = NatureValidation.DataListeIntegrer.Rows.GetLastRow(DataGridViewElementStates.Displayed)
                                NatureValidation.DataListeIntegrer.Rows(last).Cells("Apartirde").Value = Trim(montant.Text)
                                NatureValidation.DataListeIntegrer.Rows(last).Cells("RegleValidation").Value = Trim(Intitule.Text)
                                NatureValidation.DataListeIntegrer.Rows(last).Cells("NoAuto").Value = NumAutoRegleVa
                                NatureValidation.CreationRegle = False
                                Me.Close()
                            Else
                                MsgBox("Veuillez La Devise", MsgBoxStyle.Information, "Règle de validation")
                                Devise.Focus()
                            End If
                        Else
                            MsgBox("Le Montant Renseigné n'est pas numeric", MsgBoxStyle.Information, "Règle de validation")
                            montant.Focus()
                        End If
                    Else
                        MsgBox("Veuillez Renseigner un circuit de validation", MsgBoxStyle.Information, "Règle de validation")
                        ComboCircuit.Focus()
                    End If
                Else
                    MsgBox("Veuillez Renseigner le Libelle de la Règle de validation", MsgBoxStyle.Information, "Règle de validation")
                    Intitule.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub Enreg_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Enreg.MouseHover
        Dim InfoBulle = New System.Windows.Forms.ToolTip
        InfoBulle.IsBalloon = True
        'InfoBulle.ToolTipTitle = "Validation"
        InfoBulle.ToolTipTitle = ""
        InfoBulle.SetToolTip(sender, "Valider et fermer")
    End Sub


    Private Sub DataListEtapeCourante_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListEtapeCourante.CellContentClick

    End Sub
End Class