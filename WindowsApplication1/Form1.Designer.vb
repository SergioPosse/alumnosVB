<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
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
        Me.btn_ver = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_ver
        '
        Me.btn_ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ver.ForeColor = System.Drawing.Color.Black
        Me.btn_ver.Location = New System.Drawing.Point(9, 45)
        Me.btn_ver.Name = "btn_ver"
        Me.btn_ver.Size = New System.Drawing.Size(121, 35)
        Me.btn_ver.TabIndex = 1
        Me.btn_ver.Text = "Ver"
        Me.btn_ver.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.Black
        Me.btn_salir.Location = New System.Drawing.Point(9, 125)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(121, 35)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.Color.Black
        Me.btn_agregar.Location = New System.Drawing.Point(9, 86)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(121, 35)
        Me.btn_agregar.TabIndex = 4
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Agenda"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(142, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_ver)
        Me.Name = "Frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ver As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
