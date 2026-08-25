using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_c_01
{
    class Cache<TKey, TValue>
    {
        private class CacheItem
        {
            public TValue Value { get; set; }
            public DateTime Expiration { get; set; }
        }

        private Dictionary<TKey, CacheItem> items =
            new Dictionary<TKey, CacheItem>();

        public void Add(TKey key, TValue value, TimeSpan expiration)
        {
            items[key] = new CacheItem
            {
                Value = value,
                Expiration = DateTime.Now.Add(expiration)
            };
        }

        public TValue Get(TKey key)
        {
            if (!items.ContainsKey(key))
                return default;

            CacheItem item = items[key];

            if (DateTime.Now > item.Expiration)
            {
                items.Remove(key);
                return default;
            }

            return item.Value;
        }

        public void Remove(TKey key)
        {
            items.Remove(key);
        }

        public bool Contains(TKey key)
        {
            if (!items.ContainsKey(key))
                return false;

            if (DateTime.Now > items[key].Expiration)
            {
                items.Remove(key);
                return false;
            }

            return true;
        }
    }
}
