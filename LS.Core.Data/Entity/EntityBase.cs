using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LS.Core.Data.Entity
{
    public class EntityBase
    {
        private string _Id = Extention.EngineExtention.GetGuid();
        private DateTime _createTime = Extention.EngineExtention.GetDateTime();

        public string Id 
        {
            get 
            {
                return _Id;
            }
            set 
            {
                _Id = value;
            }
        }

        public DateTime CreateTime
        {
            get
            {
                return _createTime;
            }
            set
            {
                _createTime = value;
            }
        }
    }
}
