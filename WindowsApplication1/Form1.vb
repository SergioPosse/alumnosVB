Public Class Frm_Main

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        Limpiar(Frm_Registro)
        LimpiarOPT(Frm_Registro.grb_est_civ)
        LimpiarOPT(Frm_Registro.grb_sex)
        Frm_Registro.btn_guardar.Enabled = False
        With Frm_Registro
            .grb_sex.Visible = False
            .grb_est_civ.Visible = False
            .lbl_fecha.Visible = False
            .fecha_nac.Visible = False
            .txt_fecha.Visible = False
            .btn_registrar.Enabled = False
            .Height = 196
        End With
        Frm_Registro.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizargrid()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ver.Click
        Dim tipo_vista As New lista_o_grilla
        tipo_vista.grilla()
        Frm_Lista.Show()
    End Sub
End Class
