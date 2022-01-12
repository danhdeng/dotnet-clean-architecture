using System.Threading;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using dotnet_clean_architecture.Core.Interfaces;
using dotnet_clean_architecture.Core.ProjectAggregate.Events;
using MediatR;

namespace dotnet_clean_architecture.Core.ProjectAggregate.Handlers;

public class ItemCompletedEmailNotificationHandler : INotificationHandler<ToDoItemCompletedEvent>
{
  private readonly IEmailSender _emailSender;

  // In a REAL app you might want to use the Outbox pattern and a command/queue here...
  public ItemCompletedEmailNotificationHandler(IEmailSender emailSender)
  {
    _emailSender = emailSender;
  }

  // configure a test email server to demo this works
  // https://ardalis.com/configuring-a-local-test-email-server
  public Task Handle(ToDoItemCompletedEvent domainEvent, CancellationToken cancellationToken)
  {
    Guard.Against.Null(domainEvent, nameof(domainEvent));

    return _emailSender.SendEmailAsync("test@test.com", "test@test.com", $"{domainEvent.CompletedItem.Title} was completed.", domainEvent.CompletedItem.ToString());
  }
}
