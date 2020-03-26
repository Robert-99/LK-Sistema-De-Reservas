Public Class EventoDelTextbox
    Public Sub textoKeyPress(e As KeyPressEventArgs)

        If (Char.IsLetter(e.KeyChar)) Then 'Condicion que solo nos permite ingresar datos de tipo texto'
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Enter)) Then 'Condicion que permite no dar salto de linea cuando se oprime ENTER'
            e.Handled = True
        ElseIf (Char.IsControl(e.KeyChar)) Then 'Condicion que nos permite utilizar la tecla backspace
            e.Handled = False
        ElseIf (Char.IsSeparator(e.KeyChar)) Then 'Condicion que nos permite utilizar la tecla de espacio
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub numeroKeyPress(e As KeyPressEventArgs)
        If (Char.IsDigit(e.KeyChar)) Then 'Condicion que solo nos permite ingresar datos de tipo digito entiendase numeros'
            e.Handled = False
        ElseIf (e.KeyChar = Convert.ToChar(Keys.Enter)) Then 'Condicion que permite no dar salto de linea cuando se oprime ENTER'
            e.Handled = True
        ElseIf (Char.IsLetter(e.KeyChar)) Then 'Condicion que no nos permite ingresar datos de tipo texto'
            e.Handled = True
        ElseIf (Char.IsControl(e.KeyChar)) Then 'Condicion que nos permite utilizar la tecla backspace'
            e.Handled = False
        ElseIf (Char.IsSeparator(e.KeyChar)) Then 'Condicion que nos permite utilizar la tecla de espacio
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub
End Class
