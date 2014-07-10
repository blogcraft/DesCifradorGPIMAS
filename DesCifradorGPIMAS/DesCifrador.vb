Imports System.Security.Cryptography
Imports System.Text

Public Class DesCifrador

    Private Shared ReadOnly IV As Byte() = {240, 3, 45, 29, 0, 76, 173, 59}

    Const NumCryptokey As Integer = 6
    Const NumExtraClave As Integer = 8
    Const NumsKey As Integer = 7

#Region "    PROPIEDADES"
    Dim _Cadena As String

    Public Property Cadena() As String
        Get
            Return _Cadena
        End Get
        Set(ByVal value As String)
            _Cadena = value
        End Set
    End Property
#End Region

    Private Sub DesCifrador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = "Listo"
        Cadena = ""
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEntrada.KeyPress
        Select Case e.KeyChar
            Case " "
                e.Handled = True
        End Select
    End Sub

    Private Sub TxtNegocio_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNegocio.Enter
        If TxtNegocio.Text = "Default" Then
            TxtNegocio.Text = ""
            TxtNegocio.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtNegocio_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNegocio.Leave
        If TxtNegocio.Text = "" Then
            TxtNegocio.Text = "Default"
            TxtNegocio.ForeColor = Color.Silver
        End If
    End Sub

    Sub Portapapeles()
        Clipboard.SetDataObject(Cadena, True)
        ToolStripStatusLabel1.Text = "Resultado copiado al portapapeles"
    End Sub

    Private Sub TtBtnCifrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TtBtnCifrar.Click
        If TxtEntrada.Text <> "" Then
            Select Case TxtNegocio.Text.ToUpper
                Case "HSBC"
                    If EncriptaHSBC(Trim(Me.TxtEntrada.Text), True) Then
                        TxtSalida.Text = Cadena
                        Portapapeles()
                    End If
                Case Else
                    If EncriptaGENERICO(Trim(Me.TxtEntrada.Text)) Then
                        TxtSalida.Text = Cadena
                        Portapapeles()
                    End If
            End Select
        Else
            ToolStripStatusLabel1.Text = "Ingrese Texto a Cifrar/DesCifrar"
        End If
    End Sub

    Private Sub TtBtnDesCifrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TtBtnDesCifrar.Click
        If TxtEntrada.Text <> "" Then
            Select Case TxtNegocio.Text.ToUpper
                Case "HSBC"
                    If EncriptaHSBC(Trim(Me.TxtEntrada.Text), False) Then
                        TxtSalida.Text = Cadena
                        Portapapeles()
                    End If
                Case Else
                    If DesEncriptaGENERICO(Trim(Me.TxtEntrada.Text)) Then
                        TxtSalida.Text = Cadena
                        Portapapeles()
                    End If
            End Select
        Else
            ToolStripStatusLabel1.Text = "Ingrese Texto a Cifrar/DesCifrar"
        End If
    End Sub

    Shared Function Generate(ByVal KeyChars As Integer) As String
        Dim i_key As Integer
        Dim Random1 As Single
        Dim arrIndex As Int16
        Dim sb As New StringBuilder
        Dim RandomLetter As String

        Dim KeyLetters As String = "abcdefghijklmnopqrstuvwxyz"
        Dim KeyNumbers As String = "0123456789"

        Dim LettersArray As Char()
        Dim NumbersArray As Char()

        ' CONVERT LettersArray & NumbersArray TO CHARACTR ARRAYS
        LettersArray = KeyLetters.ToCharArray
        NumbersArray = KeyNumbers.ToCharArray

        For i_key = 1 To KeyChars
            Randomize()
            Random1 = Rnd()
            arrIndex = -1
            If (CType(Random1 * 111, Integer)) Mod 2 = 0 Then
                Do While arrIndex < 0
                    arrIndex = Convert.ToInt16(LettersArray.GetUpperBound(0) * Random1)
                Loop
                RandomLetter = LettersArray(arrIndex)
                If (CType(arrIndex * Random1 * 99, Integer)) Mod 2 <> 0 Then
                    RandomLetter = LettersArray(arrIndex).ToString
                    RandomLetter = RandomLetter.ToUpper
                End If
                sb.Append(RandomLetter)
            Else
                Do While arrIndex < 0
                    arrIndex = Convert.ToInt16(NumbersArray.GetUpperBound(0) * Random1)
                Loop
                sb.Append(NumbersArray(arrIndex))
            End If
        Next
        Return sb.ToString
    End Function

    Function EncriptaHSBC(ByVal strCadena As String, ByVal blnModo As Boolean) As Boolean
        Dim X As Single
        Dim xPdw As String
        Dim Caracteres As String
        Dim Codificacion As String

        Caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyz"
        Codificacion = "<?>zTcklop}IZiqLmatr@uxAOW[{nMGKXSysDBCP_h\EvNRw`]QHfbdeJgVFYU"

        xPdw = ""
        EncriptaHSBC = False
        Try
            For X = 1 To Len(strCadena)

                If blnModo Then
                    xPdw = xPdw + Chr((Asc(Mid(Codificacion, InStr(1, Caracteres, Mid(strCadena, X, 1)), 1)) - X))
                Else
                    xPdw = xPdw + Mid(Caracteres, InStr(1, Codificacion, Chr(Asc(Mid(strCadena, X, 1)) + X)), 1)
                End If

            Next
            Cadena = xPdw
            EncriptaHSBC = True
        Catch ex As Exception
            If blnModo Then
                ToolStripStatusLabel1.Text = "Error: No se puede cifrar el caracter: " & Mid(strCadena, X, 1)
            Else
                ToolStripStatusLabel1.Text = "Error: No se puede descifrar el caracter: " & Mid(strCadena, X, 1)
            End If
            EncriptaHSBC = False
        End Try

    End Function

    Function EncriptaGENERICO(ByVal serializedQueryString As String) As Boolean
        Dim sRetorno As String
        Try
            'serializedQueryString = serializedQueryString.ToUpper
            Dim cryptokey As String = ""
            Dim ExtraClave As String = ""
            Dim sKey As String = ""

            cryptokey = Generate(NumCryptokey)
            ExtraClave = Generate(NumExtraClave)
            sKey = Generate(NumsKey)

            Dim buffer As Byte() = Encoding.ASCII.GetBytes(serializedQueryString & ExtraClave)
            Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
            Dim MD5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
            des.Key = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(sKey & cryptokey))
            des.IV = IV

            sRetorno = cryptokey & ExtraClave & sKey & Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

            Cadena = sRetorno
            EncriptaGENERICO = True
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Error: Al cifrar el Texto de Entrada"
            EncriptaGENERICO = False
        End Try

    End Function

    Function DesEncriptaGENERICO(ByVal encryptedQueryString As String) As Boolean
        Dim buffer As Byte()
        Dim DES As New TripleDESCryptoServiceProvider
        Dim MD5 As New MD5CryptoServiceProvider
        Dim sRetorno As String

        Dim cryptokey As String = ""
        Dim ExtraClave As String = ""
        Dim sKey As String = ""

        cryptokey = Microsoft.VisualBasic.Left(encryptedQueryString, NumCryptokey)
        ExtraClave = Mid(encryptedQueryString, NumCryptokey + 1, NumExtraClave)
        sKey = Mid(encryptedQueryString, NumCryptokey + NumExtraClave + 1, NumsKey)

        encryptedQueryString = Mid(encryptedQueryString, NumCryptokey + NumExtraClave + NumsKey + 1, Len(encryptedQueryString))

        Try
            ' encryptedQueryString = encryptedQueryString.ToUpper
            buffer = Convert.FromBase64String(encryptedQueryString)

            DES.Key = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(sKey & cryptokey))
            DES.IV = IV

            ' a = Encoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

            sRetorno = (Replace(Encoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length())), ExtraClave, ""))
            Cadena = sRetorno
            DesEncriptaGENERICO = True
        Catch ex As Exception
            DesEncriptaGENERICO = False
            ToolStripStatusLabel1.Text = "Error: No se puede descifrar el Texto de Entrada"  ' String.Empty
        End Try

    End Function

End Class
