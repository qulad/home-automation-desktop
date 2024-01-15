using System;
using System.Collections.Generic;
using System.Linq;
using HomeAutomation.Helpers.Desktop.Core.Context;
using HomeAutomation.Helpers.Desktop.Core.Entities.Base;

namespace HomeAutomation.Helpers.Desktop.Core.Repositories.Base;

public abstract class BaseRepositery<TEntity> where TEntity : BaseEntity
{
    protected readonly HomeAutomationDesktopHelperDbContext _dbContext;

    protected BaseRepositery(HomeAutomationDesktopHelperDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual void AddMultiple(IList<TEntity> entities)
    {
        _dbContext.Set<TEntity>().AddRange(entities);
        _dbContext.SaveChanges();
    }

    public virtual void AddSingle(TEntity entity)
    {
        _dbContext.Set<TEntity>().Add(entity);
        _dbContext.SaveChanges();
    }

    public virtual IEnumerable<TEntity> GetAllEntites()
    {
        return _dbContext.Set<TEntity>();
    }

    public virtual IEnumerable<TEntity> GetEntitesByPredicate(Func<TEntity, bool> predicate)
    {
        return _dbContext.Set<TEntity>().Where(predicate);
    }

    public virtual TEntity GetEntityById(Guid id)
    {
        return _dbContext.Set<TEntity>().Find(id);
    }

    public virtual void Update(TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);
        _dbContext.SaveChanges();
    }

    public virtual void Delete(Guid id)
    {
        var entity = _dbContext.Set<TEntity>().Find(id);

        if (entity is not null)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}