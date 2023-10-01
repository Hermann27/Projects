<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategorieDemandeurPossible
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategorieDemandeurPossible))
        Me.GrvTraitement = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BSup = New System.Windows.Forms.Button
        Me.BtValider = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CodeNature = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Libelle = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.GrvTraitement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrvTraitement
        '
        Me.GrvTraitement.AllowUserToAddRows = False
        Me.GrvTraitement.AllowUserToDeleteRows = False
        Me.GrvTraitement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrvTraitement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeNature, Me.Libelle})
        Me.GrvTraitement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrvTraitement.Location = New System.Drawing.Point(0, 10)
        Me.GrvTraitement.Name = "GrvTraitement"
        Me.GrvTraitement.RowHeadersVisible = False
        Me.GrvTraitement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrvTraitement.Size = New System.Drawing.Size(403, 286)
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
        Me.Panel1.Size = New System.Drawing.Size(403, 35)
        Me.Panel1.TabIndex = 1
        '
        'BSup
        '
        Me.BSup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BSup.Location = New System.Drawing.Point(192, 3)
        Me.BSup.Name = "BSup"
        Me.BSup.Size = New System.Drawing.Size(82, 26)
        Me.BSup.TabIndex = 2
        Me.BSup.Text = "Fermer"
        Me.BSup.UseVisualStyleBackColor = True
        '
        'BtValider
        '
        Me.BtValider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtValider.Location = New System.Drawing.Point(82, 3)
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
        Me.Panel2.Size = New System.Drawing.Size(403, 10)
        Me.Panel2.TabIndex = 2
        '
        'CodeNature
        '
        Me.CodeNature.FillWeight = 300.0!
        Me.CodeNature.HeaderText = "Code Nature"
        Me.CodeNature.Name = "CodeNature"
        Me.CodeNature.ReadOnly = True
        '
        'Libelle
        '
        Me.Libelle.FillWeight = 50.0!
        Me.Libelle.HeaderText = "Libelle Nature "
        Me.Libelle.Name = "Libelle"
        Me.Libelle.ReadOnly = True
        Me.Libelle.Width = 300
        '
        'CategorieDemandeurPossible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 331)
        Me.Controls.Add(Me.GrvTraitement)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CategorieDemandeurPossible"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Catégories de demandeurs"
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
    Friend WithEvents CodeNature As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Libelle As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
