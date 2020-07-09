using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LS.Core.Data.Extention
{
    public static class TaskExtention
    {
        public static Task<T> toTask<T>(this T data)
        {
            return Task.FromResult(data);
        }
    }
}
