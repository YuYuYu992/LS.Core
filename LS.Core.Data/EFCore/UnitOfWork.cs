﻿using LS.Core.Data.Extention;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LS.Core.Data.EFCore
{
    public class UnitOfWork<TDbContext> : IUnitOfWork where TDbContext : DbContext
    {
        private bool _isbeintransaction;
        private IDbContextTransaction transaction = null;
        private TDbContext _dbcontext;
        //private readonly ILogger logger = LogManager.GetLogger<UnitOfWork<TDbContext>>();

        public UnitOfWork(TDbContext Context)
        {
            _dbcontext = Context ?? throw new ArgumentNullException(nameof(Context));
        }

        /// <summary>
        /// 是否开启事务
        /// </summary>
        public bool BeginTransaction
        {
            get
            {
                return _isbeintransaction;
            }
            set
            {
                if (value)
                    transaction = _dbcontext.Database.BeginTransaction();
                _isbeintransaction = value;
            }
        }

        /// <summary>
        /// 事务同步提交
        /// </summary>
        /// <returns></returns>
        public bool CommitTransaction()
        {
            bool result = false;
            try
            {
                transaction.Commit();
            }
            catch (Exception ex)
            {
                //logger.LogError($"事务提交上下文出错:{ex.Message}, stack :{ex.StackTrace} ,source: {ex.Source}");
                transaction.Rollback();
                throw;
            }
            return result;
        }

        /// <summary>
        /// 事务异步提交
        /// </summary>
        /// <returns></returns>
        public async Task<bool> CommitTransactionAsync()
        {
            bool result = false;
            try
            {
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                //logger.LogError($"异步事务提交上下文出错:{ex.Message}, stack :{ex.StackTrace} ,source: {ex.Source}");
                await transaction.RollbackAsync();
                throw;
            }
            return await result.toTask();
        }
    }
}
