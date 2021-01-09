Imports System.Threading

Public Sub MailGonder()
 Dim EM As New EmailSinifi
 Dim TH As New System.Threading.Thread(AddressOf EM.SendMail) With {.IsBackground = True}
 EM.GondericiAdi = "Sozluk Yazılımı"
 EM.GondericiAdresi = "iletisim@sozlukyazilimi.com"
 EM.GondericiSifresi = "mail şifresi"
 EM.SMTP_Sunucu = "smtp.yandex.com"
 EM.SMTP_Portu = 587
 EM.EnableSsl = True
 EM.MailBaslik = "Deneme Başlık"
 EM.MailIcerigi = "Deneme İçerik"
 EM.MailAliciAdres = "alici@mailadres.com"
 TH.Start()
End Sub
