Imports System
Imports System.Data
Imports System.Windows.Forms

Public Class frmIndex

#Region "Déclaration des variables "

    Private intNRStyleOuvert As Integer = 1     ' Menu ouvert
    Private intNRStyleAOuvrir As Integer        ' Menu à ouvrir

#End Region

#Region "menu "
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        'Dim NewFrmAjoModChauffeur As New frmAjoModRepParticulier(frmAjoModRepParticulier.lstTypeOuverture.ModeAjouter)
        'NewFrmAjoModChauffeur.MdiParent = Me
        'NewFrmAjoModChauffeur.Show()

    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' A_VOIR_1 : ajoutez le code ici pour ouvrir le fichier.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' A_VOIR_1 : ajoutez le code ici pour enregistrer le contenu actuel du formulaire dans un fichier.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        If (MessageBox.Show("Etes vous sûre de vouloir quitter?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes) Then
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
            End
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilisez My.Computer.Clipboard pour insérer les images ou le texte sélectionné dans le Presse-papiers
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilisez My.Computer.Clipboard pour insérer les images ou le texte sélectionné dans le Presse-papiers
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilisez My.Computer.Clipboard.GetText() ou My.Computer.Clipboard.GetData pour extraire les informations du Presse-papiers.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Fermez tous les formulaires enfants du parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

#End Region

    Private Sub frmIndex_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Paramétrage par défaut
        Me.TableLayoutPanel1.RowStyles(1).SizeType = SizeType.Percent
        Me.TableLayoutPanel1.RowStyles(1).Height = 100
        Me.TableLayoutPanel1.RowStyles(3).SizeType = SizeType.Percent
        Me.TableLayoutPanel1.RowStyles(3).Height = 0
        Me.TableLayoutPanel1.RowStyles(5).SizeType = SizeType.Percent
        Me.TableLayoutPanel1.RowStyles(5).Height = 0
        Me.TableLayoutPanel1.RowStyles(7).SizeType = SizeType.Percent
        Me.TableLayoutPanel1.RowStyles(7).Height = 0
        Me.TableLayoutPanel1.RowStyles(9).SizeType = SizeType.Percent
        Me.TableLayoutPanel1.RowStyles(9).Height = 0

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ' Réduire le menu
        If Me.TableLayoutPanel1.RowStyles(intNRStyleOuvert).Height > 0 Then

            Me.TableLayoutPanel1.RowStyles(intNRStyleOuvert).SizeType = SizeType.Percent
            Me.TableLayoutPanel1.RowStyles(intNRStyleOuvert).Height -= 5

        End If

        ' Augmenter le menu
        If Me.TableLayoutPanel1.RowStyles(intNRStyleAOuvrir).Height < 100 Then

            Me.TableLayoutPanel1.RowStyles(intNRStyleAOuvrir).SizeType = SizeType.Percent
            Me.TableLayoutPanel1.RowStyles(intNRStyleAOuvrir).Height += 5

        End If

        ' Arrêt du cycle
        If Me.TableLayoutPanel1.RowStyles(intNRStyleAOuvrir).Height = 100 Then

            intNRStyleOuvert = intNRStyleAOuvrir
            Me.Timer1.Stop()

        End If

    End Sub

#Region "Menu Véhicule "

    Private Sub btVehicule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVehicule.Click

        If Me.Timer1.Enabled = False Then

            intNRStyleAOuvrir = 1
            Me.Timer1.Start()

            Me.btVehicule.Image = Nothing
            Me.btEntretien.Image = My.Resources.btFlecheHaut32
            Me.btRepertoire.Image = My.Resources.btFlecheHaut32
            Me.btEtat.Image = My.Resources.btFlecheHaut32
            Me.btOption.Image = My.Resources.btFlecheHaut32

        End If

    End Sub

    Private Sub lstvVehicule_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvVehicule.DoubleClick

        ' Récupérer le nom de la sélection, puis ouverture du formulaire
        Select Case Me.lstvVehicule.SelectedItems(0).Text

            Case "Fichier Comptable"
                ContenuSQL.MdiParent = Me
                ContenuSQL.Show()
            Case "Utilisateurs"
                ListesCaissiers.MdiParent = Me
                ListesCaissiers.Show()
            Case "Etape Initial"
                EtapeInitial.MdiParent = Me
                EtapeInitial.Show()
            Case "Etapes de rejet"
                ListesEtarejet.MdiParent = Me
                ListesEtarejet.Show()
            Case "Etapes de validation"
                ListesEtapes.MdiParent = Me
                ListesEtapes.Show()
            Case "Circuits de validation"
                ListesCircuit.MdiParent = Me
                ListesCircuit.Show()
            Case "Nature de Validation"
                NatureValidation.MdiParent = Me
                NatureValidation.Show()
                'Case "Nature de Transaction"
                '    'CreationNaTransac.MdiParent = Me
                '    'CreationNaTransac.Show()
            Case "Catégorie de démandeurs"
                ListesCatDemandeurs.MdiParent = Me
                ListesCatDemandeurs.Show()
            Case "Mails"
                GestionServeurSmtp.MdiParent = Me
                GestionServeurSmtp.Show()
                'Case "Billetage Devise"
                '    'ListesFormatBilletage.MdiParent = Me
                '    'ListesFormatBilletage.Show()
                'Case "Caisses"
                '    'ListesCaisse.MdiParent = Me
                '    'ListesCaisse.Show()
            Case Else

        End Select

    End Sub

#End Region

#Region "Menu Entretien "

    Private Sub btEntretien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEntretien.Click

        If Me.Timer1.Enabled = False Then

            intNRStyleAOuvrir = 3
            Me.Timer1.Start()

            Me.btVehicule.Image = My.Resources.btFlecheBas32
            Me.btEntretien.Image = Nothing
            Me.btRepertoire.Image = My.Resources.btFlecheHaut32
            Me.btEtat.Image = My.Resources.btFlecheHaut32
            Me.btOption.Image = My.Resources.btFlecheHaut32

        End If

    End Sub

    Private Sub lstvEntretien_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvEntretien.DoubleClick
        Select Case Me.lstvEntretien.SelectedItems(0).Text
            Case "Créer un Encaissement"
                'FrNewEC.MdiParent = Me
                'FrNewEC.WindowState = FormWindowState.Normal
                'FrNewEC.StartPosition = FormStartPosition.CenterParent
                'FrNewEC.Show()
            Case "Modifier"
                'frmmodifenc.MdiParent = Me
                'frmmodifenc.WindowState = FormWindowState.Normal
                'frmmodifenc.StartPosition = FormStartPosition.CenterParent
                'frmmodifenc.Show()
            Case "Consultation des encaissements"
                'FRMFINDd.MdiParent = Me
                'FRMFINDd.WindowState = FormWindowState.Normal
                'FRMFINDd.StartPosition = FormStartPosition.CenterParent
                'FRMFINDd.Show()
            Case Else
        End Select
    End Sub
#End Region

#Region "Menu Répertoire "

    Private Sub btRepertoire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRepertoire.Click

        If Me.Timer1.Enabled = False Then

            intNRStyleAOuvrir = 5
            Me.Timer1.Start()

            Me.btVehicule.Image = My.Resources.btFlecheBas32
            Me.btEntretien.Image = My.Resources.btFlecheBas32
            Me.btRepertoire.Image = Nothing
            Me.btEtat.Image = My.Resources.btFlecheHaut32
            Me.btOption.Image = My.Resources.btFlecheHaut32

        End If

    End Sub

    Private Sub lstvRepertoire_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvRepertoire.DoubleClick
        Select Case Me.lstvRepertoire.SelectedItems(0).Text
            Case "Saisie des Décaissements"
                'FRnewDecaissement.MdiParent = Me
                'FRnewDecaissement.Show()
            Case "Consultation des Décaissements"
                'FrmConsultationDecaissement.MdiParent = Me
                'FrmConsultationDecaissement.Show()
            Case "Validation des Décaissements"
                'AssistantValidationDec.MdiParent = Me
                'AssistantValidationDec.Show()
            Case "Journal d'évenement"
                'JourauxEvenement.MdiParent = Me
                'JourauxEvenement.Show()
            Case Else

        End Select

    End Sub

#End Region

#Region "Menu Etat "

    Private Sub btEtat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEtat.Click

        If Me.Timer1.Enabled = False Then

            intNRStyleAOuvrir = 7
            Me.Timer1.Start()

            Me.btVehicule.Image = My.Resources.btFlecheBas32
            Me.btEntretien.Image = My.Resources.btFlecheBas32
            Me.btRepertoire.Image = My.Resources.btFlecheBas32
            Me.btEtat.Image = Nothing
            Me.btOption.Image = My.Resources.btFlecheHaut32

        End If

    End Sub

    Private Sub lstvEtat_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvEtat.DoubleClick

    End Sub

#End Region

#Region "Menu Options "

    Private Sub btOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOption.Click

        If Me.Timer1.Enabled = False Then

            intNRStyleAOuvrir = 9
            Me.Timer1.Start()

            Me.btVehicule.Image = My.Resources.btFlecheBas32
            Me.btEntretien.Image = My.Resources.btFlecheBas32
            Me.btRepertoire.Image = My.Resources.btFlecheBas32
            Me.btEtat.Image = My.Resources.btFlecheBas32
            Me.btOption.Image = Nothing

        End If

    End Sub

    Private Sub lstvOption_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvOption.DoubleClick

    End Sub

#End Region

    Private Sub BarreVerticaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarreVerticaleToolStripMenuItem.Click
        Me.TableLayoutPanel1.Visible = Me.BarreVerticaleToolStripMenuItem.Checked
    End Sub
End Class
