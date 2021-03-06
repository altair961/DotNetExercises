﻿using Commerce.Common.DataModels;

namespace Commerce.Common
{
    public interface IMailer
    {
        void SendInvoiceEmail(OrderData orderData);
        void SendRejectionEmail(OrderData orderData);
        string FromAddress { get; set; }
        string SmtpServer { get; set; }
    }
}