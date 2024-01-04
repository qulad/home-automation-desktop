using System;
using System.Collections.Generic;

namespace HomeAutomation.Helpers.Desktop.Core.Repositories.Base;

public interface IRepositery<TEntity>
{
    IEnumerable<TEntity> GetAll();
    IEnumerable<TEntity> GetByPredicate(Func<TEntity, bool> predicate);
    TEntity GetById(Guid id);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(Guid id);
}