using System.Net;
using System.Net.Mail;

namespace TaskManagerApp.Servicos
{
    public class Gmail : EmailServico
    {
        public Gmail() 
        {
            ServidorSMTP = "smtp.gmail.com";
        }

        public override bool EnviarEmail(string destinatario, string assunto, string corpo)
        {
            using(SmtpClient smtp = new SmtpClient(ServidorSMTP, PortaSaida))
            {
                smtp.EnableSsl = UsarSSL;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.TargetName = "STARTTLS/" + ServidorSMTP;
                smtp.Credentials = new NetworkCredential(Remetente, SenhaRemetente);

                MailMessage mensagem = new MailMessage();
                mensagem.From = new MailAddress(Remetente);
                mensagem.To.Add(new MailAddress(Destinatario));
                mensagem.Subject = Assunto;
                mensagem.Body = Corpo;

                smtp.Timeout = 30000;

                try
                {
                    smtp.Send(mensagem);

                    return true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"E-mail para: {Destinatario} não enviado.\nErro: {ex.Message}");

                    return false;
                }
            }
        }
    }

    public class Yahoo : EmailServico
    {
        public Yahoo() 
        {
            ServidorSMTP = "smtp.mail.yahoo.com";
        }

        public override bool EnviarEmail(string destinatario, string assunto, string corpo)
        {
            return true;
        }
    }

    public class Outlook : EmailServico
    {
        public Outlook()
        {
            ServidorSMTP = "smtp-mail.outlook.com";
        }

        public override bool EnviarEmail(string destinatario, string assunto, string corpo)
        {
            return true;
        }
    }
}