<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionServeurSmtp
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ckSsl = New System.Windows.Forms.CheckBox
        Me.BtTester = New System.Windows.Forms.Button
        Me.BtAnnuler = New System.Windows.Forms.Button
        Me.BtValider = New System.Windows.Forms.Button
        Me.TxtPwdMail = New System.Windows.Forms.TextBox
        Me.TxtUserMail = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtport = New System.Windows.Forms.TextBox
        Me.TxtServeur = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ckSsl)
        Me.GroupBox2.Controls.Add(Me.BtTester)
        Me.GroupBox2.Controls.Add(Me.BtAnnuler)
        Me.GroupBox2.Controls.Add(Me.BtValider)
        Me.GroupBox2.Controls.Add(Me.TxtPwdMail)
        Me.GroupBox2.Controls.Add(Me.TxtUserMail)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtport)
        Me.GroupBox2.Controls.Add(Me.TxtServeur)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(433, 171)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Propriétés du serveur de Messagerie"
        '
        'ckSsl
        '
        Me.ckSsl.AutoSize = True
        Me.ckSsl.Location = New System.Drawing.Point(83, 140)
        Me.ckSsl.Name = "ckSsl"
        Me.ckSsl.Size = New System.Drawing.Size(193, 17)
        Me.ckSsl.TabIndex = 51
        Me.ckSsl.Text = "Utilisez ssl pour chiffre la connexion"
        Me.ckSsl.UseVisualStyleBackColor = True
        '
        'BtTester
        '
        Me.BtTester.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtTester.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.e_mail_enveloppe_icone_9553_32
        Me.BtTester.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtTester.Location = New System.Drawing.Point(343, 77)
        Me.BtTester.Name = "BtTester"
        Me.BtTester.Size = New System.Drawing.Size(77, 28)
        Me.BtTester.TabIndex = 50
        Me.BtTester.Text = "Tester"
        Me.BtTester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtTester.UseVisualStyleBackColor = False
        '
        'BtAnnuler
        '
        Me.BtAnnuler.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAnnuler.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.btFermer32
        Me.BtAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtAnnuler.Location = New System.Drawing.Point(342, 46)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(79, 25)
        Me.BtAnnuler.TabIndex = 49
        Me.BtAnnuler.Text = "Annuler"
        Me.BtAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtAnnuler.UseVisualStyleBackColor = False
        '
        'BtValider
        '
        Me.BtValider.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtValider.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.btn_valider
        Me.BtValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtValider.Location = New System.Drawing.Point(343, 15)
        Me.BtValider.Name = "BtValider"
        Me.BtValider.Size = New System.Drawing.Size(77, 25)
        Me.BtValider.TabIndex = 48
        Me.BtValider.Text = "Valider"
        Me.BtValider.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtValider.UseVisualStyleBackColor = False
        '
        'TxtPwdMail
        '
        Me.TxtPwdMail.Location = New System.Drawing.Point(83, 97)
        Me.TxtPwdMail.Name = "TxtPwdMail"
        Me.TxtPwdMail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(124)
        Me.TxtPwdMail.Size = New System.Drawing.Size(244, 20)
        Me.TxtPwdMail.TabIndex = 11
        '
        'TxtUserMail
        '
        Me.TxtUserMail.Location = New System.Drawing.Point(83, 74)
        Me.TxtUserMail.Name = "TxtUserMail"
        Me.TxtUserMail.Size = New System.Drawing.Size(244, 20)
        Me.TxtUserMail.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Mot de passe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Utilisateur"
        '
        'txtport
        '
        Me.txtport.Location = New System.Drawing.Point(83, 46)
        Me.txtport.Name = "txtport"
        Me.txtport.Size = New System.Drawing.Size(67, 20)
        Me.txtport.TabIndex = 5
        '
        'TxtServeur
        '
        Me.TxtServeur.Location = New System.Drawing.Point(83, 16)
        Me.TxtServeur.Name = "TxtServeur"
        Me.TxtServeur.Size = New System.Drawing.Size(244, 20)
        Me.TxtServeur.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Serveur"
        '
        'GestionServeurSmtp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 172)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GestionServeurSmtp"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Serveurs de messagerie"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtValider As System.Windows.Forms.Button
    Friend WithEvents TxtPwdMail As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserMail As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtport As System.Windows.Forms.TextBox
    Friend WithEvents TxtServeur As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtTester As System.Windows.Forms.Button
    Friend WithEvents BtAnnuler As System.Windows.Forms.Button
    Friend WithEvents ckSsl As System.Windows.Forms.CheckBox
End Class
