using System.ComponentModel.DataAnnotations;

namespace dotnet_clean_architecture.Web.Endpoints.ProjectEndpoints;

public class CreateProjectRequest
{
  public const string Route = "/Projects";

  [Required]
  public string? Name { get; set; }
}
