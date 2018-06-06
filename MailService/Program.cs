using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace MailService
{
    class Program
    {
        private const string BASE_EMAIL = "smtptesteritstep@gmail.com";
        private const string BASE_EMAIL_PASSWORD = "167AEq!!";
        static void Main(string[] args)
        {
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(BASE_EMAIL, BASE_EMAIL_PASSWORD);

            MailMessage message = new MailMessage();
            message.From=new MailAddress(BASE_EMAIL,"Eduard");
            message.To.Add(new MailAddress("sikirovtemirlan@mail.ru"));
            message.Subject = "Гони пятихатку";
            message.Body = "Пацан проценты капают братаны уже выехали";
            message.Attachments.Add(new Attachment(@"C:\Users\СикировТ\Desktop\ControlOrder.txt"));

            smtpClient.Send(message);
        }
    }
}
