﻿using System.Threading.Tasks;

using MailKit.Net.Smtp;

using Microsoft.Extensions.Configuration;

using MimeKit;
using MimeKit.Text;

using OpenWork.Services.Interfaces.Common;


namespace OpenWork.Services.Services.Common;

public class EmailService : IEmailService
{
	private readonly IConfiguration _config;
	public EmailService(IConfiguration configuration)
	{
		_config = configuration.GetSection("EmailConnection");
	}
	public async Task<bool> SendCode(string email, int code)
	{
		MimeMessage mail = new MimeMessage();
		mail.From.Add(MailboxAddress.Parse(_config["Email"]));
		mail.To.Add(MailboxAddress.Parse(email));
		mail.Subject = "Confimation Code for openwork.uz";
		mail.Body = new TextPart(TextFormat.Html) { Text = code.ToString() };

		SmtpClient smtp = new SmtpClient();
		await smtp.ConnectAsync(_config["Host"], int.Parse(_config["Port"]), MailKit.Security.SecureSocketOptions.StartTls);
		await smtp.AuthenticateAsync(_config["Email"], _config["Password"]);
		_ = await smtp.SendAsync(mail);
		await smtp.DisconnectAsync(true);
		return true;
	}
}
