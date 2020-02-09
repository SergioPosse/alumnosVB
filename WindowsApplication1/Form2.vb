Public Class Frm_Lista

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_atras.Click
        Me.Hide()
    End Sub

    Private Sub grid_DblClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mfg_persona.DblClick
        With mfg_persona
            .Col = 2
            Frm_Registro.txt_apellido.Text = .Text
            .Col = 1
            Frm_Registro.txt_nombre.Text = .Text
            .Col = 3
            Frm_Registro.txt_domicilio.Text = .Text
            .Col = 4
            Frm_Registro.cbo_loc.Text = .Text
            .Col = 5
            If .Text = "Masculino" Then
                Frm_Registro.rdb_masculino.Checked = True
            End If
            If .Text = "Femenino" Then
                Frm_Registro.rdb_femenino.Checked = True
            End If
            .Col = 6
            If .Text = "Soltero/a" Then
                Frm_Registro.rdb_soltero.Checked = True
            End If
            If .Text = "Casado/a" Then
                Frm_Registro.rdb_casado.Checked = True
            End If
            .Col = 7
            Frm_Registro.txt_fecha.Text = .Text
        End With
        Frm_Registro.btn_registrar.Enabled = False
        Frm_Registro.btn_guardar.Enabled = True
        Frm_Registro.Show()
    End Sub
    Private Sub grid_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mfg_persona.ClickEvent
        If lst_nom.Items.Count > 0 Then 'si la lista tiene algun item entonces selecciono "fila" entera'
            lst_nom.SelectedIndex = (mfg_persona.Row - 1)
            lst_ape.SelectedIndex = (mfg_persona.Row - 1)
            lst_dom.SelectedIndex = (mfg_persona.Row - 1)
            lst_loc.SelectedIndex = (mfg_persona.Row - 1)
            lst_sex.SelectedIndex = (mfg_persona.Row - 1)
            lst_est_civ.SelectedIndex = (mfg_persona.Row - 1)
            lst_fec_nac.SelectedIndex = (mfg_persona.Row - 1)
        End If
        pintar_fila(mfg_persona)
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        If mfg_persona.Row <= 0 Or lst_nom.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar una fila")
        ElseIf mfg_persona.Rows = 2 Then
            mfg_persona.Clear()
            actualizargrid()
        Else
            mfg_persona.RemoveItem(mfg_persona.Row)
        End If
        If lst_nom.SelectedIndex <> -1 Then 'si no hay nada seleccionado no elimino nada por que me tira error'
            lst_nom.Items.RemoveAt(lst_nom.SelectedIndex)
            lst_ape.Items.RemoveAt(lst_ape.SelectedIndex)
            lst_dom.Items.RemoveAt(lst_dom.SelectedIndex)
            lst_sex.Items.RemoveAt(lst_sex.SelectedIndex)
            lst_loc.Items.RemoveAt(lst_loc.SelectedIndex)
            lst_est_civ.Items.RemoveAt(lst_est_civ.SelectedIndex)
            lst_fec_nac.Items.RemoveAt(lst_fec_nac.SelectedIndex)
        End If
        mfg_persona.Row = 0 'para que no se seleccione nada automaticamente al eliminar registros'
    End Sub
    Private Sub btn_listas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_listas.Click
        Dim tipo_vista As New lista_o_grilla
        tipo_vista.lista()
    End Sub

    Private Sub btn_grilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_grilla.Click
        Dim tipo_vista As New lista_o_grilla
        tipo_vista.grilla()
    End Sub

    Private Sub lst_nom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_nom.Click
        lista_fila_entera(lst_nom, Me)

        'selecciono la fila del grid a partir del index de la lista'
        mfg_persona.Row = lst_nom.SelectedIndex + 1 '+1 por que en el grid tengo el encabezado y en listas no'
        pintar_fila(mfg_persona)
    End Sub

    Private Sub lst_ape_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_ape.SelectedIndexChanged
        lista_fila_entera(lst_ape, Me)
        mfg_persona.Row = lst_nom.SelectedIndex + 1
        pintar_fila(mfg_persona)
    End Sub

    Private Sub lst_dom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_dom.SelectedIndexChanged
        lista_fila_entera(lst_dom, Me)
        mfg_persona.Row = lst_nom.SelectedIndex + 1
        pintar_fila(mfg_persona)
    End Sub

    Private Sub lst_loc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_loc.SelectedIndexChanged
        lista_fila_entera(lst_loc, Me)
        mfg_persona.Row = lst_nom.SelectedIndex + 1
        pintar_fila(mfg_persona)
    End Sub

    Private Sub lst_sex_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_sex.SelectedIndexChanged
        lista_fila_entera(lst_sex, Me)
        mfg_persona.Row = lst_nom.SelectedIndex + 1
        pintar_fila(mfg_persona)
    End Sub

    Private Sub lst_est_civ_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_est_civ.SelectedIndexChanged
        lista_fila_entera(lst_est_civ, Me)
        mfg_persona.Row = lst_nom.SelectedIndex + 1
        pintar_fila(mfg_persona)
    End Sub

    Private Sub lst_fec_nac_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_fec_nac.SelectedIndexChanged
        lista_fila_entera(lst_fec_nac, Me)
        mfg_persona.Row = lst_nom.SelectedIndex + 1
        pintar_fila(mfg_persona)
    End Sub
End Class