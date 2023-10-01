<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NatureValidation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NatureValidation))
        Me.LibelleCombo = New System.Windows.Forms.TextBox
        Me.DataListeIntegrer = New System.Windows.Forms.DataGridView
        Me.Apartirde = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RegleValidation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NoAuto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BT_ADD = New System.Windows.Forms.Button
        Me.BT_DelRow = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboNatureVa = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.DataListeIntegrer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LibelleCombo
        '
        Me.LibelleCombo.BackColor = System.Drawing.SystemColors.Info
        Me.LibelleCombo.Enabled = False
        Me.LibelleCombo.Location = New System.Drawing.Point(282, 16)
        Me.LibelleCombo.Name = "LibelleCombo"
        Me.LibelleCombo.ReadOnly = True
        Me.LibelleCombo.Size = New System.Drawing.Size(388, 20)
        Me.LibelleCombo.TabIndex = 49
        '
        'DataListeIntegrer
        '
        Me.DataListeIntegrer.AllowUserToAddRows = False
        Me.DataListeIntegrer.AllowUserToDeleteRows = False
        Me.DataListeIntegrer.AllowUserToOrderColumns = True
        Me.DataListeIntegrer.AllowUserToResizeRows = False
        Me.DataListeIntegrer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataListeIntegrer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListeIntegrer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Apartirde, Me.RegleValidation, Me.NoAuto})
        Me.DataListeIntegrer.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataListeIntegrer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataListeIntegrer.Location = New System.Drawing.Point(3, 37)
        Me.DataListeIntegrer.MultiSelect = False
        Me.DataListeIntegrer.Name = "DataListeIntegrer"
        Me.DataListeIntegrer.RowHeadersVisible = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataListeIntegrer.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataListeIntegrer.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataListeIntegrer.RowTemplate.Height = 24
        Me.DataListeIntegrer.Size = New System.Drawing.Size(709, 271)
        Me.DataListeIntegrer.TabIndex = 50
        '
        'Apartirde
        '
        Me.Apartirde.FillWeight = 45.65112!
        Me.Apartirde.HeaderText = "A partir de"
        Me.Apartirde.Name = "Apartirde"
        Me.Apartirde.ReadOnly = True
        Me.Apartirde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'RegleValidation
        '
        Me.RegleValidation.FillWeight = 145.695!
        Me.RegleValidation.HeaderText = "Règle de validation"
        Me.RegleValidation.Name = "RegleValidation"
        Me.RegleValidation.ReadOnly = True
        Me.RegleValidation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'NoAuto
        '
        Me.NoAuto.HeaderText = "NoAuto"
        Me.NoAuto.Name = "NoAuto"
        Me.NoAuto.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BT_ADD)
        Me.GroupBox1.Controls.Add(Me.DataListeIntegrer)
        Me.GroupBox1.Controls.Add(Me.BT_DelRow)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(715, 311)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Règle de validation général"
        '
        'Button1
        '
        Me.Button1.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.edit_bleu
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(106, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Modifier"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BT_ADD
        '
        Me.BT_ADD.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.btAjouter222
        Me.BT_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BT_ADD.Location = New System.Drawing.Point(37, 15)
        Me.BT_ADD.Name = "BT_ADD"
        Me.BT_ADD.Size = New System.Drawing.Size(68, 20)
        Me.BT_ADD.TabIndex = 56
        Me.BT_ADD.Text = "Créer"
        Me.BT_ADD.UseVisualStyleBackColor = True
        '
        'BT_DelRow
        '
        Me.BT_DelRow.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.delete_161
        Me.BT_DelRow.Location = New System.Drawing.Point(8, 15)
        Me.BT_DelRow.Name = "BT_DelRow"
        Me.BT_DelRow.Size = New System.Drawing.Size(23, 20)
        Me.BT_DelRow.TabIndex = 55
        Me.BT_DelRow.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(239, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Libellé "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(65, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Code "
        '
        'ComboNatureVa
        '
        Me.ComboNatureVa.AutoCompleteCustomSource.AddRange(New String() {""})
        Me.ComboNatureVa.BackColor = System.Drawing.SystemColors.Info
        Me.ComboNatureVa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboNatureVa.FormattingEnabled = True
        Me.ComboNatureVa.Location = New System.Drawing.Point(106, 15)
        Me.ComboNatureVa.Name = "ComboNatureVa"
        Me.ComboNatureVa.Size = New System.Drawing.Size(127, 21)
        Me.ComboNatureVa.TabIndex = 68
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ComboNatureVa)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.LibelleCombo)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(710, 42)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Creation Catégorie Demandeur"
        '
        'NatureValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DEMANDE_ACHAT.My.Resources.Resources.ExEtranger_frm_BackgroundImage1
        Me.ClientSize = New System.Drawing.Size(712, 399)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NatureValidation"
        Me.Text = " Nature Validation par catégorie de demandeurs"
        CType(Me.DataListeIntegrer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LibelleCombo As System.Windows.Forms.TextBox
    Friend WithEvents DataListeIntegrer As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BT_DelRow As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BT_ADD As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboNatureVa As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Apartirde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegleValidation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoAuto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
