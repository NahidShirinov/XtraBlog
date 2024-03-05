using System.Net.Mail;
using System.Net;

namespace XtraBlog.Services
{
    
        public interface IEmailService
        {
            public Task EmailSenderAsync (string email,string subject,string message);
        }
        public class EmailService : IEmailService
        {
             public async Task EmailSenderAsync(string email, string subject, string message)
            {
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("nahidsrnv50@gmail.com", "qxjwljtaoevgpmeg"),
                    EnableSsl = true
                };
                await client.SendMailAsync(new MailMessage(from: "nahidsrnv50@gmail.com", to: email, subject: subject, message));
            }

        }
   
}
