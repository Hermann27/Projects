Imports System.Data.OleDb
Imports System.IO
Public Class NatureValidation
    Dim OleAdaptaterschema, OleAdaptaterschema1, OleAdaptaterschema2, OleAdaptaterschema3, OleAdaptaterschema4, OleAdaptaterschema5 As OleDbDataAdapter
    Dim OleSchemaDataset, OleSchemaDataset1, OleSchemaDataset2, OleSchemaDataset3, OleSchemaDataset4, OleSchemaDataset5 As DataSet
    Dim OledatableSchema, OledatableSchema1, OledatableSchema2, OledatableSchema3, OledatableSchema4, OledatableSchema5 As DataTable
    Dim OleCommandEnreg As OleDbCommand
    Dim Insertion As String
    Dim GesComNa As Integer
    Public CreationRegle As Boolean = False
    Public ModficationRegle As Boolean = False
    Public Devise, Circuit As String
    Public NautoReglVa As Integer
    Private Sub BT_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ADD.Click
        If Trim(ComboNatureVa.Text) <> "" Then
            CreationRegle = True
            ModficationRegle = False
            FrmRegleValidation.DataListEtapeCourante.Rows.Clear()
            FrmRegleValidation.DataListeSchema.Rows.Clear()
            FrmRegleValidation.ComboCircuit.Enabled = True
            FrmRegleValidation.LibelleCircuit.Text = ""
            FrmRegleValidation.ComboCircuit.BackColor = Color.LightYellow
            FrmRegleValidation.montant.Text = 0
            FrmRegleValidation.ShowDialog()
        Else
            MessageBox.Show("Veuillez choisir une Nature de validation", "Creation Regle de Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Enreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Trim(CodeNa.Text) <> "" Then
        '    DataListeIntegrer.Rows.Clear()
        '    OleAdaptaterschema = New OleDbDataAdapter("select * from NatureValidation where CodeNatureVa='" & Trim(CodeNa.Text) & "'", sqlConAppli)
        '    OleSchemaDataset = New DataSet
        '    OleAdaptaterschema.Fill(OleSchemaDataset)
        '    OledatableSchema = OleSchemaDataset.Tables(0)
        '    If OledatableSchema.Rows.Count > 0 Then
        '        MsgBox("Il existe déja une nature de validation de meme code", MsgBoxStyle.Information, "Nature de validation")
        '        CodeNa.Focus()
        '    Else
        '        GesComNa = 0
        '        Insertion = "Insert Into NatureValidation (CodeNatureVa,Intitule) VALUES ('" & Trim(CodeNa.Text) & "','" & Trim(LibelleNa.Text) & "')"
        '        OleCommandEnreg = New OleDbCommand(Insertion)
        '        OleCommandEnreg.Connection = sqlConAppli
        '        OleCommandEnreg.ExecuteNonQuery()
        '        'alimComboNature()
        '        CodeNa.Text = ""
        '        LibelleNa.Text = ""
        '        GesComNa = GesComNa + 1
        '    End If
        'End If
    End Sub
    Private Sub alimComboNature()
        OleAdaptaterschema = New OleDbDataAdapter("select * from NatureValidation", sqlConAppli)
        OleSchemaDataset = New DataSet
        'OleAdaptaterschema.Fill(OleSchemaDataset)
        OledatableSchema = OleSchemaDataset.Tables(0)
        If OledatableSchema.Rows.Count > 0 Then
            ComboNatureVa.DataSource = OledatableSchema
            ComboNatureVa.DisplayMember = "CodeNatureVa"
        End If
    End Sub
    Private Sub NatureValidation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        alimComboNature()
        DataListeIntegrer.Rows.Clear()
        GesComNa = GesComNa + 1
    End Sub

    Private Sub ComboNatureVa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboNatureVa.SelectedIndexChanged
        If Trim(ComboNatureVa.Text) <> "" And GesComNa >= 1 Then
            OleAdaptaterschema = New OleDbDataAdapter("select * from NatureValidation where CodeNatureVa='" & Trim(ComboNatureVa.Text) & "'", sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)
            If OledatableSchema.Rows.Count > 0 Then
                'Button2.Enabled = True
                LibelleCombo.Text = OledatableSchema.Rows(0).Item("Intitule")
                DataListeIntegrer.Rows.Clear()
                afficheRegleValidation(Trim(ComboNatureVa.Text))
            End If
        End If
    End Sub
    Private Sub BT_DelRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_DelRow.Click
        If DataListeIntegrer.Rows.Count > 0 Then
            Dim OleCommandEnreg As OleDbCommand
            Dim Insertion As String
            Dim i As Integer
            If DataListeIntegrer.RowCount > 0 Then
                Insertion = "DELETE RegleValidation WHERE NautoRegleVa=" & DataListeIntegrer.Rows(DataListeIntegrer.CurrentRow.Index).Cells("NoAuto").Value
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                Insertion = "DELETE RegleValidationDetail WHERE NautoRegleVa=" & DataListeIntegrer.Rows(DataListeIntegrer.CurrentRow.Index).Cells("NoAuto").Value
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                OleAdaptaterschema = New OleDbDataAdapter("select * from ValidationEtape where NautoRegleVA=" & DataListeIntegrer.Rows(DataListeIntegrer.CurrentRow.Index).Cells("NoAuto").Value, sqlConAppli)
                OleSchemaDataset = New DataSet
                OleAdaptaterschema.Fill(OleSchemaDataset)
                OledatableSchema = OleSchemaDataset.Tables(0)
                If OledatableSchema.Rows.Count > 0 Then
                    For i = 0 To OledatableSchema.Rows.Count - 1
                        Insertion = "DELETE ValideurPossible WHERE NautoVe=" & OledatableSchema.Rows(i).Item("NautoVe")
                        OleCommandEnreg = New OleDbCommand(Insertion)
                        OleCommandEnreg.Connection = sqlConAppli
                        OleCommandEnreg.ExecuteNonQuery()
                        Insertion = "DELETE ValidationEtape WHERE NautoVe=" & OledatableSchema.Rows(i).Item("NautoVe")
                        OleCommandEnreg = New OleDbCommand(Insertion)
                        OleCommandEnreg.Connection = sqlConAppli
                        OleCommandEnreg.ExecuteNonQuery()
                    Next i
                End If
                Insertion = "DELETE NatureValidationDetail WHERE NautoRegleVa=" & DataListeIntegrer.Rows(DataListeIntegrer.CurrentRow.Index).Cells("NoAuto").Value
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                afficheRegleValidation(Trim(ComboNatureVa.Text))
                Me.Refresh()
            End If
        End If
    End Sub
    Private Sub afficheRegleValidation(ByVal NatureValidation As String)
        Dim I, j As Integer
        If Trim(NatureValidation) <> "" Then
            DataListeIntegrer.Rows.Clear()
            OleAdaptaterschema = New OleDbDataAdapter("select * from NatureValidationDetail where CodeNatureVa='" & Trim(NatureValidation) & "'", sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)
            If OledatableSchema.Rows.Count > 0 Then
                For I = 0 To OledatableSchema.Rows.Count - 1
                    OleAdaptaterschema1 = New OleDbDataAdapter("select * from RegleValidationDetail where NautoRegleVa=" & OledatableSchema.Rows(I).Item("NautoRegleVa"), sqlConAppli)
                    OleSchemaDataset1 = New DataSet
                    OleAdaptaterschema1.Fill(OleSchemaDataset1)
                    OledatableSchema1 = OleSchemaDataset1.Tables(0)
                    DataListeIntegrer.RowCount = OledatableSchema1.Rows.Count
                    If OledatableSchema1.Rows.Count > 0 Then
                        For j = 0 To OledatableSchema1.Rows.Count - 1
                            'DataListeIntegrer.Rows.Add()
                            'last = DataListeIntegrer.Rows.GetLastRow(DataGridViewElementStates.Displayed)
                            DataListeIntegrer.Rows(j).Cells("NoAuto").Value = CStr(OledatableSchema1.Rows(j).Item("NautoRegleVa"))
                            DataListeIntegrer.Rows(j).Cells("Apartirde").Value = CStr(OledatableSchema1.Rows(j).Item("MontantRegle"))
                            DataListeIntegrer.Rows(j).Cells("RegleValidation").Value = CStr(OledatableSchema1.Rows(j).Item("Intitule"))
                        Next j
                    End If
                Next I
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(ComboNatureVa.Text) <> "" Then
            Dim montant, libelle, IntituleCir As String
            Dim i, j As Integer
            ModficationRegle = True
            CreationRegle = False
            NautoReglVa = CInt(Trim(DataListeIntegrer.Rows(DataListeIntegrer.CurrentRow.Index).Cells("NoAuto").Value))
            OleAdaptaterschema = New OleDbDataAdapter("select * from RegleValidationDetail where NautoRegleVa=" & DataListeIntegrer.Rows(DataListeIntegrer.CurrentRow.Index).Cells("NoAuto").Value, sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)
            If OledatableSchema.Rows.Count > 0 Then
                montant = CStr(OledatableSchema.Rows(0).Item("MontantRegle"))
                libelle = CStr(OledatableSchema.Rows(0).Item("Intitule"))
                Devise = CStr(OledatableSchema.Rows(0).Item("DeviseMontant"))
                Circuit = CStr(OledatableSchema.Rows(0).Item("CodeCircuitVa"))
                OleAdaptaterschema1 = New OleDbDataAdapter("select * from CIRCUITVALIDATION where CodeCircuitVa='" & CStr(OledatableSchema.Rows(0).Item("CodeCircuitVa")) & "'", sqlConAppli)
                OleSchemaDataset1 = New DataSet
                OleAdaptaterschema1.Fill(OleSchemaDataset1)
                OledatableSchema1 = OleSchemaDataset1.Tables(0)
                If OledatableSchema1.Rows.Count > 0 Then
                    IntituleCir = CStr(OledatableSchema1.Rows(0).Item("Intitule"))
                    FrmRegleValidation.montant.Text = montant
                    FrmRegleValidation.LibelleCircuit.Text = IntituleCir
                    FrmRegleValidation.Intitule.Text = libelle
                    OleAdaptaterschema2 = New OleDbDataAdapter("select * from ValidationEtape where NautoRegleVA=" & DataListeIntegrer.Rows(DataListeIntegrer.CurrentRow.Index).Cells("NoAuto").Value, sqlConAppli)
                    OleSchemaDataset2 = New DataSet
                    OleAdaptaterschema2.Fill(OleSchemaDataset2)
                    OledatableSchema2 = OleSchemaDataset2.Tables(0)
                    If OledatableSchema2.Rows.Count > 0 Then
                        Insertion = "DELETE Signataire"
                        OleCommandEnreg = New OleDbCommand(Insertion)
                        OleCommandEnreg.Connection = sqlConAppli
                        OleCommandEnreg.ExecuteNonQuery()
                        For i = 0 To OledatableSchema2.Rows.Count - 1
                            OleAdaptaterschema3 = New OleDbDataAdapter("select * from ValideurPossible where NautoVe=" & OledatableSchema2.Rows(i).Item("NautoVe"), sqlConAppli)
                            OleSchemaDataset3 = New DataSet
                            OleAdaptaterschema3.Fill(OleSchemaDataset3)
                            OledatableSchema3 = OleSchemaDataset3.Tables(0)
                            If OledatableSchema3.Rows.Count > 0 Then
                                Dim NomPrenom As String
                                For j = 0 To OledatableSchema3.Rows.Count - 1
                                    OleAdaptaterschema4 = New OleDbDataAdapter("select * from Etape where CodeEtape='" & OledatableSchema3.Rows(j).Item("CodeEtapeSuivant") & "'", sqlConAppli)
                                    OleSchemaDataset4 = New DataSet
                                    OleAdaptaterschema4.Fill(OleSchemaDataset4)
                                    OledatableSchema4 = OleSchemaDataset4.Tables(0)
                                    OleAdaptaterschema5 = New OleDbDataAdapter("select * from Utilisateurs where CodeUtilisateur='" & OledatableSchema3.Rows(j).Item("CodeUtilisateur") & "'", sqlConAppli)
                                    OleSchemaDataset5 = New DataSet
                                    OleAdaptaterschema5.Fill(OleSchemaDataset5)
                                    OledatableSchema5 = OleSchemaDataset5.Tables(0)
                                    If OledatableSchema4.Rows.Count > 0 And OledatableSchema5.Rows.Count > 0 Then
                                        NomPrenom = OledatableSchema5.Rows(0).Item("Nom") & " " & OledatableSchema5.Rows(0).Item("Prenom")
                                        Insertion = "Insert into Signataire (CodeCircuitVa,LibelleEtape,Signataire,NomPrenom,CodeEtape,NautoEpo) values('" & Circuit & "','" & OledatableSchema4.Rows(0).Item("Intitule") & "','" & OledatableSchema3.Rows(j).Item("CodeUtilisateur") & "','" & NomPrenom & "','" & OledatableSchema3.Rows(j).Item("CodeEtapeSuivant") & "'," & OledatableSchema2.Rows(i).Item("NautoEpo") & ")"
                                        OleCommandEnreg = New OleDbCommand(Insertion)
                                        OleCommandEnreg.Connection = sqlConAppli
                                        OleCommandEnreg.ExecuteNonQuery()
                                    End If
                                Next j
                            End If
                        Next i
                    End If
                End If

            End If
            FrmRegleValidation.ShowDialog()
        Else
            MessageBox.Show("Veuillez Choisir une Nature de validation", "Modification Regle de Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim OleCommandEnreg As OleDbCommand
            Dim Insertion As String
            Dim i, j As Integer
            If Trim(ComboNatureVa.Text) <> "" Then
                Insertion = "DELETE NatureValidation WHERE CodeNatureVa='" & Trim(ComboNatureVa.Text) & "'"
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                OleAdaptaterschema = New OleDbDataAdapter("select * from NatureValidationDetail where CodeNatureVa='" & Trim(ComboNatureVa.Text) & "'", sqlConAppli)
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
                    Insertion = "DELETE NatureValidationDetail where CodeNatureVa='" & Trim(ComboNatureVa.Text) & "'"
                    OleCommandEnreg = New OleDbCommand(Insertion)
                    OleCommandEnreg.Connection = sqlConAppli
                    OleCommandEnreg.ExecuteNonQuery()
                    GesComNa = 1
                    DataListeIntegrer.Rows.Clear()
                    'alimComboNature()
                    GesComNa = GesComNa + 1
                    'Button2.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "CAISSE WAZA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DataListeIntegrer_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListeIntegrer.CellClick
        If e.RowIndex >= 0 Then
            DataListeIntegrer.Rows(e.RowIndex).Selected = True
        End If
    End Sub
End Class