Imports AxMSFlexGridLib
Imports System.Data.OleDb
Module Module1
    Public Sub actualizargrid()
        With Frm_Lista.mfg_persona
            .Row = 0
            .Col = 0
            .set_ColWidth(0, 500)
            .Col = 1
            .set_ColWidth(1, 2000)
            .Text = "Nombre"
            .Col = 2
            .Text = "Apellido"
            .set_ColWidth(2, 2000)
            .Col = 3
            .Text = "Domicilio"
            .set_ColWidth(3, 2000)
            .Col = 4
            .Text = "Localidad"
            .set_ColWidth(4, 2000)
            .Col = 5
            .Text = "Sexo"
            .set_ColWidth(5, 2000)
            .Col = 6
            .Text = "Estado Civil"
            .set_ColWidth(6, 2000)
            .Col = 7
            .Text = "Fecha De Nacimiento"
            .set_ColWidth(7, 2400)
            .set_ColAlignment(7, 3)
        End With
    End Sub
    'Permite ingresar solo numeros (Telefonos).
    Public Sub solonumeros(ByVal caracter As KeyPressEventArgs)
        If Not (Char.IsNumber(caracter.KeyChar) Or caracter.KeyChar = Chr(8)) Then
            caracter.Handled = True
        End If
    End Sub
    'Permite ingresar letras y numeros (Domicilios de las personas).
    Public Sub alfanumerico(ByVal caracter As KeyPressEventArgs)
        If Not (Char.IsLetter(caracter.KeyChar) Or Char.IsNumber(caracter.KeyChar) Or caracter.KeyChar = Chr(8) Or caracter.KeyChar = Chr(32)) Then
            caracter.Handled = True
        End If
    End Sub
    'permite ingresar solo letras'
    Public Sub sololetras(ByVal caracter As KeyPressEventArgs)
        If Not (Char.IsLetter(caracter.KeyChar) Or caracter.KeyChar = Chr(8) Or caracter.KeyChar = Chr(32)) Then
            caracter.Handled = True
        End If
    End Sub

    Public Sub Limpiar(ByVal contenedor As Control)
        Dim componente As Control
        For Each componente In contenedor.Controls
            If TypeOf (componente) Is TextBox Then
                componente.Text = ""
            End If
            If TypeOf (componente) Is ComboBox Then
                componente.Text = "Seleccionar"
            End If
            If TypeOf (componente) Is RadioButton Then
                CType(componente, RadioButton).Checked = False
            End If
        Next
    End Sub
    Public Sub LimpiarOPT(ByVal contenedor As Control)
        Dim componente As RadioButton
        For Each componente In contenedor.Controls
            If TypeOf (componente) Is RadioButton Then
                componente.Checked = False
            End If
        Next
    End Sub
    Public Function SaberCualOPT(ByVal contenedor As Control) As String
        Dim radio As Control
        Dim res As String
        res = ""
        For Each radio In contenedor.Controls
            If TypeOf (radio) Is RadioButton Then
                If CType(radio, RadioButton).Checked Then
                    res = radio.Text
                End If
            End If
        Next
        If res = "" Then
            res = -1
        End If
        SaberCualOPT = res
    End Function
    Public Sub pintar_fila(ByRef listado As AxMSFlexGridLib.AxMSFlexGrid)
        listado.SelectionMode = MSFlexGridLib.SelectionModeSettings.flexSelectionByRow
        listado.HighLight = MSFlexGridLib.HighLightSettings.flexHighlightAlways
        listado.Col = 0
        listado.ColSel = listado.Cols - 1
    End Sub
    Public Sub validarblanco(ByVal box As Control, ByVal box2 As Control) 'creada por mi'
        If TypeOf (box) Is TextBox Then
            If box.Text = "" Then
                MsgBox("No deje espacios")
                box.Focus()
            Else
                box2.Focus()
            End If
        End If
    End Sub
    Public Sub lista_fila_entera(ByVal lista As ListBox, ByVal contenedor As Control) 'creada por mi'
        Dim index As Integer = lista.SelectedIndex
        Dim elemento As Control
        For Each elemento In contenedor.Controls
            If TypeOf (elemento) Is ListBox Then
                If index = -1 Then
                    Exit Sub
                Else
                    CType(elemento, ListBox).SelectedIndex = index
                End If
            End If
        Next
    End Sub

    Public Class lista_o_grilla
        Public Sub grilla()
            With Frm_Lista
                .lbl_ape.Visible = False
                .lbl_nom.Visible = False
                .lbl_dom.Visible = False
                .lbl_loc.Visible = False
                .lbl_sex.Visible = False
                .lbl_est_civ.Visible = False
                .lbl_fec_nac.Visible = False
                .lst_nom.Visible = False
                .lst_ape.Visible = False
                .lst_dom.Visible = False
                .lst_sex.Visible = False
                .lst_loc.Visible = False
                .lst_est_civ.Visible = False
                .lst_fec_nac.Visible = False
                .mfg_persona.Visible = True
                .mfg_persona.Enabled = True
            End With
        End Sub
        Public Sub lista()
            With Frm_Lista
                .lbl_ape.Visible = True
                .lbl_nom.Visible = True
                .lbl_dom.Visible = True
                .lbl_loc.Visible = True
                .lbl_sex.Visible = True
                .lbl_est_civ.Visible = True
                .lbl_fec_nac.Visible = True
                .lst_nom.Visible = True
                .lst_ape.Visible = True
                .lst_dom.Visible = True
                .lst_sex.Visible = True
                .lst_loc.Visible = True
                .lst_est_civ.Visible = True
                .lst_fec_nac.Visible = True
                .mfg_persona.Visible = False
                .mfg_persona.Enabled = False
            End With
        End Sub
    End Class
End Module
