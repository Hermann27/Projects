Imports System.Data.OleDb
Imports System.IO
Public Class CategorieDemandeur
    Dim Insert As Boolean
    Dim OleAdaptaterschema As OleDbDataAdapter
    Dim OleSchemaDataset As DataSet
    Dim OledatableSchema As DataTable
    Dim OleCommandEnreg As OleDbCommand
    Dim Insertion As String
    Dim EtapeCode As String
    Dim EtapeLibelle As String
    Dim aModifier, nouvellesaisie As Boolean

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If aModifier = False Then
                OleAdaptaterschema = New OleDbDataAdapter("select * from NatureValidation where CodeNatureVa='" & Trim(TxtCodeIni.Text) & "'", sqlConAppli)
                OleSchemaDataset = New DataSet
                OleAdaptaterschema.Fill(OleSchemaDataset)
                OledatableSchema = OleSchemaDataset.Tables(0)
                If OledatableSchema.Rows.Count > 0 Then
                    MsgBox("Il existe déja une catégorie de même code", MsgBoxStyle.Information, "Catégorie de demendeurs")
                Else
                    Insertion = "Insert Into NatureValidation (CodeNatureVa,Intitule) VALUES ('" & Trim(TxtCodeIni.Text) & "','" & Trim(TxtLibelleIni.Text) & "')"
                    OleCommandEnreg = New OleDbCommand(Insertion)
                    OleCommandEnreg.Connection = sqlConAppli
                    OleCommandEnreg.ExecuteNonQuery()
                    MsgBox("Insertion Réussi", MsgBoxStyle.Information, "Catégorie de demendeurs")
                    'ListesEtapes.NewSaisie = False
                End If
            ElseIf aModifier = True Then
                Insertion = "Update NatureValidation SET Intitule='" & Trim(TxtLibelleIni.Text) & "' WHERE CodeNatureVa='" & Trim(TxtCodeIni.Text) & "'"
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                MsgBox("Mise à jour réussi", MsgBoxStyle.Information, "Catégorie de demendeurs")
                aModifier = False
                'ListesEtapes.OpenRejet = False
            End If
            Insert = True
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = False
            TxtCodeIni.Enabled = False
            Me.Refresh()
            ListesCatDemandeurs.afficheCatDemandeurs()
            ListesCatDemandeurs.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'ListesEtapes.NewSaisie = True
        TxtCodeIni.Text = ""
        TxtLibelleIni.Text = ""
        TxtCodeIni.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = True
        aModifier = False
        ListesCatDemandeurs.NewSaisie = True
        Me.Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim OleAdaptaterschema, OleAdaptaterschema1, OleAdaptaterschema2 As OleDbDataAdapter
            Dim OleSchemaDataset, OleSchemaDataset1, OleSchemaDataset2 As DataSet
            Dim OledatableSchema, OledatableSchema1, OledatableSchema2 As DataTable
            Dim OleCommandEnreg As OleDbCommand
            Dim Insertion As String
            Dim i, j As Integer
            OleAdaptaterschema2 = New OleDbDataAdapter("select * from NatureValidation WHERE CodeNatureVa='" & Trim(TxtCodeIni.Text) & "'", sqlConAppli)
            OleSchemaDataset2 = New DataSet
            OleAdaptaterschema2.Fill(OleSchemaDataset2)
            OledatableSchema2 = OleSchemaDataset2.Tables(0)
            If OledatableSchema2.Rows.Count > 0 Then
                Insertion = "DELETE NatureValidation WHERE CodeNatureVa='" & Trim(TxtCodeIni.Text) & "'"
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                OleAdaptaterschema = New OleDbDataAdapter("select * from NatureValidationDetail where CodeNatureVa='" & Trim(TxtCodeIni.Text) & "'", sqlConAppli)
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
                    Insertion = "DELETE NatureValidationDetail where CodeNatureVa='" & Trim(TxtCodeIni.Text) & "'"
                    OleCommandEnreg = New OleDbCommand(Insertion)
                    OleCommandEnreg.Connection = sqlConAppli
                    OleCommandEnreg.ExecuteNonQuery()
                End If
                'ListesEtapes.NewSaisie = True
                'ListesEtapes.OpenRejet = False
                TxtCodeIni.Text = ""
                TxtLibelleIni.Text = ""
                TxtCodeIni.Enabled = True
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                Me.Refresh()
                ListesCatDemandeurs.afficheCatDemandeurs()
                ListesCatDemandeurs.Refresh()
            Else
                'ListesEtapes.NewSaisie = True
                TxtCodeIni.Text = ""
                TxtLibelleIni.Text = ""
                TxtCodeIni.Enabled = True
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DEMANDE D'ACHAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtLibelleIni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLibelleIni.TextChanged
        If ListesCatDemandeurs.NewSaisie = True Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            aModifier = False
        ElseIf ListesCatDemandeurs.OpenRejet = True Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = False
        Else
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            aModifier = True
        End If
    End Sub

    Private Sub EtapeValidation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EtapeCode = TxtCodeIni.Text
        EtapeLibelle = TxtLibelleIni.Text
        If ListesCatDemandeurs.NewSaisie = True Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            aModifier = False
        ElseIf ListesCatDemandeurs.OpenRejet = True Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = False
        Else
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            aModifier = True
        End If
    End Sub

    
End Class