using System;
using System.Collections.Generic;
using System.Linq;
using HomeAutomation.Helpers.Desktop.Core.Entities.Base;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using HomeAutomation.Helpers.Desktop.Application.Repositories.Base;

namespace HomeAutomation.Helpers.Desktop.Core.Repositories.Base;

public abstract class BaseRepositery<TEntity, TDto> : IRepository<TEntity, TDto> where TEntity : BaseEntity where TDto : BaseDataTransferObject
{
    protected readonly DbContext _dbContext;

    private readonly IMapper _singleMapper;
    private readonly IMapper _listMapper;

    protected BaseRepositery(DbContext dbContext)
    {
        _dbContext = dbContext;

        var singleConfiguration = new MapperConfiguration(mc =>
            mc.CreateMap<TEntity, TDto>());

        var listConfiguration = new MapperConfiguration(mc =>
            mc.CreateMap<IList<TEntity>, IList<TDto>>());

        _singleMapper = singleConfiguration.CreateMapper();
        _listMapper = listConfiguration.CreateMapper();
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

    public virtual IEnumerable<TDto> GetAll()
    {
        return _listMapper.Map<IList<TEntity>, IList<TDto>>(_dbContext.Set<TEntity>().ToList());
    }

    public virtual IEnumerable<TDto> GetByPredicate(Func<TEntity, bool> predicate)
    {
        return _listMapper.Map<IList<TEntity>, IList<TDto>>(_dbContext.Set<TEntity>().Where(predicate).ToList());
    }

    public virtual TDto GetById(Guid id)
    {
        return _singleMapper.Map<TEntity, TDto>(_dbContext.Set<TEntity>().Find(id));
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