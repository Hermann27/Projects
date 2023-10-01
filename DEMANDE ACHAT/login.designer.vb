<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.annuler = New System.Windows.Forms.Button
        Me.valider = New System.Windows.Forms.Button
        Me.CPwd = New System.Windows.Forms.TextBox
        Me.CLogin = New System.Windows.Forms.TextBox
        Me.Line1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Image2 = New System.Windows.Forms.PictureBox
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'annuler
        '
        Me.annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.annuler.Cursor = System.Windows.Forms.Cursors.Default
        Me.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.annuler.ForeColor = System.Drawing.SystemColors.ControlText
        Me.annuler.Location = New System.Drawing.Point(190, 232)
        Me.annuler.Name = "annuler"
        Me.annuler.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.annuler.Size = New System.Drawing.Size(73, 22)
        Me.annuler.TabIndex = 15
        Me.annuler.Text = "Annuler"
        Me.annuler.UseVisualStyleBackColor = False
        '
        'valider
        '
        Me.valider.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.valider.Cursor = System.Windows.Forms.Cursors.Default
        Me.valider.ForeColor = System.Drawing.SystemColors.ControlText
        Me.valider.Location = New System.Drawing.Point(322, 232)
        Me.valider.Name = "valider"
        Me.valider.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.valider.Size = New System.Drawing.Size(73, 22)
        Me.valider.TabIndex = 14
        Me.valider.Text = "Valider"
        Me.valider.UseVisualStyleBackColor = False
        '
        'CPwd
        '
        Me.CPwd.AcceptsReturn = True
        Me.CPwd.BackColor = System.Drawing.SystemColors.Window
        Me.CPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CPwd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CPwd.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.CPwd.Location = New System.Drawing.Point(163, 174)
        Me.CPwd.MaxLength = 0
        Me.CPwd.Name = "CPwd"
        Me.CPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CPwd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CPwd.Size = New System.Drawing.Size(235, 20)
        Me.CPwd.TabIndex = 13
        '
        'CLogin
        '
        Me.CLogin.AcceptsReturn = True
        Me.CLogin.BackColor = System.Drawing.SystemColors.Window
        Me.CLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CLogin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CLogin.Location = New System.Drawing.Point(163, 140)
        Me.CLogin.MaxLength = 0
        Me.CLogin.Name = "CLogin"
        Me.CLogin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CLogin.Size = New System.Drawing.Size(235, 20)
        Me.CLogin.TabIndex = 11
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Line1.Location = New System.Drawing.Point(1, 206)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(430, 2)
        Me.Line1.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(2, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Mot de passe"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(2, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Tag = "    "
        Me.Label1.Text = " Utilisateur"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(101, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(300, 42)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "WAZA SOLUTIONS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CENTRE DE COMPLETENCE SAGE"
        '
        'Image2
        '
        Me.Image2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Image2.Image = CType(resources.GetObject("Image2.Image"), System.Drawing.Image)
        Me.Image2.Location = New System.Drawing.Point(1, 0)
        Me.Image2.Name = "Image2"
        Me.Image2.Size = New System.Drawing.Size(400, 102)
        Me.Image2.TabIndex = 16
        Me.Image2.TabStop = False
        '
        'login
        '
        Me.AcceptButton = Me.valider
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CancelButton = Me.annuler
        Me.ClientSize = New System.Drawing.Size(401, 258)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.annuler)
        Me.Controls.Add(Me.valider)
        Me.Controls.Add(Me.CPwd)
        Me.Controls.Add(Me.CLogin)
        Me.Controls.Add(Me.Image2)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ouverture d'une session"
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents annuler As System.Windows.Forms.Button
    Public WithEvents valider As System.Windows.Forms.Button
    Public WithEvents CPwd As System.Windows.Forms.TextBox
    Public WithEvents CLogin As System.Windows.Forms.TextBox
    Public WithEvents Image2 As System.Windows.Forms.PictureBox
    Public WithEvents Line1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
End Class
