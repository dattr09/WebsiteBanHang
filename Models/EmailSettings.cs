﻿namespace WebsiteBanHang.Models
{
    public class EmailSettings
    {
        public required string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public required string SmtpUsername { get; set; }
        public required string SmtpPassword { get; set; }
        public required string SenderEmail { get; set; }
        public required string SenderName { get; set; }
    }
}
