using MailKit.Net.Smtp;
using MimeKit;

namespace Api.Infra.Services;

public class EmailService
{

    public async Task SendEmailAsync(string to, string subject, string body)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Seu Nome", "seuemail@dominio.com"));
        message.To.Add(new MailboxAddress("Destinatário", "destinatario@exemplo.com"));
        message.Subject = "Assunto do Email";

        message.Body = new TextPart("plain")
        {
            Text = @"Olá, isso é um teste!"
        };

        using (var client = new SmtpClient())
        {
            client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            client.Authenticate("seuemail@dominio.com", "sua-senha-ou-senha-de-app");
            client.Send(message);
            client.Disconnect(true);
        }
    }
}
