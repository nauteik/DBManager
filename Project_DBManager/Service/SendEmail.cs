using Project_DBManager.DAO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.Windows.Forms;

namespace Project_DBManager.Service
{
    public class SendEmail
    {
        private static SendEmail instance;

        public static SendEmail Instance { get => instance == null ? new SendEmail() : instance; set => instance = value; }

        public async Task sendEmail(string mail, string content)
        {
            try
            {
             
              
                string mailSender = "dbmanagerteam@gmail.com";
                string fromPassword = "xvlsxthynqyrdvut";
                string mailReceiver = mail;
                MailMessage message = new MailMessage();
                message.From = new MailAddress(mailSender);
                message.Subject = "Cấp lại mật khẩu";
                message.To.Add(new MailAddress(mailReceiver));
                message.Body = "<html><body>" + content + "</body></html>";
                message.IsBodyHtml = true;

                var stmpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(mailSender, fromPassword),
                    EnableSsl = true,
                };

                await Task.Run(() => stmpClient.Send(message));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
