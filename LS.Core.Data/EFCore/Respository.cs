using LS.Core.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS.Core.Data.EFCore
{
    public class Respository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        private DbContext _dbContext;
        private DbSet<TEntity> DbSet = null;

        public Respository(DbContext context) 
        {
            _dbContext = context;
            DbSet = _dbContext.Set<TEntity>();
        }

        /// <summary>
        /// 跟踪查询
        /// </summary>
        public IQueryable<TEntity> TrackEntities => DbSet.AsQueryable();

        /// <summary>
        /// 非跟踪查询
        /// </summary>
        public IQueryable<TEntity> Entities => DbSet.AsNoTracking().AsQueryable();

        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public int AddEntities(TEntity entity)
        {
            DbSet.Add(entity);
            return _dbContext.SaveChanges();
        }

        /// <summary>
        /// 移除实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public int DeleteEntities(TEntity entity)
        {
            DbSet.Remove(entity);
            return _dbContext.SaveChanges();
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public int UpdateEntities(TEntity entity)
        {
            DbSet.Update(entity);
            return _dbContext.SaveChanges();
        }
    }
}
