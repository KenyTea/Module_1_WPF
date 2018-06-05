using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Module_1_WPF.Module
{
    public class Helper
    {
        public string SendMail(string to, string subject)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("Vassilyevalexey@gmail.com", "Master Zen");

            msg.To.Add(to);
            msg.Subject = subject;
            msg.Body = "Test Body";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("Vassilyevalexey@gmail.com", "8888888"); //!!!!!

            try
            {
                smtp.Send(msg);
                return "Сообщение Отправлено";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        
    }
}
