Imports System.Security.Cryptography
Imports System.Text

Public Class CEncriptar
    Public Class CEncriptar
        Public Class SurroundingClass
            Private Shared rm As RijndaelManaged = New RijndaelManaged()

            Public Sub New()
                rm.Mode = CipherMode.CBC
                rm.Padding = PaddingMode.PKCS7
                rm.KeySize = &H80
                rm.BlockSize = &H80
            End Sub

            Public Shared Function EncryptData(ByVal textdata As String, ByVal EncryptionKey As String) As String
                Dim passBytes As Byte() = Encoding.UTF8.GetBytes(EncryptionKey)
                Dim EncryptionKeyBytes As Byte() = New Byte() {&H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0, &H0}
                Dim len As Integer = passBytes.Length

                If len > EncryptionKeyBytes.Length Then
                    len = EncryptionKeyBytes.Length
                End If

                Array.Copy(passBytes, EncryptionKeyBytes, len)
                rm.Key = EncryptionKeyBytes
                rm.IV = EncryptionKeyBytes
                Dim objtransform As ICryptoTransform = rm.CreateEncryptor()
                Dim textDataByte As Byte() = Encoding.UTF8.GetBytes(textdata)
                Return Convert.ToBase64String(objtransform.TransformFinalBlock(textDataByte, 0, textDataByte.Length))
            End Function

            Public Shared Function DecryptData(ByVal EncryptedText As String, ByVal EncryptionKey As String) As String
                Dim encryptedTextByte As Byte() = Convert.FromBase64String(EncryptedText)
                Dim passBytes As Byte() = Encoding.UTF8.GetBytes(EncryptionKey)
                Dim EncryptionKeyBytes As Byte() = New Byte(15) {}
                Dim len As Integer = passBytes.Length

                If len > EncryptionKeyBytes.Length Then
                    len = EncryptionKeyBytes.Length
                End If

                Array.Copy(passBytes, EncryptionKeyBytes, len)
                rm.Key = EncryptionKeyBytes
                rm.IV = EncryptionKeyBytes
                Dim TextByte As Byte() = rm.CreateDecryptor().TransformFinalBlock(encryptedTextByte, 0, encryptedTextByte.Length)
                Return Encoding.UTF8.GetString(TextByte)
            End Function
        End Class
    End Class

    Friend Function SurroundingClass() As Object
        Throw New NotImplementedException()
    End Function
End Class
