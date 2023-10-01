<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegleValidation
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegleValidation))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Intitule = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.LibelleCircuit = New System.Windows.Forms.TextBox
        Me.ComboCircuit = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Devise = New System.Windows.Forms.ComboBox
        Me.montant = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Enreg = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BT_DelRow = New System.Windows.Forms.Button
        Me.BT_ADD = New System.Windows.Forms.Button
        Me.DataListeSchema = New System.Windows.Forms.DataGridView
        Me.EtapeValide = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Signataire = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodeEtape = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Login = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NautoEpo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DataListEtapeCourante = New System.Windows.Forms.DataGridView
        Me.EtapeCourante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IntituleEtapeSuivant = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodeEtapeSuivante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NautoEtapePo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataListeSchema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataListEtapeCourante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Intitule)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LibelleCircuit)
        Me.GroupBox1.Controls.Add(Me.ComboCircuit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Devise)
        Me.GroupBox1.Controls.Add(Me.montant)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Règle de validation"
        '
        'Intitule
        '
        Me.Intitule.Location = New System.Drawing.Point(63, 49)
        Me.Intitule.MaxLength = 70
        Me.Intitule.Name = "Intitule"
        Me.Intitule.Size = New System.Drawing.Size(717, 20)
        Me.Intitule.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Libellé :"
        '
        'LibelleCircuit
        '
        Me.LibelleCircuit.BackColor = System.Drawing.SystemColors.Control
        Me.LibelleCircuit.Enabled = False
        Me.LibelleCircuit.Location = New System.Drawing.Point(474, 22)
        Me.LibelleCircuit.Name = "LibelleCircuit"
        Me.LibelleCircuit.ReadOnly = True
        Me.LibelleCircuit.Size = New System.Drawing.Size(306, 20)
        Me.LibelleCircuit.TabIndex = 12
        '
        'ComboCircuit
        '
        Me.ComboCircuit.BackColor = System.Drawing.SystemColors.Info
        Me.ComboCircuit.FormattingEnabled = True
        Me.ComboCircuit.Location = New System.Drawing.Point(349, 22)
        Me.ComboCircuit.Name = "ComboCircuit"
        Me.ComboCircuit.Size = New System.Drawing.Size(121, 21)
        Me.ComboCircuit.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Circuit de validation :"
        '
        'Devise
        '
        Me.Devise.FormattingEnabled = True
        Me.Devise.Location = New System.Drawing.Point(173, 18)
        Me.Devise.Name = "Devise"
        Me.Devise.Size = New System.Drawing.Size(74, 21)
        Me.Devise.TabIndex = 3
        '
        'montant
        '
        Me.montant.Location = New System.Drawing.Point(63, 18)
        Me.montant.Name = "montant"
        Me.montant.Size = New System.Drawing.Size(107, 20)
        Me.montant.TabIndex = 2
        Me.montant.Text = "0"
        Me.montant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "A partir de :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Enreg)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(786, 376)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Validation par étape"
        '
        'Enreg
        '
        Me.Enreg.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.btn_valider
        Me.Enreg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Enreg.Location = New System.Drawing.Point(701, 349)
        Me.Enreg.Name = "Enreg"
        Me.Enreg.Size = New System.Drawing.Size(79, 23)
        Me.Enreg.TabIndex = 65
        Me.Enreg.Text = "Fermer"
        Me.Enreg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Enreg.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BT_DelRow)
        Me.GroupBox4.Controls.Add(Me.BT_ADD)
        Me.GroupBox4.Controls.Add(Me.DataListeSchema)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(164, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(619, 327)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'BT_DelRow
        '
        Me.BT_DelRow.Enabled = False
        Me.BT_DelRow.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.delete_161
        Me.BT_DelRow.Location = New System.Drawing.Point(37, -2)
        Me.BT_DelRow.Name = "BT_DelRow"
        Me.BT_DelRow.Size = New System.Drawing.Size(23, 20)
        Me.BT_DelRow.TabIndex = 58
        Me.BT_DelRow.UseVisualStyleBackColor = True
        '
        'BT_ADD
        '
        Me.BT_ADD.Image = Global.DEMANDE_ACHAT.My.Resources.Resources.btAjouter22
        Me.BT_ADD.Location = New System.Drawing.Point(9, -2)
        Me.BT_ADD.Name = "BT_ADD"
        Me.BT_ADD.Size = New System.Drawing.Size(24, 20)
        Me.BT_ADD.TabIndex = 57
        Me.BT_ADD.UseVisualStyleBackColor = True
        '
        'DataListeSchema
        '
        Me.DataListeSchema.AllowUserToAddRows = False
        Me.DataListeSchema.AllowUserToDeleteRows = False
        Me.DataListeSchema.AllowUserToOrderColumns = True
        Me.DataListeSchema.AllowUserToResizeRows = False
        Me.DataListeSchema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataListeSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListeSchema.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EtapeValide, Me.Signataire, Me.CodeEtape, Me.Login, Me.NautoEpo})
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
        Me.DataListeSchema.Size = New System.Drawing.Size(613, 308)
        Me.DataListeSchema.TabIndex = 46
        '
        'EtapeValide
        '
        Me.EtapeValide.FillWeight = 101.5228!
        Me.EtapeValide.HeaderText = "Etape Validée"
        Me.EtapeValide.Name = "EtapeValide"
        Me.EtapeValide.ReadOnly = True
        '
        'Signataire
        '
        Me.Signataire.HeaderText = "Signataire"
        Me.Signataire.Name = "Signataire"
        Me.Signataire.ReadOnly = True
        '
        'CodeEtape
        '
        Me.CodeEtape.HeaderText = "CodeEtape"
        Me.CodeEtape.Name = "CodeEtape"
        Me.CodeEtape.Visible = False
        '
        'Login
        '
        Me.Login.HeaderText = "Login"
        Me.Login.Name = "Login"
        Me.Login.Visible = False
        '
        'NautoEpo
        '
        Me.NautoEpo.HeaderText = "NautoEpo"
        Me.NautoEpo.Name = "NautoEpo"
        Me.NautoEpo.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataListEtapeCourante)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(161, 357)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'DataListEtapeCourante
        '
        Me.DataListEtapeCourante.AllowUserToAddRows = False
        Me.DataListEtapeCourante.AllowUserToDeleteRows = False
        Me.DataListEtapeCourante.AllowUserToOrderColumns = True
        Me.DataListEtapeCourante.AllowUserToResizeRows = False
        Me.DataListEtapeCourante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataListEtapeCourante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListEtapeCourante.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EtapeCourante, Me.IntituleEtapeSuivant, Me.CodeEtapeSuivante, Me.NautoEtapePo})
        Me.DataListEtapeCourante.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataListEtapeCourante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataListEtapeCourante.Location = New System.Drawing.Point(3, 16)
        Me.DataListEtapeCourante.MultiSelect = False
        Me.DataListEtapeCourante.Name = "DataListEtapeCourante"
        Me.DataListEtapeCourante.RowHeadersVisible = False
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataListEtapeCourante.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataListEtapeCourante.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataListEtapeCourante.RowTemplate.Height = 24
        Me.DataListEtapeCourante.Size = New System.Drawing.Size(155, 338)
        Me.DataListEtapeCourante.TabIndex = 46
        '
        'EtapeCourante
        '
        Me.EtapeCourante.FillWeight = 101.5228!
        Me.EtapeCourante.HeaderText = "Etapes Courantes"
        Me.EtapeCourante.Name = "EtapeCourante"
        Me.EtapeCourante.ReadOnly = True
        '
        'IntituleEtapeSuivant
        '
        Me.IntituleEtapeSuivant.HeaderText = "IntituleEtapeSuivant"
        Me.IntituleEtapeSuivant.Name = "IntituleEtapeSuivant"
        Me.IntituleEtapeSuivant.Visible = False
        '
        'CodeEtapeSuivante
        '
        Me.CodeEtapeSuivante.HeaderText = "CodeEtapeSuivante"
        Me.CodeEtapeSuivante.Name = "CodeEtapeSuivante"
        Me.CodeEtapeSuivante.Visible = False
        '
        'NautoEtapePo
        '
        Me.NautoEtapePo.HeaderText = "NautoEtapePo"
        Me.NautoEtapePo.Name = "NautoEtapePo"
        Me.NautoEtapePo.Visible = False
        '
        'FrmRegleValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DEMANDE_ACHAT.My.Resources.Resources.ExEtranger_frm_BackgroundImage1
        Me.ClientSize = New System.Drawing.Size(786, 454)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRegleValidation"
        Me.Text = "Règle de validation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataListeSchema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataListEtapeCourante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents montant As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Devise As System.Windows.Forms.ComboBox
    Friend WithEvents ComboCircuit As System.Windows.Forms.ComboBox
    Friend WithEvents LibelleCircuit As System.Windows.Forms.TextBox
    Friend WithEvents Intitule As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataListEtapeCourante As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataListeSchema As System.Windows.Forms.DataGridView
    Friend WithEvents Enreg As System.Windows.Forms.Button
    Friend WithEvents BT_ADD As System.Windows.Forms.Button
    Friend WithEvents BT_DelRow As System.Windows.Forms.Button
    Friend WithEvents EtapeCourante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IntituleEtapeSuivant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeEtapeSuivante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NautoEtapePo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EtapeValide As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Signataire As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeEtape As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Login As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NautoEpo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
