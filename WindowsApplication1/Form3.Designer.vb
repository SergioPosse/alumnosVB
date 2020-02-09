<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Registro
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
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_domicilio = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.fecha_nac = New System.Windows.Forms.MonthCalendar()
        Me.cbo_loc = New System.Windows.Forms.ComboBox()
        Me.rdb_casado = New System.Windows.Forms.RadioButton()
        Me.rdb_soltero = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.grb_sex = New System.Windows.Forms.GroupBox()
        Me.rdb_femenino = New System.Windows.Forms.RadioButton()
        Me.rdb_masculino = New System.Windows.Forms.RadioButton()
        Me.grb_est_civ = New System.Windows.Forms.GroupBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.grb_sex.SuspendLayout()
        Me.grb_est_civ.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(114, 53)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(116, 20)
        Me.txt_apellido.TabIndex = 1
        '
        'txt_domicilio
        '
        Me.txt_domicilio.Location = New System.Drawing.Point(114, 92)
        Me.txt_domicilio.Name = "txt_domicilio"
        Me.txt_domicilio.Size = New System.Drawing.Size(116, 20)
        Me.txt_domicilio.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(114, 14)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(116, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'fecha_nac
        '
        Me.fecha_nac.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.fecha_nac.Location = New System.Drawing.Point(19, 267)
        Me.fecha_nac.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.fecha_nac.MaxDate = New Date(2012, 3, 1, 0, 0, 0, 0)
        Me.fecha_nac.MinDate = New Date(1910, 1, 1, 0, 0, 0, 0)
        Me.fecha_nac.Name = "fecha_nac"
        Me.fecha_nac.ShowToday = False
        Me.fecha_nac.ShowTodayCircle = False
        Me.fecha_nac.TabIndex = 6
        Me.fecha_nac.Visible = False
        '
        'cbo_loc
        '
        Me.cbo_loc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_loc.FormattingEnabled = True
        Me.cbo_loc.Items.AddRange(New Object() {"Rio Cuarto", "Rosario", "Cordoba", "Berrotaran"})
        Me.cbo_loc.Location = New System.Drawing.Point(114, 129)
        Me.cbo_loc.Name = "cbo_loc"
        Me.cbo_loc.Size = New System.Drawing.Size(116, 21)
        Me.cbo_loc.TabIndex = 3
        '
        'rdb_casado
        '
        Me.rdb_casado.AutoSize = True
        Me.rdb_casado.Location = New System.Drawing.Point(6, 19)
        Me.rdb_casado.Name = "rdb_casado"
        Me.rdb_casado.Size = New System.Drawing.Size(72, 17)
        Me.rdb_casado.TabIndex = 1
        Me.rdb_casado.TabStop = True
        Me.rdb_casado.Text = "Casado/a"
        Me.rdb_casado.UseVisualStyleBackColor = True
        '
        'rdb_soltero
        '
        Me.rdb_soltero.AutoSize = True
        Me.rdb_soltero.Location = New System.Drawing.Point(6, 41)
        Me.rdb_soltero.Name = "rdb_soltero"
        Me.rdb_soltero.Size = New System.Drawing.Size(69, 17)
        Me.rdb_soltero.TabIndex = 0
        Me.rdb_soltero.TabStop = True
        Me.rdb_soltero.Text = "Soltero/a"
        Me.rdb_soltero.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Localidad"
        '
        'btn_registrar
        '
        Me.btn_registrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_registrar.Enabled = False
        Me.btn_registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registrar.Location = New System.Drawing.Point(16, 438)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(104, 31)
        Me.btn_registrar.TabIndex = 10
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = False
        '
        'txt_fecha
        '
        Me.txt_fecha.Enabled = False
        Me.txt_fecha.Location = New System.Drawing.Point(114, 235)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(116, 20)
        Me.txt_fecha.TabIndex = 13
        Me.txt_fecha.Visible = False
        '
        'lbl_fecha
        '
        Me.lbl_fecha.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fecha.Location = New System.Drawing.Point(24, 228)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(88, 36)
        Me.lbl_fecha.TabIndex = 14
        Me.lbl_fecha.Text = "Fecha De Nacimiento"
        Me.lbl_fecha.Visible = False
        '
        'grb_sex
        '
        Me.grb_sex.Controls.Add(Me.rdb_femenino)
        Me.grb_sex.Controls.Add(Me.rdb_masculino)
        Me.grb_sex.Location = New System.Drawing.Point(24, 156)
        Me.grb_sex.Name = "grb_sex"
        Me.grb_sex.Size = New System.Drawing.Size(105, 64)
        Me.grb_sex.TabIndex = 4
        Me.grb_sex.TabStop = False
        Me.grb_sex.Text = "Sexo"
        Me.grb_sex.Visible = False
        '
        'rdb_femenino
        '
        Me.rdb_femenino.AutoSize = True
        Me.rdb_femenino.Location = New System.Drawing.Point(6, 41)
        Me.rdb_femenino.Name = "rdb_femenino"
        Me.rdb_femenino.Size = New System.Drawing.Size(71, 17)
        Me.rdb_femenino.TabIndex = 1
        Me.rdb_femenino.TabStop = True
        Me.rdb_femenino.Text = "Femenino"
        Me.rdb_femenino.UseVisualStyleBackColor = True
        '
        'rdb_masculino
        '
        Me.rdb_masculino.AutoSize = True
        Me.rdb_masculino.Location = New System.Drawing.Point(6, 18)
        Me.rdb_masculino.Name = "rdb_masculino"
        Me.rdb_masculino.Size = New System.Drawing.Size(73, 17)
        Me.rdb_masculino.TabIndex = 0
        Me.rdb_masculino.TabStop = True
        Me.rdb_masculino.Text = "Masculino"
        Me.rdb_masculino.UseVisualStyleBackColor = True
        '
        'grb_est_civ
        '
        Me.grb_est_civ.Controls.Add(Me.rdb_casado)
        Me.grb_est_civ.Controls.Add(Me.rdb_soltero)
        Me.grb_est_civ.Location = New System.Drawing.Point(140, 156)
        Me.grb_est_civ.Name = "grb_est_civ"
        Me.grb_est_civ.Size = New System.Drawing.Size(90, 64)
        Me.grb_est_civ.TabIndex = 5
        Me.grb_est_civ.TabStop = False
        Me.grb_est_civ.Text = "Estado Civil"
        Me.grb_est_civ.Visible = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Location = New System.Drawing.Point(139, 438)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(104, 31)
        Me.btn_guardar.TabIndex = 17
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Frm_Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(255, 475)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.grb_est_civ)
        Me.Controls.Add(Me.grb_sex)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.btn_registrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_loc)
        Me.Controls.Add(Me.fecha_nac)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_domicilio)
        Me.Controls.Add(Me.txt_apellido)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Frm_Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Registro"
        Me.grb_sex.ResumeLayout(False)
        Me.grb_sex.PerformLayout()
        Me.grb_est_civ.ResumeLayout(False)
        Me.grb_est_civ.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_domicilio As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents fecha_nac As System.Windows.Forms.MonthCalendar
    Friend WithEvents cbo_loc As System.Windows.Forms.ComboBox
    Friend WithEvents rdb_casado As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_soltero As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_registrar As System.Windows.Forms.Button
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents grb_sex As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_femenino As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_masculino As System.Windows.Forms.RadioButton
    Friend WithEvents grb_est_civ As System.Windows.Forms.GroupBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
End Class
