using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCache
{
    internal class Cache<Tkey, TData>
    {
        private readonly Dictionary<Tkey, TData> _cachedData = new();

        public TData Get(Tkey key, Func<Tkey, TData> getForTheFirstTime)
        {
            if(!_cachedData.ContainsKey(key))
            {
                _cachedData[key] = getForTheFirstTime(key);
            }

            return _cachedData[key];
        }
    }
}
