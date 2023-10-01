Imports System.Data.OleDb
Imports System.IO
Public Class EtapeInitial
    Dim Insert As Boolean
    Dim OleAdaptaterschema As OleDbDataAdapter
    Dim OleSchemaDataset As DataSet
    Dim OledatableSchema As DataTable
    Dim OleCommandEnreg As OleDbCommand
    Dim Insertion As String
    Dim aModifier As Boolean = False
    Dim nouvelleSaisie As Boolean
    Dim modif As Integer
    Private Sub EtapeInitial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OleAdaptaterschema = New OleDbDataAdapter("select * from Etape where IDOetap=1001", sqlConAppli)
        OleSchemaDataset = New DataSet
        OleAdaptaterschema.Fill(OleSchemaDataset)
        OledatableSchema = OleSchemaDataset.Tables(0)
        If OledatableSchema.Rows.Count > 0 Then
            Button3.Enabled = False
            TxtCodeIni.Text = OledatableSchema.Rows(0).Item("CodeEtape")
            TxtLibelleIni.Text = OledatableSchema.Rows(0).Item("Intitule")
            TxtCodeIni.Enabled = False
          Else
            TxtCodeIni.Text = ""
            TxtLibelleIni.Text = ""
            Button2.Enabled = False
            nouvelleSaisie = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If aModifier = False Or nouvelleSaisie = True Then
                Insertion = "Insert Into Etape (CodeEtape,Intitule,IDOetap) VALUES ('" & Trim(TxtCodeIni.Text) & "','" & Trim(TxtLibelleIni.Text) & "',1001)"
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                nouvelleSaisie = False
            ElseIf aModifier = True Then
                Insertion = "UPDATE Etape SET Intitule='" & Trim(TxtLibelleIni.Text) & "' WHERE CodeEtape='" & Trim(TxtCodeIni.Text) & "'"
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
            End If
            Insert = True
            Button2.Enabled = True
            Button1.Enabled = True
            Button3.Enabled = False
            aModifier = False
            Me.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OleAdaptaterschema = New OleDbDataAdapter("select * from Etape where IDOetap=1001", sqlConAppli)
        OleSchemaDataset = New DataSet
        OleAdaptaterschema.Fill(OleSchemaDataset)
        OledatableSchema = OleSchemaDataset.Tables(0)
        If OledatableSchema.Rows.Count > 0 Then
            MsgBox("Un seul objet de cette classe (Etape Initiale) peut être créer", MsgBoxStyle.Information, "ETAPE INITIAL")
        Else
            TxtCodeIni.Text = ""
            TxtLibelleIni.Text = ""
            Button2.Enabled = False
            Button1.Enabled = True
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OleAdaptaterschema = New OleDbDataAdapter("select * from EtapePossible where CodeEtapeCourant='" & Trim(TxtCodeIni.Text) & "'", sqlConAppli)
        OleSchemaDataset = New DataSet
        OleAdaptaterschema.Fill(OleSchemaDataset)
        OledatableSchema = OleSchemaDataset.Tables(0)
        If OledatableSchema.Rows.Count > 0 Then
            MsgBox("Impossible de supprimer des circuits y sont liées", MsgBoxStyle.Information, "ETAPE INITIAL")
        Else
            OleAdaptaterschema = New OleDbDataAdapter("select * from Etape where CodeEtape='" & Trim(TxtCodeIni.Text) & "' AND IDOetap=1001", sqlConAppli)
            OleSchemaDataset = New DataSet
            OleAdaptaterschema.Fill(OleSchemaDataset)
            OledatableSchema = OleSchemaDataset.Tables(0)
            If OledatableSchema.Rows.Count > 0 Then
                Insertion = "DELETE Etape WHERE CodeEtape='" & Trim(TxtCodeIni.Text) & "' and IDOetap=1001"
                OleCommandEnreg = New OleDbCommand(Insertion)
                OleCommandEnreg.Connection = sqlConAppli
                OleCommandEnreg.ExecuteNonQuery()
                TxtCodeIni.Text = ""
                TxtLibelleIni.Text = ""
                Button1.Enabled = True
                Button2.Enabled = False
                Button3.Enabled = True
                TxtCodeIni.Enabled = True
                nouvelleSaisie = True
            End If
        End If
    End Sub

    Private Sub TxtLibelleIni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLibelleIni.TextChanged
        modif = modif + 1
        If modif > 1 Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = True
            aModifier = True
        Else
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = False
        End If
    End Sub
End Class