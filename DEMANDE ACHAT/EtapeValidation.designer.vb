<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtapeValidation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EtapeValidation))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCodeIni = New System.Windows.Forms.TextBox
        Me.TxtLibelleIni = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Etape de validation"
        '
        'TxtCodeIni
        '
        Me.TxtCodeIni.BackColor = System.Drawing.SystemColors.Info
        Me.TxtCodeIni.Location = New System.Drawing.Point(116, 40)
        Me.TxtCodeIni.Name = "TxtCodeIni"
        Me.TxtCodeIni.Size = New System.Drawing.Size(119, 20)
        Me.TxtCodeIni.TabIndex = 1
        '
        'TxtLibelleIni
        '
        Me.TxtLibelleIni.BackColor = System.Drawing.SystemColors.Info
        Me.TxtLibelleIni.Location = New System.Drawing.Point(235, 40)
        Me.TxtLibelleIni.Name = "TxtLibelleIni"
        Me.TxtLibelleIni.Size = New System.Drawing.Size(293, 20)
        Me.TxtLibelleIni.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.btn_valider
        Me.Button1.Location = New System.Drawing.Point(-1, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.btSupprimer22
        Me.Button2.Location = New System.Drawing.Point(47, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.save_16
        Me.Button3.Location = New System.Drawing.Point(94, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = True
        '
        'EtapeValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 68)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtLibelleIni)
        Me.Controls.Add(Me.TxtCodeIni)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EtapeValidation"
        Me.Text = "Etape de validation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCodeIni As System.Windows.Forms.TextBox
    Friend WithEvents TxtLibelleIni As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
