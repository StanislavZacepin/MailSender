﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.lib.Interfaces;

namespace MailSender.lib
{
    public class DebugMailService : IMailService
    {
        public IMailSender GetSender(string Server, int Port, bool SSL, string Login, string Password)
        {
            return new DebugMailSender(Server, Port, SSL, Login, Password);
        }
    }

    internal class DebugMailSender : IMailSender
    {
        private readonly string _Server;
        private readonly int _Port;
        private readonly bool _Ssl;
        private readonly string _Login;
        private readonly string _Password;

        public DebugMailSender(string Server, int Port, bool SSL, string Login, string Password)
        {
            _Server = Server;
            _Port = Port;
            _Ssl = SSL;
            _Login = Login;
            _Password = Password;
        }

        public void Send(string SenderAddress, string RecipientAddress, string Subject, string Body)
        {
            Debug.WriteLine("Отправка почты ...");
        }

        public void Send(string SenderAddress, IEnumerable<string> RecipientsAddresses, string Subject, string Body)
        {
            foreach (var recipient_address in RecipientsAddresses)
                Send(SenderAddress, recipient_address, Subject, Body);
        }

        public void SendParallel(string SenderAddress, IEnumerable<string> RecipientsAddresses, string Subject, string Body)
        {
            foreach (var recipient_address in RecipientsAddresses)
                Send(SenderAddress, recipient_address, Subject, Body);
        }
    }
}