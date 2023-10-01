Imports System.Data.OleDb
Imports System.IO
Public Class CreationCircuit
    Public WithEvents combo As ComboBox
    Dim Insert As Boolean
    Dim OleAdaptaterschema As OleDbDataAdapter
    Dim OleSchemaDataset As DataSet
    Dim OledatableSchema As DataTable
    Dim OleCommandEnreg As OleDbCommand
    Dim Insertion As String
    Dim EtapeCode As String
    Dim EtapeLibelle As String
    Dim aModifier, nouvellesaisie As Boolean
    Public Etapefin As Integer
    Public GardelastPrec As Integer

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer
        Try
            If VerifieEtapeFinal() = True Then
                If VerifieEtapeIni() = True Then
                    If OrdonnerEtape() = True Then
                        If Trim(TxtCodeCir.Text) <> "" Then
                            If aModifier = False Then
                                OleAdaptaterschema = New OleDbDataAdapter("select * from CIRCUITVALIDATION where CodeCircuitVa='" & Trim(TxtCodeCir.Text) & "'", sqlConAppli)
                                OleSchemaDataset = New DataSet
                                OleAdaptaterschema.Fill(OleSchemaDataset)
                                OledatableSchema = OleSchemaDataset.Tables(0)
                                If OledatableSchema.Rows.Count > 0 Then
                                    MsgBox("Il existe déja un Circuit de validation de meme code", MsgBoxStyle.Information, "Circuit de validation")
                                    TxtCodeCir.Focus()
                                Else
                                    Insertion = "Insert Into CIRCUITVALIDATION (CodeCircuitVa,Intitule,CodeEtapeInitial,CodeEtapeFin,CreateUser,DateCreation) VALUES ('" & Trim(TxtCodeCir.Text) & "','" & Trim(TxtLibelleCir.Text) & "','" & Trim(CodeIni.Text) & "','" & Trim(ComboEtapefin.Text) & "','" & DernierUser & "',CONVERT(DATETIME, '" & Format(CDate(FormatDateTime(Now.Date, DateFormat.ShortDate)), "yyyy/MM/dd") & "', 102))"
                                    OleCommandEnreg = New OleDbCommand(Insertion)
                                    OleCommandEnreg.Connection = sqlConAppli
                                    OleCommandEnreg.ExecuteNonQuery()
                                    If DataListeSchema.Rows.Count > 0 Then
                                        Insertion = "DELETE EtapePossible WHERE CodeCircuitVa='" & Trim(TxtCodeCir.Text) & "'"
                                        OleCommandEnreg = New OleDbCommand(Insertion)
                                        OleCommandEnreg.Connection = sqlConAppli
                                        OleCommandEnreg.ExecuteNonQuery()
                                        For i = 0 To DataListeSchema.Rows.Count - 1
                                            Insertion = "Insert Into EtapePossible (CodeCircuitVa,CodeEtapeSuivant,CodeEtapeCourant,ordre) VALUES ('" & Trim(TxtCodeCir.Text) & "','" & Trim(DataListeSchema.Rows(i).Cells("EtapeSuivante").Value) & "','" & Trim(DataListeSchema.Rows(i).Cells("EtapeCourante").Value) & "','" & Trim(DataListeSchema.Rows(i).Cells("Ordre").Value) & "')"
                                            OleCommandEnreg = New OleDbCommand(Insertion)
                                            OleCommandEnreg.Connection = sqlConAppli
                                            OleCommandEnreg.ExecuteNonQuery()
                                        Next i
                                    End If
                                    ListesEtapes.NewSaisie = False
                                    ComboEtapefin.Enabled = False
                                    ComboEtapefin.BackColor = Color.Gray
                                    TxtCodeCir.Enabled = False
                                    Insert = True
                                    Button1.Enabled = True
                                    Button2.Enabled = True
                                    Button3.Enabled = False
                                    Me.Refresh()
                                End If
                            Else
                                OleAdaptaterschema = New OleDbDataAdapter("select * from CIRCUITVALIDATION where CodeCircuitVa='" & Trim(TxtCodeCir.Text) & "'", sqlConAppli)
                                OleSchemaDataset = New DataSet
                                OleAdaptaterschema.Fill(OleSchemaDataset)
                                OledatableSchema = OleSchemaDataset.Tables(0)
                                If OledatableSchema.Rows.Count > 0 Then
                                    Insertion = "Update CIRCUITVALIDATION SET Intitule='" & Trim(TxtLibelleCir.Text) & "',UpdateUser='" & DernierUser & "',DateUpdate=CONVERT(DATETIME, '" & Format(CDate(FormatDateTime(Now.Date, DateFormat.ShortDate)), "yyyy/MM/dd") & "', 102)  WHERE CodeCircuitVa='" & Trim(TxtCodeCir.Text) & "'"
                                    OleCommandEnreg = New OleDbCommand(Insertion)
                                    OleCommandEnreg.Connection = sqlConAppli
                                    OleCommandEnreg.ExecuteNonQuery()
                                    Insertion = "DELETE EtapePossible WHERE CodeCircuitVa='" & Trim(TxtCodeCir.Text) & "'"
                                    OleCommandEnreg = New OleDbCommand(Insertion)
                                    OleCommandEnreg.Connection = sqlConAppli
                                    OleCommandEnreg.ExecuteNonQuery()
                                    For i = 0 To DataListeSchema.Rows.Count - 1
                                        Insertion = "Insert Into EtapePossible (CodeCircuitVa,CodeEtapeSuivant,CodeEtapeCourant,ordre) VALUES ('" & Trim(TxtCodeCir.Text) & "','" & Trim(DataListeSchema.Rows(i).Cells("EtapeSuivante").Value) & "','" & Trim(DataListeSchema.Rows(i).Cells("EtapeCourante").Value) & "','" & Trim(DataListeSchema.Rows(i).Cells("Ordre").Value) & "')"
                                        OleCommandEnreg = New OleDbCommand(Insertion)
                                        OleCommandEnreg.Connection = sqlConAppli
                                        OleCommandEnreg.ExecuteNonQuery()
                                    Next i
                                    aModifier = False
                                    ListesEtapes.OpenRejet = False
                                    Insert = True
                                    Button1.Enabled = True
                                    Button2.Enabled = True
                                    Button3.Enabled = False
                                    Me.Refresh()
                                End If
                            End If
                        Else
                            MsgBox("Véuillez renseignez le code du circuit", MsgBoxStyle.Information, "Circuit de validation")
                        End If
                    Else
                        MsgBox("Vérifier l'enchaînement des étapes", MsgBoxStyle.Information, "Circuit de validation")
                    End If
                Else
                    MsgBox("Vérifier l'existance de l'etapes Initial ", MsgBoxStyle.Information, "Circuit de validation")
                End If
            Else
                MsgBox("Vérifier l'existance de l'etape  final", MsgBoxStyle.Information, "Circuit de validation")
            End If
            ListesCircuit.AfficheCircuit()
            ListesCircuit.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListesCircuit.NewSaisie = True
        ListesCircuit.OpenRejet = False
        TxtCodeCir.Text = ""
        TxtLibelleCir.Text = ""
        TxtLibelleFinal.Text = ""
        TxtCodeCir.Enabled = True
        DataListeSchema.Rows.Clear()
        afficheEtapeini()
        Etapefin = 0
        alimEtapefin()
        ComboEtapefin.BackColor = Color.LightYellow
        ComboEtapefin.Enabled = True
        Etapefin = Etapefin + 1
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = True
        ComboEtapefin.Text = "        "
        Me.Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            'Dim OleAdaptaterschema1 As OleDbDataAdapter
            'Dim OleSchemaDataset1 As DataSet
            'Dim OledatableSchema1 As DataTable
            'OleAdaptaterschema1 = New OleDbDataAdapter("select * from DETAILMVTSORTIE where CodeCircuitVa='" & Trim(OledatableSchema.Rows(0).Item("CodeCircuitVa")) & "'", sqlConAppli)
            'OleSchemaDataset1 = New DataSet
            'OleAdaptaterschema1.Fill(OleSchemaDataset1)
            'OledatableSchema1 = OleSchemaDataset1.Tables(0)
            'If OledatableSchema1.Rows.Count = 0 Then
            '    OleAdaptaterschema = New OleDbDataAdapter("select * from CIRCUITVALIDATION where CodeCircuitVa='" & Trim(TxtCodeCir.Text) & "'", sqlConAppli)
            '    OleSchemaDataset = New DataSet
            '    OleAdaptaterschema.Fill(OleSchemaDataset)
            '    OledatableSchema = OleSchemaDataset.Tables(0)
            '    If OledatableSchema.Rows.Count > 0 Then
            '        Insertion = "DELETE CIRCUITVALIDATION WHERE CodeCircuitVa='" & Trim(TxtCodeCir.Text) & "'"
            '        OleCommandEnreg = New OleDbCommand(Insertion)
            '        OleCommandEnreg.Connection = sqlConAppli
            '        OleCommandEnreg.ExecuteNonQuery()
            '        Insertion = "DELETE EtapePossible WHERE CodeCircuitVa='" & Trim(TxtCodeCir.Text) & "'"
            '        OleCommandEnreg = New OleDbCommand(Insertion)
            '        OleCommandEnreg.Connection = sqlConAppli
            '        OleCommandEnreg.ExecuteNonQuery()
            '        ListesCircuit.NewSaisie = True
            '        TxtCodeCir.Text = ""
            '        TxtLibelleCir.Text = ""
            '        TxtLibelleFinal.Text = ""
            '        TxtCodeCir.Enabled = True
            '        DataListeSchema.Rows.Clear()
            '        afficheEtapeini()
            '        Etapefin = 0
            '        alimEtapefin()
            '        ComboEtapefin.BackColor = Color.LightYellow
            '        ComboEtapefin.Enabled = True
            '        Etapefin = Etapefin + 1
            '        Button1.Enabled = False
            '        Button2.Enabled = False
            '        Button3.Enabled = True
            '        Me.Refresh()
            '        ListesCircuit.AfficheCircuit()
            '        ListesCircuit.Refresh()
            '    Else
            '        ListesCircuit.NewSaisie = True
            '        TxtCodeCir.Text = ""
            '        TxtLibelleCir.Text = ""
            '        TxtLibelleFinal.Text = ""
            '        TxtCodeCir.Enabled = True
            '        DataListeSchema.Rows.Clear()
            '        afficheEtapeini()
            '        Etapefin = 0
            '        alimEtapefin()
            '        ComboEtapefin.BackColor = Color.LightYellow
            '        ComboEtapefin.Enabled = True
            '        Etapefin = Etapefin + 1
            '        Button1.Enabled = False
            '        Button2.Enabled = False
            '        Button3.Enabled = True
            '        Me.Refresh()
            '    End If
            'Else
            '    MessageBox.Show("Des décaissements suivents déja ce circuit", "Suppression Circuit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Suppression Circuit", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EtapeValidation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EtapeCode = TxtCodeCir.Text
        EtapeLibelle = TxtLibelleCir.Text
        If ListesCircuit.NewSaisie = True Then
            TxtCodeCir.Text = ""
            TxtLibelleCir.Text = ""
            TxtLibelleFinal.Text = ""
            TxtCodeCir.Enabled = True
            DataListeSchema.Rows.Clear()
            afficheEtapeini()
            Etapefin = 0
            alimEtapefin()
            ComboEtapefin.BackColor = Color.LightYellow
            ComboEtapefin.Enabled = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            BT_DelRow.Enabled = False
            aModifier = False
            ComboEtapefin.Text = "        "
            Etapefin = Etapefin + 1
            verifiePresenceLigne()
        ElseIf ListesCircuit.OpenRejet = True Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = False
            Etapefin = Etapefin + 1
            aModifier = True
            verifiePresenceLigne()
        Else
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            aModifier = True
            ComboEtapefin.Text = "        "
            verifiePresenceLigne()
        End If
    End Sub
    Private Sub afficheEtapeini()
        OleAdaptaterschema = New OleDbDataAdapter("select * from Etape where  IDOetap=1001", sqlConAppli)
        OleSchemaDataset = New DataSet
        OleAdaptaterschema.Fill(OleSchemaDataset)
        OledatableSchema = OleSchemaDataset.Tables(0)
        If OledatableSchema.Rows.Count > 0 Then
            CodeIni.Text = OledatableSchema.Rows(0).Item("CodeEtape")
            LibelleIni.Text = OledatableSchema.Rows(0).Item("Intitule")
            DataListeSchema.Rows.Clear()
            DataListeSchema.Rows.Add()
            DataListeSchema.Rows(0).Cells("Ordre").Value = "1"
            DataListeSchema.Rows(0).Cells("EtapeCourante").Value = OledatableSchema.Rows(0).Item("CodeEtape")
            DataListeSchema.Rows(0).Cells("LibelleEtapeCourante").Value = OledatableSchema.Rows(0).Item("Intitule")
            alimentationComboDatagrid(0)
        End If
    End Sub
    Public Sub alimentationComboDatagrid(ByVal ligne As Integer)
        OleAdaptaterschema = New OleDbDataAdapter("select * from Etape where  IDOetap=1000", sqlConAppli)
        OleSchemaDataset = New DataSet
        OleAdaptaterschema.Fill(OleSchemaDataset)
        OledatableSchema = OleSchemaDataset.Tables(0)
        If OledatableSchema.Rows.Count > 0 Then
            Dim Dgvc As New DataGridViewComboBoxCell
            Dgvc.Items.Clear()
            Dgvc.Items.Add("        ")
            For j As Integer = 0 To OledatableSchema.Rows.Count - 1
                Dgvc.Items.Add(OledatableSchema.Rows(j).Item("CodeEtape"))
            Next
            'Dgvc.DataSource = OledatableSchema
            'Dgvc.DisplayMember = "CodeEtape"
            DataListeSchema.Item(3, ligne) = Dgvc
        End If
    End Sub
    Private Sub alimEtapefin()
        OleAdaptaterschema = New OleDbDataAdapter("select CodeEtape from Etape where  IDOetap=1000", sqlConAppli)
        OleSchemaDataset = New DataSet
        OleAdaptaterschema.Fill(OleSchemaDataset)
        OledatableSchema = OleSchemaDataset.Tables(0)
        ComboEtapefin.Items.Clear()
        If OledatableSchema.Rows.Count > 0 Then
            ComboEtapefin.Items.Add("        ")
            For j As Integer = 0 To OledatableSchema.Rows.Count - 1
                ComboEtapefin.Items.Add(OledatableSchema.Rows(j).Item("CodeEtape"))
            Next j
        End If
    End Sub

    'Combo DataGridView
    Private Sub DataListeSchema_EditingControlShowing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles DataListeSchema.EditingControlShowing
        If TypeOf e.Control Is ComboBox Then
            combo = CType(e.Control, ComboBox)
            GardelastPrec = DataListeSchema.CurrentRow.Index
        End If
    End Sub
    Private Sub ComboEtapefin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboEtapefin.SelectedIndexChanged
        Try
            If Etapefin = 1 Then
                Dim i As Integer
                Dim last As Integer
                OleAdaptaterschema = New OleDbDataAdapter("select * from Etape where  IDOetap=1000 AND CodeEtape='" & Trim(ComboEtapefin.Text) & "'", sqlConAppli)
                OleSchemaDataset = New DataSet
                OleAdaptaterschema.Fill(OleSchemaDataset)
                OledatableSchema = OleSchemaDataset.Tables(0)
                If OledatableSchema.Rows.Count > 0 Then
                    TxtLibelleFinal.Text = OledatableSchema.Rows(0).Item("Intitule")
                    For i = 0 To DataListeSchema.Rows.Count - 1
                        If DataListeSchema.Rows(i).Cells("fin").Value = "fin" Then
                            DataListeSchema.Rows.RemoveAt(i)
                            Exit For
                        End If
                    Next i
                    last = DataListeSchema.Rows.GetLastRow(DataGridViewElementStates.Displayed)
                    DataListeSchema.Rows.Add()
                    DataListeSchema.Rows(last + 1).Cells("Ordre").Value = CStr(CInt(DataListeSchema.Rows(last).Cells("Ordre").Value) + 1)
                    DataListeSchema.Rows(last + 1).Cells("EtapeCourante").Value = OledatableSchema.Rows(0).Item("CodeEtape")
                    DataListeSchema.Rows(last + 1).Cells("LibelleEtapeCourante").Value = OledatableSchema.Rows(0).Item("Intitule")
                    DataListeSchema.Rows(last + 1).Cells("EtapeSuivante").ReadOnly = True
                    DataListeSchema.Rows(last + 1).Cells("fin").Value = "fin"
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Function VerifierCourant(ByVal CodeEtapeCourant As String) As Boolean
        Try
            Dim i As Integer
            Dim resultat As Boolean
            resultat = False
            If DataListeSchema.Rows.Count > 0 Then
                For i = 0 To DataListeSchema.Rows.Count - 1
                    If Trim(DataListeSchema.Rows(i).Cells("EtapeCourante").Value) = Trim(CodeEtapeCourant) Then
                        resultat = True
                        Exit For
                    End If
                Next i
            End If
            Return resultat
        Catch ex As Exception

        End Try
    End Function

    Private Sub BT_DelRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_DelRow.Click
        Dim first As Integer
        Dim last As Integer
        Try
            first = DataListeSchema.Rows.GetFirstRow(DataGridViewElementStates.Displayed)
            last = DataListeSchema.Rows.GetLastRow(DataGridViewElementStates.Displayed)
            If last >= 0 Then
                If last - first >= 0 Then
                    If Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("Ordre").Value) <> "1" Then
                        If Trim(DataListeSchema.Rows(DataListeSchema.CurrentRow.Index).Cells("fin").Value) <> "fin" Then
                            DataListeSchema.Rows.RemoveAt(DataListeSchema.CurrentRow.Index)
                        End If
                    End If
                End If
            End If
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            verifiePresenceLigne()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub verifiePresenceLigne()
        If DataListeSchema.Rows.Count > 0 Then
            BT_DelRow.Enabled = True
        Else
            BT_DelRow.Enabled = False
        End If
    End Sub
    Private Function VerifieEtapeIni() As Boolean
        Dim i As Integer
        Dim resultat As Boolean
        resultat = False
        For i = 0 To DataListeSchema.Rows.Count - 1
            If DataListeSchema.Rows(i).Cells("Ordre").Value = "1" Then
                resultat = True
                Exit For
            End If
        Next i
        Return resultat
    End Function
    Private Function VerifieEtapeFinal() As Boolean
        Try
            Dim i As Integer
            Dim resultat As Boolean
            resultat = False
            For i = 0 To DataListeSchema.Rows.Count - 1
                If DataListeSchema.Rows(i).Cells("fin").Value = "fin" Then
                    resultat = True
                    Exit For
                End If
            Next i
            Return resultat
        Catch ex As Exception

        End Try
    End Function
    Private Function OrdonnerEtape() As Boolean
        Try
            Dim ListeEtapeCourante As List(Of String)
            Dim DecoupeElement() As String
            Dim EtapeSuivante As String
            Dim i, j, IndexEtapefin As Integer
            Dim ordre As Integer
            Dim resultat, trouver As Boolean
            ListeEtapeCourante = New List(Of String)
            For i = 0 To DataListeSchema.Rows.Count - 1
                If DataListeSchema.Rows(i).Cells("fin").Value = "fin" Then
                    IndexEtapefin = i
                End If
                If DataListeSchema.Rows(i).Cells("Ordre").Value <> "1" Then
                    ListeEtapeCourante.Add(DataListeSchema.Rows(i).Cells("EtapeCourante").Value & "<>" & CStr(i))
                End If
            Next i
            ordre = CInt(DataListeSchema.Rows(0).Cells("Ordre").Value)
            EtapeSuivante = DataListeSchema.Rows(0).Cells("EtapeSuivante").Value
            resultat = True
            For i = 1 To DataListeSchema.Rows.Count - 1
                trouver = False
                For j = 0 To ListeEtapeCourante.Count - 1
                    DecoupeElement = Split(ListeEtapeCourante.Item(j), "<>")
                    If Trim(DecoupeElement(0)) = EtapeSuivante Then
                        ordre = ordre + 1
                        EtapeSuivante = DataListeSchema.Rows(CInt(Trim(DecoupeElement(1)))).Cells("EtapeSuivante").Value
                        ListeEtapeCourante.RemoveAt(j)
                        trouver = True
                        Exit For
                    End If
                Next j
                If trouver = False Then
                    resultat = False
                    Exit For
                End If

            Next i
            Return resultat
        Catch ex As Exception

        End Try
    End Function
    Private Sub EvenementComGrid()
        Try
            Dim last, i, order As Integer
            Dim CodeEtapeCourante As String
            'selection pour recherche les informations par rapport à l'etape courante
            OleAdaptaterschema = New OleDbDataAdapter("select * from Etape where  IDOetap=1000 AND CodeEtape='" & Trim(combo.Text) & "'", sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)

            'la fonction Index permert de recherche l'index de l'etape courante
            'GardelastPrec = Index(Trim(combo.Text))

            order = CInt(DataListeSchema.Rows(GardelastPrec).Cells("Ordre").Value)
            CodeEtapeCourante = DataListeSchema.Rows(GardelastPrec).Cells("EtapeCourante").Value
            If OledatableSchema.Rows.Count > 0 Then
                If VerifierCourant(Trim(combo.Text)) = False Then
                    If Trim(ComboEtapefin.Text) = Trim(combo.Text) Then
                        combo.Text = Trim(ComboEtapefin.Text)
                        For i = 0 To DataListeSchema.Rows.Count - 1
                            If DataListeSchema.Rows(i).Cells("fin").Value = "fin" Then
                                DataListeSchema.Rows.RemoveAt(i)
                                Exit For
                            End If
                        Next i
                        For i = 0 To DataListeSchema.Rows.Count - 1
                            If DataListeSchema.Rows(i).Cells("EtapeCourante").Value = CodeEtapeCourante Then
                                DataListeSchema.Rows(i).Cells("EtapeSuivante").Value = Trim(ComboEtapefin.Text)
                                DataListeSchema.Rows(i).Cells("LibelleEtapeSuivante").Value = OledatableSchema.Rows(0).Item("Intitule")
                                Exit For
                            End If
                        Next i
                        DataListeSchema.Rows(GardelastPrec).Cells("LibelleEtapeSuivante").Value = OledatableSchema.Rows(0).Item("Intitule")
                        DataListeSchema.Rows.Add()
                        last = DataListeSchema.Rows.GetLastRow(DataGridViewElementStates.Displayed)
                        DataListeSchema.Rows(last).Cells("Ordre").Value = CStr(order + 1)
                        DataListeSchema.Rows(last).Cells("EtapeCourante").Value = OledatableSchema.Rows(0).Item("CodeEtape")
                        DataListeSchema.Rows(last).Cells("LibelleEtapeCourante").Value = OledatableSchema.Rows(0).Item("Intitule")
                        DataListeSchema.Rows(last).Cells("EtapeSuivante").ReadOnly = True
                        DataListeSchema.Rows(last).Cells("fin").Value = "fin"
                        'alimentationComboDatagrid(last)
                    Else
                        DataListeSchema.Rows(GardelastPrec).Cells("LibelleEtapeSuivante").Value = OledatableSchema.Rows(0).Item("Intitule")
                        DataListeSchema.Rows.Add()
                        last = DataListeSchema.Rows.GetLastRow(DataGridViewElementStates.Displayed)
                        DataListeSchema.Rows(last).Cells("Ordre").Value = CStr(CInt(order) + 1)
                        DataListeSchema.Rows(last).Cells("EtapeCourante").Value = OledatableSchema.Rows(0).Item("CodeEtape")
                        DataListeSchema.Rows(last).Cells("LibelleEtapeCourante").Value = OledatableSchema.Rows(0).Item("Intitule")
                        alimentationComboDatagrid(last)
                        DataListeSchema.Rows(last).Selected = True
                    End If
                Else
                    If Trim(ComboEtapefin.Text) = Trim(combo.Text) Then
                        combo.Text = Trim(ComboEtapefin.Text)
                        For i = 0 To DataListeSchema.Rows.Count - 1
                            If DataListeSchema.Rows(i).Cells("fin").Value = "fin" Then
                                DataListeSchema.Rows.RemoveAt(i)
                                Exit For
                            End If
                        Next i
                        For i = 0 To DataListeSchema.Rows.Count - 1
                            If DataListeSchema.Rows(i).Cells("EtapeCourante").Value = CodeEtapeCourante Then
                                DataListeSchema.Rows(i).Cells("EtapeSuivante").Value = Trim(ComboEtapefin.Text)
                                DataListeSchema.Rows(i).Cells("LibelleEtapeSuivante").Value = OledatableSchema.Rows(0).Item("Intitule")
                                Exit For
                            End If
                        Next i
                        DataListeSchema.Rows.Add()
                        last = DataListeSchema.Rows.GetLastRow(DataGridViewElementStates.Displayed)
                        DataListeSchema.Rows(last).Cells("Ordre").Value = CStr(order + 1)
                        DataListeSchema.Rows(last).Cells("EtapeCourante").Value = OledatableSchema.Rows(0).Item("CodeEtape")
                        DataListeSchema.Rows(last).Cells("LibelleEtapeCourante").Value = OledatableSchema.Rows(0).Item("Intitule")
                        DataListeSchema.Rows(last).Cells("EtapeSuivante").ReadOnly = True
                        DataListeSchema.Rows(last).Cells("fin").Value = "fin"
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Function Index(ByVal CodeEtape As String) As Integer
        'Dim i As Integer
        'For i = 0 To DataListeSchema.Rows.Count - 1
        '    If DataListeSchema.Rows(i).Cells("EtapeSuivante").Value = Trim(CodeEtape) Then
        '        Return i
        '    End If
        'Next i
    End Function
    
    Private Sub TxtLibelleCir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLibelleCir.TextChanged
        If ListesCircuit.NewSaisie = True Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            aModifier = False
        ElseIf ListesCircuit.OpenRejet = True And Etapefin = 0 Then
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

    Private Sub DataListeSchema_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataListeSchema.KeyUp
        If e.KeyCode = Keys.Enter Then
            EvenementComGrid()
        End If
    End Sub

    Private Sub DataListeSchema_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataListeSchema.CellContentClick
        If e.RowIndex > 0 Then
            DataListeSchema.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub combo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo.SelectedValueChanged
        If ListesCircuit.NewSaisie = True Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            aModifier = False
            EvenementComGrid()
        ElseIf ListesCircuit.OpenRejet = True Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            EvenementComGrid()
        Else
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            EvenementComGrid()
            aModifier = True
        End If
    End Sub
End Class