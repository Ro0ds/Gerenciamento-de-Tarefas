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
            using(SmtpClient smtp = new SmtpClient(ServidorSMTP))
            {
                smtp.Port = PortaSaida;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.TargetName = "STARTTLS/" + ServidorSMTP;

                MailMessage mensagem = new MailMessage();
                mensagem.From = new MailAddress(destinatario);
                mensagem.To.Add(new MailAddress(destinatario));
                mensagem.Subject = assunto;
                mensagem.Body = corpo;

                smtp.Timeout = 30000;

                try
                {
                    smtp.Send(mensagem);

                    return true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"E-mail para: {destinatario} não enviado.\nErro: {ex.Message}");

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