Imports System.Net
Imports System.Net.Mail

Public Class EmailSinifi
    Public MailAliciAdres As String
    Public MailBaslik As String
    Public MailIcerigi As String
    Public GondericiAdresi As String
    Public GondericiSifresi As String
    Public GondericiAdi As String
    Public SMTP_Sunucu As String
    Public SMTP_Portu As Integer
    Public EnableSsl As Boolean


    Public Sub SendMail()
        Try
            Dim message As MailMessage = New MailMessage With {
                .From = New MailAddress(GondericiAdresi, GondericiAdi)
            }
            message.To.Add(MailAliciAdres)
            message.Subject = MailBaslik
            message.Body = MailIcerigi
            message.IsBodyHtml = True
            Dim smtpClient As SmtpClient = New SmtpClient(SMTP_Sunucu, SMTP_Portu) With {
                .EnableSsl = EnableSsl,
                .Credentials = CType(New NetworkCredential(GondericiAdresi, GondericiSifresi), ICredentialsByHost)
            }
            smtpClient.Send(message)
            smtpClient.Dispose()
            message.Dispose()
        Catch e As SmtpException
        End Try
    End Sub
End Class
