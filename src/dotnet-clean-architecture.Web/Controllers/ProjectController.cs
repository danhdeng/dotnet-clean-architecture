﻿using dotnet_clean_architecture.Core.ProjectAggregate;
using dotnet_clean_architecture.Core.ProjectAggregate.Specifications;
using dotnet_clean_architecture.SharedKernel.Interfaces;
using dotnet_clean_architecture.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_clean_architecture.Web.Controllers;

[Route("[controller]")]
public class ProjectController : Controller
{
  private readonly IRepository<Project> _projectRepository;

  public ProjectController(IRepository<Project> projectRepository)
  {
    _projectRepository = projectRepository;
  }

  // GET project/{projectId?}
  [HttpGet("{projectId:int}")]
  public async Task<IActionResult> Index(int projectId = 1)
  {
    var spec = new ProjectByIdWithItemsSpec(projectId);
    var project = await _projectRepository.GetBySpecAsync(spec);
    if (project == null)
    {
      return NotFound();
    }

    var dto = new ProjectViewModel
    {
      Id = project.Id,
      Name = project.Name,
      Items = project.Items
                    .Select(item => ToDoItemViewModel.FromToDoItem(item))
                    .ToList()
    };
    return View(dto);
  }
}
