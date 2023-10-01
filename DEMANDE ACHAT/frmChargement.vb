Public Class frmChargement
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
        End If
        If ProgressBar1.Value > 0 And ProgressBar1.Value < 20 Then
            Label1.Text = "Detection des Parametres De Connexion"
        End If
        If ProgressBar1.Value > 20 And ProgressBar1.Value < 40 Then
            Label1.Text = ""
        End If
        If ProgressBar1.Value > 40 And ProgressBar1.Value < 70 Then
            Label1.Text = "Mise a Jour des Fichiers"
        End If
        If ProgressBar1.Value > 70 And ProgressBar1.Value < 90 Then
            Label1.Text = "Connexion au Serveur"
        End If
        If ProgressBar1.Value > 90 And ProgressBar1.Value <= 100 Then
            Label4.Text = "Chargement de l'object Metiers 100"

        End If
        If ProgressBar1.Value > 95 And ProgressBar1.Value <= 100 Then
            Label3.Text = "Patientez Quelques Secondes ...SVP..."
        End If
        If ProgressBar1.Value = 100 Then
            Timer2.Enabled = False
            Timer3.Enabled = False
        End If
        Label2.Text = ProgressBar1.Value & " %"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Reponse As Object
        If ProgressBar1.Value = 100 Then
            'If OuvreBaseCompta(BaseCpta2, cheminCpta, utilisateurCpta, motdepasseCpta) = True Then
            If connexionSql(sqlCon, serveurSql, baseSql, userSql, pwdSql) = True Then
                If connexionSql(sqlConAppli, serveurSql, baseAppli, userSql, pwdSql) = True Then
                    frmIndex.Show()
                    'login.MdiParent = frmIndex
                    Me.Close()
                    login.CLogin.Text = Trim(DernierUser)
                    'login.MdiParent = frmIndex
                    login.ShowDialog()
                Else
                    Timer1.Stop()
                    Timer2.Stop()
                    Timer3.Stop()
                    Reponse = MsgBox("Erreur d'ouverture de la base Sql server de l'application  " & Chr(13) & "" & Chr(13) & "Modifiez Le Fichier de Configuration", MsgBoxStyle.YesNo, "Connexion à la base Commerciale")
                    If MsgBoxResult.Yes = Reponse Then
                        frmIndex.Show()
                        Me.Close()
                    Else
                        End
                    End If
                End If
            Else
                Timer1.Stop()
                Timer2.Stop()
                Timer3.Stop()
                Reponse = MsgBox("Erreur d'ouverture de la base Sql server de SAGE" & Chr(13) & "" & Chr(13) & "Modifiez Le Fichier de Configuration", MsgBoxStyle.YesNo, "Connexion à la base Commerciale")
                If MsgBoxResult.Yes = Reponse Then
                    frmIndex.Show()
                    Me.Close()
                Else
                    End
                End If
            End If
        Else
            '    Timer1.Stop()
            '    Timer2.Stop()
            '    Timer3.Stop()
            '    Reponse = MsgBox("Erreur d'ouverture de la base Comptable  " & Chr(13) & "" & Chr(13) & "Modifiez Le Fichier de Configuration", MsgBoxStyle.YesNo, "Connexion à la base Commerciale")
            '    If MsgBoxResult.Yes = Reponse Then
            '        frmIndex.Show()
            '        Me.Close()
            '    Else
            '        End
            '    End If
            'End If
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub frmChargement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        Timer2.Enabled = False
        Call LirefichierConfig()
    End Sub
End Class
