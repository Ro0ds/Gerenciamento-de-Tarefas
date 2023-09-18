namespace TaskManagerApp.Servicos
{
    public abstract class EmailServico
    {
        public string ServidorSMTP { get; set; } = string.Empty;
        public int PortaEntrada { get; set; } = 0;
        public int PortaSaida { get; set; } = 587;
        public string NomeRemetente { get; set; } = string.Empty;
        public string SenhaRemetente { get; set; } = string.Empty;
        public bool UsarSSL { get; set; } = false;

        public string Remetente { get; set; } = string.Empty;
        public string Destinatario { get; set; } = string.Empty;
        public string Assunto { get; set; } = string.Empty;
        public string Corpo { get; set; } = string.Empty;

        public abstract bool EnviarEmail(string destinatario, string assunto, string corpo);
    }
}
