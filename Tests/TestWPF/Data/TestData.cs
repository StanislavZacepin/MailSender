using System.Collections.Generic;
using System.Linq;
using WpfMailSender.Models;
using MailSender.lib.Service;


namespace WpfMailSender.Data
{
    internal static class TestData
    {
        public static List<Server> Servers { get; } = Enumerable.Range(1, 10).Select(i => new Server
        {
            Name = $"Сервер-{i}",
            Address = $"smtp.server{i}.com",
            Login = $"Logon-{i}",
            Password = TextEncoder.Encode($"Password-{i}",7),
            UseSSL = i % 2 == 0,
        }).ToList();

        public static List<Sender> Senders { get; } = Enumerable.Range(1, 10).Select(i => new Sender
        {
            Name = $"Отправитель {i}",
            Address = $"sender_{i}@servver.ru"
        }).ToList();

        public static List<Recipent> Recipentss { get; } = Enumerable.Range(1, 10).Select(i => new Recipent
        {
            Name = $"Получатель {i}",
            Address = $"recipient_{i}@servver.ru"
        }).ToList();

        public static List<Message> Messages { get; } = Enumerable.Range(1, 100).Select(i => new Message
        {
            Title = $"Тема Сообщения{i}",
            Text = $"Текст Сообщения{i}"
        }).ToList();
}
}

