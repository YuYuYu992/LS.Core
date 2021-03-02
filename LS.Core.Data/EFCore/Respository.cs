using LS.Core.Data.Entity;
using LS.Core.Data.SQLDataConnect;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS.Core.Data.EFCore
{


    public class Respository<TEntity> : IRespository<TEntity> 
        where TEntity : EntityBase
    {
        private DbContext _dbContext;
        private DbSet<TEntity> DbSet = null;
        public Respository()
        {
            var context = Loatar.Instance().GetService(typeof(StudentDataBase));
            _dbContext = context as DbContext;
            DbSet = _dbContext.Set<TEntity>();
        }

        #region【同步方法】
        /// <summary>
        ///跟踪查询实体
        /// </summary>
        public IQueryable<TEntity> TrackEntities => DbSet.AsQueryable();

        /// <summary>
        /// 非跟踪查询实体
        /// </summary>
        public IQueryable<TEntity> Entities => DbSet.AsNoTracking().AsQueryable();

        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public int AddEntity(TEntity entity)
        {
            DbSet.Add(entity);
            return _dbContext.SaveChanges();
        }

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public int UpdateEntity(TEntity entity)
        {
            DbSet.Update(entity);
            return _dbContext.SaveChanges();
        }

        /// <summary>
        /// 移除实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public int RemoveEntity(TEntity entity)
        {
            DbSet.Remove(entity);
            return _dbContext.SaveChanges();
        }
        #endregion【同步方法】
    }
}
