﻿
namespace dotnet_clean_architecture.Web.Endpoints.ProjectEndpoints;

public class ProjectListResponse
{
  public List<ProjectRecord> Projects { get; set; } = new();
}