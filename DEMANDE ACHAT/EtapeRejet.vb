Imports System.Data.OleDb
Imports System.IO
Public Class EtapeRejet
    Dim Insert As Boolean
    Dim OleAdaptaterschema As OleDbDataAdapter
    Dim OleSchemaDataset As DataSet
    Dim OledatableSchema As DataTable
    Dim OleCommandEnreg As OleDbCommand
    Dim Insertion As String
    Dim EtapeCode As String
    Dim EtapeLibelle As String
    Dim def As Integer
    Dim aModifier, nouvellesaisie As Boolean

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If aModifier = False Then
                OleAdaptaterschema = New OleDbDataAdapter("select * from Etape where CodeEtape='" & Trim(TxtCodeIni.Text) & "' AND IDOetap=1002", sqlConAppli)
                OleSchemaDataset = New DataSet
                OleAdaptaterschema.Fill(OleSchemaDataset)
                OledatableSchema = OleSchemaDataset.Tables(0)
                If OledatableSchema.Rows.Count > 0 Then
                    MsgBox("Il existe déja une Etape de rejet de meme code", MsgBoxStyle.Information, "Etapes rejets")
                Else
                    If CheckBox1.Checked = True Then
                        def = 1
                    Else
                        def = 0
                    End If
                    Insertion = "Insert Into Etape (CodeEtape,Intitule,IDOetap,Definitif) VALUES ('" & Trim(TxtCodeIni.Text) & "','" & Trim(TxtLibelleIni.Text) & "',1002," & def & ")"
                    OleCommandEnreg = New OleDbCommand(Insertion)
                    OleCommandEnreg.Connection = sqlConAppli
                    OleCommandEnreg.ExecuteNonQuery()
                    ListesEtarejet.NewSaisie = False
                End If
            ElseIf aModifier = True Then
                If CheckBox1.Checked = True Then
                    def = 1
                Else
                    def = 0
                End If
                Insertion = "Update Etape SET Intitule='" & Trim(TxtLibelleIni.Text) & "', Definitif=" & def & " WHERE CodeEtape='" & Trim(TxtCodeIni.Text) & "'"
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                aModifier = False
                ListesEtarejet.OpenRejet = False
            End If
            Insert = True
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = False
            TxtCodeIni.Enabled = False
            Me.Refresh()
            ListesEtarejet.AffichEtapRejet()
            ListesEtarejet.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListesEtarejet.NewSaisie = True
        TxtCodeIni.Text = ""
        TxtLibelleIni.Text = ""
        TxtCodeIni.Enabled = True
        CheckBox1.Checked = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = True
        Me.Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            OleAdaptaterschema = New OleDbDataAdapter("select * from DETAILMVTSORTIE where CodeEtape='" & Trim(TxtCodeIni.Text) & "'", sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)
            If OledatableSchema.Rows.Count > 0 Then
                MessageBox.Show("Cette étape est déja impliquée dans une demande", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Insertion = "DELETE Etape WHERE CodeEtape='" & Trim(TxtCodeIni.Text) & "' and IDOetap=1002"
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                ListesEtarejet.NewSaisie = True
                ListesEtarejet.OpenRejet = False
                TxtCodeIni.Text = ""
                TxtLibelleIni.Text = ""
                TxtCodeIni.Enabled = True
                CheckBox1.Checked = False
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                Me.Refresh()
                ListesEtarejet.AffichEtapRejet()
                ListesEtarejet.Refresh()
            End If
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub TxtLibelleIni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLibelleIni.TextChanged
        If ListesEtarejet.NewSaisie = True Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            aModifier = False
        ElseIf ListesEtarejet.OpenRejet = True Then
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

    Private Sub EtapeRejet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EtapeCode = TxtCodeIni.Text
        EtapeLibelle = TxtLibelleIni.Text
        If ListesEtarejet.NewSaisie = True Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            aModifier = False
        ElseIf ListesEtarejet.OpenRejet = True Then
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

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If ListesEtarejet.NewSaisie = True Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            aModifier = False
        ElseIf ListesEtarejet.OpenRejet = True Then
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