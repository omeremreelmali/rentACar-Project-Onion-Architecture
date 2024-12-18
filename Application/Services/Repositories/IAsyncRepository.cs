using System.Linq.Expressions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;

namespace Application.Services.Repositories;

public interface IAsyncRepository<TEntity, TId> where TEntity : BaseEntity<TId>
{
    Task<TEntity?> GetByIdAsync(
        Expression<Func<TEntity, bool>> predicate,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity,object>>? include = null,bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default);
    
}