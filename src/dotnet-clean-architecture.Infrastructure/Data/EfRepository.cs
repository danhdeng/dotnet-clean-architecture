using Ardalis.Specification.EntityFrameworkCore;
using dotnet_clean_architecture.SharedKernel.Interfaces;

namespace dotnet_clean_architecture.Infrastructure.Data;

// inherit from Ardalis.Specification type
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
  public EfRepository(AppDbContext dbContext) : base(dbContext)
  {
  }
}
