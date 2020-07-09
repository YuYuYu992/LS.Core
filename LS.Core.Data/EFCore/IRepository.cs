using LS.Core.Data.Entity;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LS.Core.Data.EFCore
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        #region【同步方法】
        /// <summary>
        ///跟踪查询实体，用于增删改时需要用到跟踪查询
        /// </summary>
        IQueryable<TEntity> TrackEntities { get; }

        /// <summary>
        ///非跟踪查询实体
        /// </summary>
        IQueryable<TEntity> Entities { get; }

        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        int AddEntities(TEntity entity);

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        int UpdateEntities(TEntity entity);

        /// <summary>
        /// 移除实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        int DeleteEntities(TEntity entity);
        #endregion【同步方法】


    }
}
