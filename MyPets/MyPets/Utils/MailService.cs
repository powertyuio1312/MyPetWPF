using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows;
namespace MyPets.Utils
{
    public static class Maindf
    {
        public static void SendMail(string smtpServer, string from, string password,
            string mailto, string caption, string message)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from);
                mail.To.Add(new MailAddress(mailto));
                mail.Subject = caption;
                mail.Body = message;
                SmtpClient client = new SmtpClient();
                client.Host = smtpServer;
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from.Split('@')[0], password);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Проблемы с отправкой", "Ошибка");
            }
        }

        public static void SendMail(string maito, string caption, string message)
        {
            SendMail("smtp.mail.ru", "VovaLox2007@mail.ru", "CatDogLox", maito, caption, message);
        }        
    }
}
