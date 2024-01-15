using System;
using System.Collections.Generic;

namespace HomeAutomation.Helpers.Desktop.Application.Repositories.Base;

public interface IRepository<TEntity, TDto>
{
    public IList<TDto> GetAll();
    public IList<TDto> GetByPredicate(Func<TEntity, bool> predicate);
    public TDto GetById(Guid id);
    public void AddSingle(TEntity entity);
    public void AddMultiple(IList<TEntity> entities);
    public void Update(TEntity entity);
    public void Delete(Guid id);
}