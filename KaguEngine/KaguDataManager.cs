using System.Collections.Generic;

namespace KaguEngine
{
    public class KaguDataManager<K, V>
    {
        protected Dictionary<K, V> _data = new Dictionary<K, V>();

        public void Add(K key, V value)
        {
            _data[key] = value;
        }

        public V Get(K key)
        {
            return _data[key];
        }

        public bool Has(K key)
        {
            return _data.ContainsKey(key);
        }
    }
}