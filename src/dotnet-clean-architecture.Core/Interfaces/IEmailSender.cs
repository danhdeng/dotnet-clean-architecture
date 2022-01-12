using System.Threading.Tasks;

namespace dotnet_clean_architecture.Core.Interfaces;

public interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}
