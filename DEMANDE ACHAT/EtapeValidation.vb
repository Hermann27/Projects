Imports System.Data.OleDb
Imports System.IO
Public Class EtapeValidation
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
                OleAdaptaterschema = New OleDbDataAdapter("select * from Etape where CodeEtape='" & Trim(TxtCodeIni.Text) & "' AND IDOetap=1000", sqlConAppli)
                OleSchemaDataset = New DataSet
                OleAdaptaterschema.Fill(OleSchemaDataset)
                OledatableSchema = OleSchemaDataset.Tables(0)
                If OledatableSchema.Rows.Count > 0 Then
                    MsgBox("Il existe déja une Etape de validation de meme code", MsgBoxStyle.Information, "Etapes de validation")
                Else
                    Insertion = "Insert Into Etape (CodeEtape,Intitule,IDOetap) VALUES ('" & Trim(TxtCodeIni.Text) & "','" & Trim(TxtLibelleIni.Text) & "',1000)"
                    OleCommandEnreg = New OleDbCommand(Insertion)
                    OleCommandEnreg.Connection = sqlConAppli
                    OleCommandEnreg.ExecuteNonQuery()
                    ListesEtapes.NewSaisie = False
                End If
            ElseIf aModifier = True Then
                Insertion = "Update Etape SET Intitule='" & Trim(TxtLibelleIni.Text) & " WHERE CodeEtape='" & Trim(TxtCodeIni.Text) & "' AND IDOetap=1000"
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                aModifier = False
                ListesEtapes.OpenRejet = False
            End If
            Insert = True
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = False
            TxtCodeIni.Enabled = False
            Me.Refresh()
            ListesEtapes.AffichEtapes()
            ListesEtapes.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListesEtapes.NewSaisie = True
        TxtCodeIni.Text = ""
        TxtLibelleIni.Text = ""
        TxtCodeIni.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = True
        Me.Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            OleAdaptaterschema = New OleDbDataAdapter("select * from EtapePossible where CodeEtapeCourant='" & Trim(TxtCodeIni.Text) & "'", sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)
            If OledatableSchema.Rows.Count > 0 Then
                MsgBox("Impossible de supprimer des circuits y sont liées", MsgBoxStyle.Information, "ETAPE VALIDATION")
            Else
                Insertion = "DELETE Etape WHERE CodeEtape='" & Trim(TxtCodeIni.Text) & "' AND IDOetap=1000"
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                ListesEtapes.NewSaisie = True
                ListesEtapes.OpenRejet = False
                TxtCodeIni.Text = ""
                TxtLibelleIni.Text = ""
                TxtCodeIni.Enabled = True
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = True
                Me.Refresh()
                ListesEtapes.AffichEtapes()
                ListesEtapes.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Suppression Etape Validation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub TxtLibelleIni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLibelleIni.TextChanged
        If ListesEtapes.NewSaisie = True Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            aModifier = False
        ElseIf ListesEtapes.OpenRejet = True Then
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
        If ListesEtapes.NewSaisie = True Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            aModifier = False
        ElseIf ListesEtapes.OpenRejet = True Then
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

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ListesEtapes.NewSaisie = True Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            aModifier = False
        ElseIf ListesEtapes.OpenRejet = True Then
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