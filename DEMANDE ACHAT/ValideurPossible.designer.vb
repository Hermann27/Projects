<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValideurPossible
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ValideurPossible))
        Me.GrvTraitement = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BSup = New System.Windows.Forms.Button
        Me.BtValider = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.NomPrenom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fonction = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Login = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.GrvTraitement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrvTraitement
        '
        Me.GrvTraitement.AllowUserToAddRows = False
        Me.GrvTraitement.AllowUserToDeleteRows = False
        Me.GrvTraitement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrvTraitement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomPrenom, Me.Fonction, Me.Login})
        Me.GrvTraitement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrvTraitement.Location = New System.Drawing.Point(0, 10)
        Me.GrvTraitement.Name = "GrvTraitement"
        Me.GrvTraitement.RowHeadersVisible = False
        Me.GrvTraitement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrvTraitement.Size = New System.Drawing.Size(354, 286)
        Me.GrvTraitement.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BSup)
        Me.Panel1.Controls.Add(Me.BtValider)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 296)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 35)
        Me.Panel1.TabIndex = 1
        '
        'BSup
        '
        Me.BSup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BSup.Location = New System.Drawing.Point(224, 6)
        Me.BSup.Name = "BSup"
        Me.BSup.Size = New System.Drawing.Size(82, 26)
        Me.BSup.TabIndex = 2
        Me.BSup.Text = "Fermer"
        Me.BSup.UseVisualStyleBackColor = True
        '
        'BtValider
        '
        Me.BtValider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtValider.Location = New System.Drawing.Point(116, 6)
        Me.BtValider.Name = "BtValider"
        Me.BtValider.Size = New System.Drawing.Size(82, 26)
        Me.BtValider.TabIndex = 1
        Me.BtValider.Text = "Valider"
        Me.BtValider.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(411, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(354, 10)
        Me.Panel2.TabIndex = 2
        '
        'NomPrenom
        '
        Me.NomPrenom.FillWeight = 300.0!
        Me.NomPrenom.HeaderText = "Nom / Prénom"
        Me.NomPrenom.Name = "NomPrenom"
        Me.NomPrenom.Width = 150
        '
        'Fonction
        '
        Me.Fonction.FillWeight = 50.0!
        Me.Fonction.HeaderText = "Fonction"
        Me.Fonction.Name = "Fonction"
        Me.Fonction.Width = 200
        '
        'Login
        '
        Me.Login.HeaderText = "Login"
        Me.Login.Name = "Login"
        Me.Login.Visible = False
        '
        'ValideurPossible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 331)
        Me.Controls.Add(Me.GrvTraitement)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ValideurPossible"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Traitement Des valideurs possibles"
        CType(Me.GrvTraitement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrvTraitement As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtValider As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BSup As System.Windows.Forms.Button
    Friend WithEvents NomPrenom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fonction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Login As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
