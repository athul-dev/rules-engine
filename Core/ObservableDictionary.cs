using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Core
{
    public class ObservableDictionary<TKey, TValue> : IDictionary<TKey, TValue>, INotifyCollectionChanged
    {
        readonly IDictionary<TKey, TValue> internalDictionary = new Dictionary<TKey, TValue>();

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return internalDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            IList values = new List<KeyValuePair<TKey, TValue>>();
            values.Add(new KeyValuePair<TKey, TValue>(item.Key, item.Value));
            
            internalDictionary.Add(item);

            OnCollectionChanged(NotifyCollectionChangedAction.Add, values);
        }

        public void Clear()
        {
            IList values = new List<KeyValuePair<TKey, TValue>>();
            foreach (var value in internalDictionary)
            {
                values.Add(new KeyValuePair<TKey, TValue>(value.Key, value.Value));
            }
            
            internalDictionary.Clear();
            OnCollectionChanged(NotifyCollectionChangedAction.Reset, values);
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return internalDictionary.Contains(item);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            internalDictionary.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            var b = internalDictionary.Remove(item);
            IList values = new List<KeyValuePair<TKey, TValue>>();
            values.Add(new KeyValuePair<TKey, TValue>(item.Key, item.Value));
            OnCollectionChanged(NotifyCollectionChangedAction.Remove, values);
            return b;
        }

        public int Count => internalDictionary.Count;
        public bool IsReadOnly => internalDictionary.IsReadOnly;
        public bool ContainsKey(TKey key)
        {
            return internalDictionary.ContainsKey(key);
        }

        public void Add(TKey key, TValue value)
        {
            IList values = new List<KeyValuePair<TKey, TValue>>();
            values.Add(new KeyValuePair<TKey, TValue>(key, value));
            internalDictionary.Add(key, value);
            OnCollectionChanged(NotifyCollectionChangedAction.Add, values);
        }

        public bool Remove(TKey key)
        {
            var val = internalDictionary[key];
            IList values = new List<KeyValuePair<TKey, TValue>>();
            values.Add(new KeyValuePair<TKey, TValue>(key, val));
            var b = internalDictionary.Remove(key);
            OnCollectionChanged(NotifyCollectionChangedAction.Remove, values);
            return b;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return internalDictionary.TryGetValue(key, out value);
        }

        public TValue this[TKey key]
        {
            get => internalDictionary[key];
            set
            {
                internalDictionary[key] = value;
                IList values = new List<KeyValuePair<TKey, TValue>>();
                values.Add(new KeyValuePair<TKey, TValue>(key, value));
                OnCollectionChanged(NotifyCollectionChangedAction.Add, values);
            }
        }

        public ICollection<TKey> Keys => internalDictionary.Keys;
        public ICollection<TValue> Values => internalDictionary.Values;

        private void OnCollectionChanged(NotifyCollectionChangedAction action, IList changedItems)
        {
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(action, changedItems));
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}