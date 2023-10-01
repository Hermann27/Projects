<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContenuSQL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContenuSQL))
        Me.TbServer = New System.Windows.Forms.TextBox
        Me.TbBase = New System.Windows.Forms.TextBox
        Me.TbLogin = New System.Windows.Forms.TextBox
        Me.TbPassword = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TBsoucheDec = New System.Windows.Forms.TextBox
        Me.TbBaseAPPLI = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.BtEnreg = New System.Windows.Forms.Button
        Me.BtClose = New System.Windows.Forms.Button
        Me.FindFile = New System.Windows.Forms.OpenFileDialog
        Me.FindFolder = New System.Windows.Forms.FolderBrowserDialog
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TbCheminCpta = New System.Windows.Forms.TextBox
        Me.UserCpta = New System.Windows.Forms.TextBox
        Me.PwdCpta = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbServer
        '
        Me.TbServer.Location = New System.Drawing.Point(66, 17)
        Me.TbServer.Name = "TbServer"
        Me.TbServer.Size = New System.Drawing.Size(171, 20)
        Me.TbServer.TabIndex = 10
        Me.TbServer.Text = "(Local)"
        '
        'TbBase
        '
        Me.TbBase.Location = New System.Drawing.Point(66, 39)
        Me.TbBase.Name = "TbBase"
        Me.TbBase.Size = New System.Drawing.Size(171, 20)
        Me.TbBase.TabIndex = 11
        Me.TbBase.Text = "Base_Param"
        '
        'TbLogin
        '
        Me.TbLogin.Location = New System.Drawing.Point(339, 14)
        Me.TbLogin.Name = "TbLogin"
        Me.TbLogin.Size = New System.Drawing.Size(144, 20)
        Me.TbLogin.TabIndex = 12
        '
        'TbPassword
        '
        Me.TbPassword.Location = New System.Drawing.Point(339, 38)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(124)
        Me.TbPassword.Size = New System.Drawing.Size(144, 20)
        Me.TbPassword.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Serveur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Base :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "User Sql :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Password :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TBsoucheDec)
        Me.GroupBox1.Controls.Add(Me.TbBaseAPPLI)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TbServer)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TbBase)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TbLogin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TbPassword)
        Me.GroupBox1.Location = New System.Drawing.Point(2, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 91)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chaine de connexion SQL"
        '
        'TBsoucheDec
        '
        Me.TBsoucheDec.Location = New System.Drawing.Point(339, 63)
        Me.TBsoucheDec.Name = "TBsoucheDec"
        Me.TBsoucheDec.Size = New System.Drawing.Size(144, 20)
        Me.TBsoucheDec.TabIndex = 63
        '
        'TbBaseAPPLI
        '
        Me.TbBaseAPPLI.Location = New System.Drawing.Point(66, 64)
        Me.TbBaseAPPLI.Name = "TbBaseAPPLI"
        Me.TbBaseAPPLI.Size = New System.Drawing.Size(171, 20)
        Me.TbBaseAPPLI.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(237, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Souche Demande :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(2, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Application :"
        '
        'BtEnreg
        '
        Me.BtEnreg.Location = New System.Drawing.Point(181, 269)
        Me.BtEnreg.Name = "BtEnreg"
        Me.BtEnreg.Size = New System.Drawing.Size(135, 35)
        Me.BtEnreg.TabIndex = 35
        Me.BtEnreg.Text = "Enregistrer Parametres"
        Me.BtEnreg.UseVisualStyleBackColor = True
        '
        'BtClose
        '
        Me.BtClose.Location = New System.Drawing.Point(350, 269)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(135, 35)
        Me.BtClose.TabIndex = 36
        Me.BtClose.Text = "Quitter"
        Me.BtClose.UseVisualStyleBackColor = True
        '
        'FindFolder
        '
        Me.FindFolder.RootFolder = System.Environment.SpecialFolder.DesktopDirectory
        Me.FindFolder.ShowNewFolderButton = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(-4, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Chemin du Fichier comptable :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(-3, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Utilisateur :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(-3, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Mot de Passe :"
        '
        'TbCheminCpta
        '
        Me.TbCheminCpta.BackColor = System.Drawing.SystemColors.Info
        Me.TbCheminCpta.Location = New System.Drawing.Point(144, 188)
        Me.TbCheminCpta.Name = "TbCheminCpta"
        Me.TbCheminCpta.Size = New System.Drawing.Size(344, 20)
        Me.TbCheminCpta.TabIndex = 59
        '
        'UserCpta
        '
        Me.UserCpta.Location = New System.Drawing.Point(144, 214)
        Me.UserCpta.Name = "UserCpta"
        Me.UserCpta.Size = New System.Drawing.Size(344, 20)
        Me.UserCpta.TabIndex = 60
        '
        'PwdCpta
        '
        Me.PwdCpta.Location = New System.Drawing.Point(144, 239)
        Me.PwdCpta.Name = "PwdCpta"
        Me.PwdCpta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(124)
        Me.PwdCpta.Size = New System.Drawing.Size(344, 20)
        Me.PwdCpta.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(-2, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Chemin du Fichier Gescom :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(144, 107)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(344, 20)
        Me.TextBox1.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(-3, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Mot de Passe :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(-3, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Utilisateur :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(144, 132)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(344, 20)
        Me.TextBox2.TabIndex = 66
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(144, 162)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(124)
        Me.TextBox3.Size = New System.Drawing.Size(343, 20)
        Me.TextBox3.TabIndex = 67
        '
        'ContenuSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DEMANDE_ACHAT.My.Resources.Resources.ExEtranger_frm_BackgroundImage1
        Me.ClientSize = New System.Drawing.Size(497, 316)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PwdCpta)
        Me.Controls.Add(Me.UserCpta)
        Me.Controls.Add(Me.TbCheminCpta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtClose)
        Me.Controls.Add(Me.BtEnreg)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(505, 342)
        Me.MinimumSize = New System.Drawing.Size(505, 342)
        Me.Name = "ContenuSQL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Serveurs,Bases, [Connexion SQL],[Fichier Sage]"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbServer As System.Windows.Forms.TextBox
    Friend WithEvents TbBase As System.Windows.Forms.TextBox
    Friend WithEvents TbLogin As System.Windows.Forms.TextBox
    Friend WithEvents TbPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtEnreg As System.Windows.Forms.Button
    Friend WithEvents BtClose As System.Windows.Forms.Button
    Friend WithEvents FindFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FindFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TbCheminCpta As System.Windows.Forms.TextBox
    Friend WithEvents UserCpta As System.Windows.Forms.TextBox
    Friend WithEvents PwdCpta As System.Windows.Forms.TextBox
    Friend WithEvents TbBaseAPPLI As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TBsoucheDec As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
