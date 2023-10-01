<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCaissier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCaissier))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TbLibelleCatD = New System.Windows.Forms.TextBox
        Me.tbCodeCatD = New System.Windows.Forms.TextBox
        Me.TxtFonction = New System.Windows.Forms.TextBox
        Me.TXTSERVICE = New System.Windows.Forms.TextBox
        Me.TxtPrenom = New System.Windows.Forms.TextBox
        Me.TXTLOGIN = New System.Windows.Forms.TextBox
        Me.TxtEmail = New System.Windows.Forms.TextBox
        Me.TXTNOM = New System.Windows.Forms.TextBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.DEMANDE_ACHAT.My.Resources.Resources.ExEtranger_frm_BackgroundImage1
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, -11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 263)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(425, 251)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TbLibelleCatD)
        Me.TabPage1.Controls.Add(Me.tbCodeCatD)
        Me.TabPage1.Controls.Add(Me.TxtFonction)
        Me.TabPage1.Controls.Add(Me.TXTSERVICE)
        Me.TabPage1.Controls.Add(Me.TxtPrenom)
        Me.TabPage1.Controls.Add(Me.TXTLOGIN)
        Me.TabPage1.Controls.Add(Me.TxtEmail)
        Me.TabPage1.Controls.Add(Me.TXTNOM)
        Me.TabPage1.Controls.Add(Me.LinkLabel1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(417, 225)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Identification"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TbLibelleCatD
        '
        Me.TbLibelleCatD.Enabled = False
        Me.TbLibelleCatD.Location = New System.Drawing.Point(183, 182)
        Me.TbLibelleCatD.Name = "TbLibelleCatD"
        Me.TbLibelleCatD.Size = New System.Drawing.Size(232, 20)
        Me.TbLibelleCatD.TabIndex = 69
        '
        'tbCodeCatD
        '
        Me.tbCodeCatD.Enabled = False
        Me.tbCodeCatD.Location = New System.Drawing.Point(122, 182)
        Me.tbCodeCatD.Name = "tbCodeCatD"
        Me.tbCodeCatD.Size = New System.Drawing.Size(55, 20)
        Me.tbCodeCatD.TabIndex = 68
        '
        'TxtFonction
        '
        Me.TxtFonction.Location = New System.Drawing.Point(122, 122)
        Me.TxtFonction.Name = "TxtFonction"
        Me.TxtFonction.Size = New System.Drawing.Size(293, 20)
        Me.TxtFonction.TabIndex = 65
        '
        'TXTSERVICE
        '
        Me.TXTSERVICE.Location = New System.Drawing.Point(122, 95)
        Me.TXTSERVICE.Name = "TXTSERVICE"
        Me.TXTSERVICE.Size = New System.Drawing.Size(293, 20)
        Me.TXTSERVICE.TabIndex = 61
        '
        'TxtPrenom
        '
        Me.TxtPrenom.Location = New System.Drawing.Point(122, 33)
        Me.TxtPrenom.Name = "TxtPrenom"
        Me.TxtPrenom.Size = New System.Drawing.Size(293, 20)
        Me.TxtPrenom.TabIndex = 60
        '
        'TXTLOGIN
        '
        Me.TXTLOGIN.Location = New System.Drawing.Point(122, 66)
        Me.TXTLOGIN.Name = "TXTLOGIN"
        Me.TXTLOGIN.Size = New System.Drawing.Size(293, 20)
        Me.TXTLOGIN.TabIndex = 59
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(122, 148)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(293, 20)
        Me.TxtEmail.TabIndex = 58
        '
        'TXTNOM
        '
        Me.TXTNOM.Location = New System.Drawing.Point(122, 7)
        Me.TXTNOM.Name = "TXTNOM"
        Me.TXTNOM.Size = New System.Drawing.Size(293, 20)
        Me.TXTNOM.TabIndex = 3
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(0, 185)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(123, 13)
        Me.LinkLabel1.TabIndex = 67
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Catégorie de demandeur"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Fonction"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Service"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-1, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-1, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prénoms"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(345, 258)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Fermer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmCaissier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DEMANDE_ACHAT.My.Resources.Resources.ExEtranger_frm_BackgroundImage1
        Me.ClientSize = New System.Drawing.Size(422, 285)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCaissier"
        Me.Text = "Utilisateurs"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TbLibelleCatD As System.Windows.Forms.TextBox
    Friend WithEvents tbCodeCatD As System.Windows.Forms.TextBox
    Friend WithEvents TxtFonction As System.Windows.Forms.TextBox
    Friend WithEvents TXTSERVICE As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrenom As System.Windows.Forms.TextBox
    Friend WithEvents TXTLOGIN As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents TXTNOM As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
