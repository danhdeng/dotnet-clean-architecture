namespace dotnet_clean_architecture.Web.Endpoints.ProjectEndpoints;

public record ToDoItemRecord(int Id, string Title, string Description, bool IsDone);
