using Autofac;
using dotnet_clean_architecture.Core.Interfaces;
using dotnet_clean_architecture.Core.Services;

namespace dotnet_clean_architecture.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
