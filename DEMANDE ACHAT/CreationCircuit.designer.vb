<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreationCircuit
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreationCircuit))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCodeCir = New System.Windows.Forms.TextBox
        Me.TxtLibelleCir = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CodeIni = New System.Windows.Forms.TextBox
        Me.LibelleIni = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboEtapefin = New System.Windows.Forms.ComboBox
        Me.TxtLibelleFinal = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataListeSchema = New System.Windows.Forms.DataGridView
        Me.Ordre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EtapeCourante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LibelleEtapeCourante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EtapeSuivante = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.LibelleEtapeSuivante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BT_DelRow = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataListeSchema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Circuit :"
        '
        'TxtCodeCir
        '
        Me.TxtCodeCir.BackColor = System.Drawing.SystemColors.Info
        Me.TxtCodeCir.Location = New System.Drawing.Point(85, 42)
        Me.TxtCodeCir.MaxLength = 8
        Me.TxtCodeCir.Name = "TxtCodeCir"
        Me.TxtCodeCir.Size = New System.Drawing.Size(119, 20)
        Me.TxtCodeCir.TabIndex = 1
        '
        'TxtLibelleCir
        '
        Me.TxtLibelleCir.BackColor = System.Drawing.SystemColors.Info
        Me.TxtLibelleCir.Location = New System.Drawing.Point(210, 42)
        Me.TxtLibelleCir.MaxLength = 35
        Me.TxtLibelleCir.Name = "TxtLibelleCir"
        Me.TxtLibelleCir.Size = New System.Drawing.Size(324, 20)
        Me.TxtLibelleCir.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(11, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Etape Initial :"
        '
        'CodeIni
        '
        Me.CodeIni.BackColor = System.Drawing.SystemColors.Control
        Me.CodeIni.Enabled = False
        Me.CodeIni.Location = New System.Drawing.Point(85, 71)
        Me.CodeIni.Name = "CodeIni"
        Me.CodeIni.ReadOnly = True
        Me.CodeIni.Size = New System.Drawing.Size(119, 20)
        Me.CodeIni.TabIndex = 7
        '
        'LibelleIni
        '
        Me.LibelleIni.BackColor = System.Drawing.SystemColors.Control
        Me.LibelleIni.Enabled = False
        Me.LibelleIni.Location = New System.Drawing.Point(210, 71)
        Me.LibelleIni.Name = "LibelleIni"
        Me.LibelleIni.ReadOnly = True
        Me.LibelleIni.Size = New System.Drawing.Size(324, 20)
        Me.LibelleIni.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(12, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Etape Final :"
        '
        'ComboEtapefin
        '
        Me.ComboEtapefin.BackColor = System.Drawing.SystemColors.Info
        Me.ComboEtapefin.FormattingEnabled = True
        Me.ComboEtapefin.Location = New System.Drawing.Point(85, 105)
        Me.ComboEtapefin.Name = "ComboEtapefin"
        Me.ComboEtapefin.Size = New System.Drawing.Size(121, 21)
        Me.ComboEtapefin.TabIndex = 10
        '
        'TxtLibelleFinal
        '
        Me.TxtLibelleFinal.BackColor = System.Drawing.SystemColors.Control
        Me.TxtLibelleFinal.Location = New System.Drawing.Point(210, 105)
        Me.TxtLibelleFinal.Name = "TxtLibelleFinal"
        Me.TxtLibelleFinal.ReadOnly = True
        Me.TxtLibelleFinal.Size = New System.Drawing.Size(324, 20)
        Me.TxtLibelleFinal.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataListeSchema)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 207)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Etapes du circuit"
        '
        'DataListeSchema
        '
        Me.DataListeSchema.AllowUserToAddRows = False
        Me.DataListeSchema.AllowUserToDeleteRows = False
        Me.DataListeSchema.AllowUserToOrderColumns = True
        Me.DataListeSchema.AllowUserToResizeRows = False
        Me.DataListeSchema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataListeSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListeSchema.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ordre, Me.EtapeCourante, Me.LibelleEtapeCourante, Me.EtapeSuivante, Me.LibelleEtapeSuivante, Me.fin})
        Me.DataListeSchema.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataListeSchema.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataListeSchema.Location = New System.Drawing.Point(3, 16)
        Me.DataListeSchema.MultiSelect = False
        Me.DataListeSchema.Name = "DataListeSchema"
        Me.DataListeSchema.RowHeadersVisible = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataListeSchema.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataListeSchema.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataListeSchema.RowTemplate.Height = 24
        Me.DataListeSchema.Size = New System.Drawing.Size(758, 188)
        Me.DataListeSchema.TabIndex = 45
        '
        'Ordre
        '
        Me.Ordre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Ordre.FillWeight = 28.53964!
        Me.Ordre.Frozen = True
        Me.Ordre.HeaderText = "Ordre"
        Me.Ordre.Name = "Ordre"
        Me.Ordre.ReadOnly = True
        Me.Ordre.Width = 43
        '
        'EtapeCourante
        '
        Me.EtapeCourante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.EtapeCourante.FillWeight = 101.5228!
        Me.EtapeCourante.Frozen = True
        Me.EtapeCourante.HeaderText = "Etape Courante"
        Me.EtapeCourante.Name = "EtapeCourante"
        Me.EtapeCourante.ReadOnly = True
        Me.EtapeCourante.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.EtapeCourante.Width = 153
        '
        'LibelleEtapeCourante
        '
        Me.LibelleEtapeCourante.FillWeight = 133.4228!
        Me.LibelleEtapeCourante.HeaderText = "Libelle Etape Courante"
        Me.LibelleEtapeCourante.Name = "LibelleEtapeCourante"
        Me.LibelleEtapeCourante.ReadOnly = True
        Me.LibelleEtapeCourante.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'EtapeSuivante
        '
        Me.EtapeSuivante.FillWeight = 103.0919!
        Me.EtapeSuivante.HeaderText = "Etape Suivante"
        Me.EtapeSuivante.Name = "EtapeSuivante"
        Me.EtapeSuivante.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'LibelleEtapeSuivante
        '
        Me.LibelleEtapeSuivante.FillWeight = 133.4228!
        Me.LibelleEtapeSuivante.HeaderText = "Libelle Etape Suivante"
        Me.LibelleEtapeSuivante.Name = "LibelleEtapeSuivante"
        Me.LibelleEtapeSuivante.ReadOnly = True
        Me.LibelleEtapeSuivante.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'fin
        '
        Me.fin.HeaderText = "fin"
        Me.fin.Name = "fin"
        Me.fin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fin.Visible = False
        '
        'BT_DelRow
        '
        Me.BT_DelRow.BackgroundImage = Global.DEMANDE_ACHAT.My.Resources.Resources.btSupprimer22
        Me.BT_DelRow.Location = New System.Drawing.Point(738, 129)
        Me.BT_DelRow.Name = "BT_DelRow"
        Me.BT_DelRow.Size = New System.Drawing.Size(23, 20)
        Me.BT_DelRow.TabIndex = 13
        Me.BT_DelRow.UseVisualStyleBackColor = True
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
        'Button2
        '
        Me.Button2.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.delete_161
        Me.Button2.Location = New System.Drawing.Point(47, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = True
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
        'CreationCircuit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 348)
        Me.Controls.Add(Me.BT_DelRow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtLibelleFinal)
        Me.Controls.Add(Me.ComboEtapefin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LibelleIni)
        Me.Controls.Add(Me.CodeIni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtLibelleCir)
        Me.Controls.Add(Me.TxtCodeCir)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreationCircuit"
        Me.Text = "Création Circuit de validation"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataListeSchema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCodeCir As System.Windows.Forms.TextBox
    Friend WithEvents TxtLibelleCir As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodeIni As System.Windows.Forms.TextBox
    Friend WithEvents LibelleIni As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboEtapefin As System.Windows.Forms.ComboBox
    Friend WithEvents TxtLibelleFinal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataListeSchema As System.Windows.Forms.DataGridView
    Friend WithEvents BT_DelRow As System.Windows.Forms.Button
    Friend WithEvents Ordre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EtapeCourante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibelleEtapeCourante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EtapeSuivante As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents LibelleEtapeSuivante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fin As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
