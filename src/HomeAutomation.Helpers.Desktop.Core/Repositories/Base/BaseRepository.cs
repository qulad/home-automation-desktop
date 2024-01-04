using System;
using System.Collections.Generic;
using System.Linq;
using HomeAutomation.Helpers.Desktop.Core.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace HomeAutomation.Helpers.Desktop.Core.Repositories.Base;

public abstract class BaseRepositery<TEntity> where TEntity : BaseEntity
{
    protected readonly DbContext _dbContext;

    protected BaseRepositery(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual IEnumerable<TEntity> GetAll()
    {
        return _dbContext.Set<TEntity>().ToList();
    }

    public virtual IEnumerable<TEntity> GetByPredicate(Func<TEntity, bool> predicate)
    {
        return _dbContext.Set<TEntity>().Where(predicate).ToList();
    }

    public virtual TEntity GetById(Guid id)
    {
        return _dbContext.Set<TEntity>().Find(id);
    }
    public virtual void Add(TEntity entity)
    {
        _dbContext.Set<TEntity>().Add(entity);
        _dbContext.SaveChanges();
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