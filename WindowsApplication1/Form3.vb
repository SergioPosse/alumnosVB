Public Class Frm_Registro
    Private Sub btn_registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_registrar.Click
        Dim sexo As String = SaberCualOPT(grb_sex)
        Dim estado_civil As String = SaberCualOPT(grb_est_civ)
        With Frm_Lista.mfg_persona
            .AddItem(Chr(9) + StrConv(txt_nombre.Text, 3) + Chr(9) + StrConv(txt_apellido.Text, 3) + Chr(9) + StrConv(txt_domicilio.Text, 3) + Chr(9) + cbo_loc.Text + Chr(9) + sexo + Chr(9) + estado_civil + Chr(9) + txt_fecha.Text + Chr(9))
            If .Rows = 3 Then
                .Row = 1
                .Col = 1
                If .Text = "" Then
                    .RemoveItem(1)
                End If
            End If
        End With
            With Frm_Lista
            .lst_nom.Items.Add(StrConv(txt_nombre.Text, 3))
            .lst_ape.Items.Add(StrConv(txt_apellido.Text, 3))
            .lst_dom.Items.Add(StrConv(txt_domicilio.Text, 3))
                .lst_sex.Items.Add(SaberCualOPT(grb_sex))
                .lst_est_civ.Items.Add(SaberCualOPT(grb_est_civ))
                .lst_loc.Items.Add(cbo_loc.Text)
            .lst_fec_nac.Items.Add(txt_fecha.Text)
            End With
            txt_nombre.Focus()
            Me.Hide()
    End Sub

    Private Sub fecha_nac_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles fecha_nac.DateChanged
        Me.txt_fecha.Text = CStr(Me.fecha_nac.SelectionRange.Start)
    End Sub

    Private Sub cbo_loc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_loc.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        With Frm_Lista.mfg_persona
            .Col = 1
            .Text = StrConv(txt_nombre.Text, 3)
            .Col = 2
            .Text = StrConv(txt_apellido.Text, 3)
            .Col = 3
            .Text = StrConv(txt_domicilio.Text, 3)
            .Col = 4
            .Text = cbo_loc.Text
            .Col = 5
            .Text = SaberCualOPT(grb_sex)
            .Col = 6
            .Text = SaberCualOPT(grb_est_civ)
            .Col = 7
            .Text = txt_fecha.Text
        End With
        Me.Hide()
    End Sub

    Private Sub txt_nombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        sololetras(e)
    End Sub

    Private Sub txt_apellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_apellido.KeyPress
        sololetras(e)
    End Sub

    Private Sub txt_domicilio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_domicilio.KeyPress
        alfanumerico(e)
    End Sub

    Private Sub txt_nombre_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.Leave
        validarblanco(txt_nombre, txt_apellido)
    End Sub

    Private Sub txt_apellido_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_apellido.Leave
        validarblanco(txt_apellido, txt_domicilio)
    End Sub

    Private Sub txt_domicilio_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_domicilio.Leave
        validarblanco(txt_domicilio, cbo_loc)
    End Sub

    Private Sub cbo_loc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_loc.SelectedIndexChanged
        grb_sex.Visible = True
        Me.Height = (266)
    End Sub

    Private Sub rdb_masculino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_masculino.CheckedChanged
        grb_est_civ.Visible = True
    End Sub

    Private Sub rdb_femenino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_femenino.CheckedChanged
        grb_est_civ.Visible = True
    End Sub

    Private Sub rdb_soltero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_soltero.CheckedChanged
        txt_fecha.Visible = True
        lbl_fecha.Visible = True
        fecha_nac.Visible = True
        Me.Height = (509)
    End Sub

    Private Sub rdb_casado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_casado.CheckedChanged
        txt_fecha.Visible = True
        lbl_fecha.Visible = True
        fecha_nac.Visible = True
        Me.Height = (509)
    End Sub

    Private Sub txt_fecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_fecha.TextChanged
        btn_registrar.Enabled = True
    End Sub
End Class