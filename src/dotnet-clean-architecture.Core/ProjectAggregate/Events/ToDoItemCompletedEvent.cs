using dotnet_clean_architecture.Core.ProjectAggregate;
using dotnet_clean_architecture.SharedKernel;

namespace dotnet_clean_architecture.Core.ProjectAggregate.Events;

public class ToDoItemCompletedEvent : BaseDomainEvent
{
  public ToDoItem CompletedItem { get; set; }

  public ToDoItemCompletedEvent(ToDoItem completedItem)
  {
    CompletedItem = completedItem;
  }
}
