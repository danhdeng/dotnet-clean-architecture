using System.Collections.Generic;
using System.Threading.Tasks;
using Ardalis.Result;
using dotnet_clean_architecture.Core.ProjectAggregate;

namespace dotnet_clean_architecture.Core.Interfaces;

public interface IToDoItemSearchService
{
  Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
  Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
}
