<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Lista
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Lista))
        Me.mfg_persona = New AxMSFlexGridLib.AxMSFlexGrid()
        Me.btn_atras = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.lst_ape = New System.Windows.Forms.ListBox()
        Me.lst_fec_nac = New System.Windows.Forms.ListBox()
        Me.lst_est_civ = New System.Windows.Forms.ListBox()
        Me.lst_sex = New System.Windows.Forms.ListBox()
        Me.lst_loc = New System.Windows.Forms.ListBox()
        Me.lst_dom = New System.Windows.Forms.ListBox()
        Me.lst_nom = New System.Windows.Forms.ListBox()
        Me.btn_listas = New System.Windows.Forms.Button()
        Me.btn_grilla = New System.Windows.Forms.Button()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.lbl_ape = New System.Windows.Forms.Label()
        Me.lbl_dom = New System.Windows.Forms.Label()
        Me.lbl_loc = New System.Windows.Forms.Label()
        Me.lbl_sex = New System.Windows.Forms.Label()
        Me.lbl_est_civ = New System.Windows.Forms.Label()
        Me.lbl_fec_nac = New System.Windows.Forms.Label()
        CType(Me.mfg_persona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mfg_persona
        '
        Me.mfg_persona.Location = New System.Drawing.Point(1, 12)
        Me.mfg_persona.Name = "mfg_persona"
        Me.mfg_persona.OcxState = CType(resources.GetObject("mfg_persona.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mfg_persona.Size = New System.Drawing.Size(1001, 354)
        Me.mfg_persona.TabIndex = 0
        '
        'btn_atras
        '
        Me.btn_atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_atras.Location = New System.Drawing.Point(388, 372)
        Me.btn_atras.Name = "btn_atras"
        Me.btn_atras.Size = New System.Drawing.Size(250, 35)
        Me.btn_atras.TabIndex = 1
        Me.btn_atras.Text = "Atras"
        Me.btn_atras.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(12, 372)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(121, 35)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'lst_ape
        '
        Me.lst_ape.FormattingEnabled = True
        Me.lst_ape.Location = New System.Drawing.Point(184, 47)
        Me.lst_ape.Name = "lst_ape"
        Me.lst_ape.Size = New System.Drawing.Size(120, 316)
        Me.lst_ape.TabIndex = 3
        '
        'lst_fec_nac
        '
        Me.lst_fec_nac.FormattingEnabled = True
        Me.lst_fec_nac.Location = New System.Drawing.Point(814, 47)
        Me.lst_fec_nac.Name = "lst_fec_nac"
        Me.lst_fec_nac.Size = New System.Drawing.Size(120, 316)
        Me.lst_fec_nac.TabIndex = 4
        '
        'lst_est_civ
        '
        Me.lst_est_civ.FormattingEnabled = True
        Me.lst_est_civ.Location = New System.Drawing.Point(688, 47)
        Me.lst_est_civ.Name = "lst_est_civ"
        Me.lst_est_civ.Size = New System.Drawing.Size(120, 316)
        Me.lst_est_civ.TabIndex = 5
        '
        'lst_sex
        '
        Me.lst_sex.FormattingEnabled = True
        Me.lst_sex.Location = New System.Drawing.Point(562, 47)
        Me.lst_sex.Name = "lst_sex"
        Me.lst_sex.Size = New System.Drawing.Size(120, 316)
        Me.lst_sex.TabIndex = 6
        '
        'lst_loc
        '
        Me.lst_loc.FormattingEnabled = True
        Me.lst_loc.Location = New System.Drawing.Point(436, 47)
        Me.lst_loc.Name = "lst_loc"
        Me.lst_loc.Size = New System.Drawing.Size(120, 316)
        Me.lst_loc.TabIndex = 7
        '
        'lst_dom
        '
        Me.lst_dom.FormattingEnabled = True
        Me.lst_dom.Location = New System.Drawing.Point(310, 47)
        Me.lst_dom.Name = "lst_dom"
        Me.lst_dom.Size = New System.Drawing.Size(120, 316)
        Me.lst_dom.TabIndex = 8
        '
        'lst_nom
        '
        Me.lst_nom.FormattingEnabled = True
        Me.lst_nom.Location = New System.Drawing.Point(58, 47)
        Me.lst_nom.Name = "lst_nom"
        Me.lst_nom.Size = New System.Drawing.Size(120, 316)
        Me.lst_nom.TabIndex = 9
        '
        'btn_listas
        '
        Me.btn_listas.Location = New System.Drawing.Point(679, 372)
        Me.btn_listas.Name = "btn_listas"
        Me.btn_listas.Size = New System.Drawing.Size(75, 23)
        Me.btn_listas.TabIndex = 10
        Me.btn_listas.Text = "Listas"
        Me.btn_listas.UseVisualStyleBackColor = True
        '
        'btn_grilla
        '
        Me.btn_grilla.Location = New System.Drawing.Point(760, 372)
        Me.btn_grilla.Name = "btn_grilla"
        Me.btn_grilla.Size = New System.Drawing.Size(75, 23)
        Me.btn_grilla.TabIndex = 11
        Me.btn_grilla.Text = "Grilla"
        Me.btn_grilla.UseVisualStyleBackColor = True
        '
        'lbl_nom
        '
        Me.lbl_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom.Location = New System.Drawing.Point(55, 9)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(123, 35)
        Me.lbl_nom.TabIndex = 12
        Me.lbl_nom.Text = "Nombre"
        Me.lbl_nom.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_ape
        '
        Me.lbl_ape.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ape.Location = New System.Drawing.Point(184, 9)
        Me.lbl_ape.Name = "lbl_ape"
        Me.lbl_ape.Size = New System.Drawing.Size(120, 35)
        Me.lbl_ape.TabIndex = 13
        Me.lbl_ape.Text = "Apellido"
        Me.lbl_ape.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_dom
        '
        Me.lbl_dom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dom.Location = New System.Drawing.Point(307, 9)
        Me.lbl_dom.Name = "lbl_dom"
        Me.lbl_dom.Size = New System.Drawing.Size(123, 35)
        Me.lbl_dom.TabIndex = 14
        Me.lbl_dom.Text = "Domicilio"
        Me.lbl_dom.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_loc
        '
        Me.lbl_loc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loc.Location = New System.Drawing.Point(436, 12)
        Me.lbl_loc.Name = "lbl_loc"
        Me.lbl_loc.Size = New System.Drawing.Size(120, 32)
        Me.lbl_loc.TabIndex = 15
        Me.lbl_loc.Text = "Localidad"
        Me.lbl_loc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_sex
        '
        Me.lbl_sex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sex.Location = New System.Drawing.Point(562, 12)
        Me.lbl_sex.Name = "lbl_sex"
        Me.lbl_sex.Size = New System.Drawing.Size(120, 32)
        Me.lbl_sex.TabIndex = 16
        Me.lbl_sex.Text = "Sexo"
        Me.lbl_sex.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_est_civ
        '
        Me.lbl_est_civ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_est_civ.Location = New System.Drawing.Point(685, 12)
        Me.lbl_est_civ.Name = "lbl_est_civ"
        Me.lbl_est_civ.Size = New System.Drawing.Size(123, 32)
        Me.lbl_est_civ.TabIndex = 17
        Me.lbl_est_civ.Text = "Estado Civil"
        Me.lbl_est_civ.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_fec_nac
        '
        Me.lbl_fec_nac.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fec_nac.Location = New System.Drawing.Point(814, 9)
        Me.lbl_fec_nac.Name = "lbl_fec_nac"
        Me.lbl_fec_nac.Size = New System.Drawing.Size(120, 35)
        Me.lbl_fec_nac.TabIndex = 18
        Me.lbl_fec_nac.Text = "Fecha De Nacimiento"
        Me.lbl_fec_nac.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frm_Lista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1009, 414)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_fec_nac)
        Me.Controls.Add(Me.lbl_est_civ)
        Me.Controls.Add(Me.lbl_sex)
        Me.Controls.Add(Me.lbl_loc)
        Me.Controls.Add(Me.lbl_dom)
        Me.Controls.Add(Me.lbl_ape)
        Me.Controls.Add(Me.lbl_nom)
        Me.Controls.Add(Me.btn_grilla)
        Me.Controls.Add(Me.btn_listas)
        Me.Controls.Add(Me.lst_nom)
        Me.Controls.Add(Me.lst_dom)
        Me.Controls.Add(Me.lst_loc)
        Me.Controls.Add(Me.lst_sex)
        Me.Controls.Add(Me.lst_est_civ)
        Me.Controls.Add(Me.lst_fec_nac)
        Me.Controls.Add(Me.lst_ape)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_atras)
        Me.Controls.Add(Me.mfg_persona)
        Me.Name = "Frm_Lista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        CType(Me.mfg_persona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mfg_persona As AxMSFlexGridLib.AxMSFlexGrid
    Friend WithEvents btn_atras As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents lst_ape As System.Windows.Forms.ListBox
    Friend WithEvents lst_fec_nac As System.Windows.Forms.ListBox
    Friend WithEvents lst_est_civ As System.Windows.Forms.ListBox
    Friend WithEvents lst_sex As System.Windows.Forms.ListBox
    Friend WithEvents lst_loc As System.Windows.Forms.ListBox
    Friend WithEvents lst_dom As System.Windows.Forms.ListBox
    Friend WithEvents lst_nom As System.Windows.Forms.ListBox
    Friend WithEvents btn_listas As System.Windows.Forms.Button
    Friend WithEvents btn_grilla As System.Windows.Forms.Button
    Friend WithEvents lbl_nom As System.Windows.Forms.Label
    Friend WithEvents lbl_ape As System.Windows.Forms.Label
    Friend WithEvents lbl_dom As System.Windows.Forms.Label
    Friend WithEvents lbl_loc As System.Windows.Forms.Label
    Friend WithEvents lbl_sex As System.Windows.Forms.Label
    Friend WithEvents lbl_est_civ As System.Windows.Forms.Label
    Friend WithEvents lbl_fec_nac As System.Windows.Forms.Label
End Class
