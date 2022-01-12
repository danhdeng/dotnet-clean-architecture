using Ardalis.Specification;

namespace dotnet_clean_architecture.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
