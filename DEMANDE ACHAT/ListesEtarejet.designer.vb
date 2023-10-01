<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListesEtarejet
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListesEtarejet))
        Me.DataListeSchema = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtFermer = New System.Windows.Forms.Button
        Me.BtSupprimer = New System.Windows.Forms.Button
        Me.BtNouveau = New System.Windows.Forms.Button
        Me.Btouvrir = New System.Windows.Forms.Button
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Libelle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Definitif = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.DataListeSchema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataListeSchema
        '
        Me.DataListeSchema.AllowUserToAddRows = False
        Me.DataListeSchema.AllowUserToDeleteRows = False
        Me.DataListeSchema.AllowUserToOrderColumns = True
        Me.DataListeSchema.AllowUserToResizeRows = False
        Me.DataListeSchema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataListeSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListeSchema.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.Libelle, Me.Definitif})
        Me.DataListeSchema.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataListeSchema.Location = New System.Drawing.Point(3, 19)
        Me.DataListeSchema.MultiSelect = False
        Me.DataListeSchema.Name = "DataListeSchema"
        Me.DataListeSchema.RowHeadersVisible = False
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataListeSchema.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataListeSchema.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataListeSchema.RowTemplate.Height = 24
        Me.DataListeSchema.Size = New System.Drawing.Size(570, 272)
        Me.DataListeSchema.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataListeSchema)
        Me.GroupBox1.Location = New System.Drawing.Point(-3, -16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 294)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'BtFermer
        '
        Me.BtFermer.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.quitter
        Me.BtFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtFermer.Location = New System.Drawing.Point(404, 284)
        Me.BtFermer.Name = "BtFermer"
        Me.BtFermer.Size = New System.Drawing.Size(111, 23)
        Me.BtFermer.TabIndex = 50
        Me.BtFermer.Text = "Fermer"
        Me.BtFermer.UseVisualStyleBackColor = True
        '
        'BtSupprimer
        '
        Me.BtSupprimer.Enabled = False
        Me.BtSupprimer.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.btSupprimer22
        Me.BtSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtSupprimer.Location = New System.Drawing.Point(298, 284)
        Me.BtSupprimer.Name = "BtSupprimer"
        Me.BtSupprimer.Size = New System.Drawing.Size(90, 23)
        Me.BtSupprimer.TabIndex = 49
        Me.BtSupprimer.Text = "Supprimer"
        Me.BtSupprimer.UseVisualStyleBackColor = True
        '
        'BtNouveau
        '
        Me.BtNouveau.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.edit_bleu
        Me.BtNouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtNouveau.Location = New System.Drawing.Point(168, 284)
        Me.BtNouveau.Name = "BtNouveau"
        Me.BtNouveau.Size = New System.Drawing.Size(115, 23)
        Me.BtNouveau.TabIndex = 48
        Me.BtNouveau.Text = "Nouveau"
        Me.BtNouveau.UseVisualStyleBackColor = True
        '
        'Btouvrir
        '
        Me.Btouvrir.Enabled = False
        Me.Btouvrir.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.btRepertoireA22
        Me.Btouvrir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btouvrir.Location = New System.Drawing.Point(58, 284)
        Me.Btouvrir.Name = "Btouvrir"
        Me.Btouvrir.Size = New System.Drawing.Size(104, 23)
        Me.Btouvrir.TabIndex = 47
        Me.Btouvrir.Text = "Ouvrir"
        Me.Btouvrir.UseVisualStyleBackColor = True
        '
        'Code
        '
        Me.Code.HeaderText = "Code "
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        Me.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Libelle
        '
        Me.Libelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Format = "N0"
        Me.Libelle.DefaultCellStyle = DataGridViewCellStyle1
        Me.Libelle.HeaderText = "Libellé"
        Me.Libelle.Name = "Libelle"
        Me.Libelle.ReadOnly = True
        Me.Libelle.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Libelle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Libelle.Width = 350
        '
        'Definitif
        '
        Me.Definitif.HeaderText = "Definitif"
        Me.Definitif.Name = "Definitif"
        Me.Definitif.ReadOnly = True
        Me.Definitif.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ListesEtarejet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 313)
        Me.Controls.Add(Me.BtFermer)
        Me.Controls.Add(Me.BtSupprimer)
        Me.Controls.Add(Me.BtNouveau)
        Me.Controls.Add(Me.Btouvrir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListesEtarejet"
        Me.Text = "Etapes de rejet"
        CType(Me.DataListeSchema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataListeSchema As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btouvrir As System.Windows.Forms.Button
    Friend WithEvents BtNouveau As System.Windows.Forms.Button
    Friend WithEvents BtSupprimer As System.Windows.Forms.Button
    Friend WithEvents BtFermer As System.Windows.Forms.Button
    Friend WithEvents Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Libelle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Definitif As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
