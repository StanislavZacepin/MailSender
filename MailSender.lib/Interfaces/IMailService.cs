namespace MailSender.lib.Interfaces
{
    public interface IMailService
    {
        void SendEmail(string From, string to, string Title, string Body);
    }
}
