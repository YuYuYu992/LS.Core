using LS.Core.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS.Core.Data.EFCore
{
    public interface IRespository<TEntity> where TEntity :EntityBase
    {
        #region【同步方法】
        /// <summary>
        ///跟踪查询实体
        /// </summary>
        IQueryable<TEntity> TrackEntities { get; }

        /// <summary>
        /// 非跟踪查询实体
        /// </summary>
        IQueryable<TEntity> Entities { get; }

        /// <summary>
        /// 新增实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        int AddEntity(TEntity entity);

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        int UpdateEntity(TEntity entity);

        /// <summary>
        /// 移除实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        int RemoveEntity(TEntity entity);
        #endregion【同步方法】
    }
}
