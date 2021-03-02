using System;
using System.Collections.Generic;
using System.Text;

namespace LS.Core.Data.EFCore
{
    public class Loatar
    {
        private static Lazy<Loatar> loatar = new Lazy<Loatar>(() => new Loatar());

        public static Loatar Instance() => loatar.Value;
        private IServiceProvider Provider;
        public void SerProvider(IServiceProvider serviceProvider)
        {
            Provider = serviceProvider;
        }

        public object GetService(Type type)
        {
            return Provider.GetService(type);
        }

    }
}
