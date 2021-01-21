using System.Runtime.Serialization;

namespace MyDictionaryDemo
{
    public class MyDictionary<TKey, TValue>where TKey:notnull
    {
        private TKey[] _keys;
        private TValue[] _values;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public int Length => _keys.Length;
        public TKey[] Keys => _keys;
        public TValue[] Values => _values;


        public void Add(TKey key, TValue value)
        {
            var keys = _keys;
            var values = _values;
            _keys=new TKey[Length+1];
            _values=new TValue[Length];
            for (int i = 0; i < keys.Length; i++)
            {
                _keys[i] = keys[i];
                _values[i] = values[i];
            }

            _keys[Length - 1] = key;
            _values[Length-1] = value;
        }

        public void Insert(int insertIndex, TKey key, TValue value)
        {
            var keys = _keys;
            var values = _values;
            _keys = new TKey[Length + 1];
            _values = new TValue[Length];
            int temp=0;
            for (int i = 0; i < Length; i++)
            {
                if (i == insertIndex)
                {
                    _keys[i] = key;
                    _values[i] = value;
                    temp ++;
                }
                else
                {
                    _keys[i] = keys[i-temp];
                    _values[i] = values[i-temp];
                }
            }

        }

        public void DeleteByKey(TKey key)
        {
            int countOfKey = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_keys[i].Equals(key))
                {
                    countOfKey ++;
                }
            }
            var keys = _keys;
            var values = _values;
            _keys = new TKey[Length - countOfKey];
            _values = new TValue[Length];
            int temp = 0;
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    temp ++;
                }
                else
                {
                    _keys[i - temp] = keys[i];
                    _values[i - temp] = values[i];
                }
            }
        }

        public void DeleteByValue(TValue value)
        {
            int countOfValue = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_values[i].Equals(value))
                {
                    countOfValue++;
                }
            }
            var keys = _keys;
            var values = _values;
            _keys = new TKey[Length - countOfValue];
            _values = new TValue[Length];
            int temp = 0;
            for (int i = 0; i < keys.Length; i++)
            {
                if (values[i].Equals(value))
                {
                    temp++;
                }
                else
                {
                    _keys[i - temp] = keys[i];
                    _values[i - temp] = values[i];
                }
            }
        }
        public void DeleteByIndex(int index)
        {
            var keys = _keys;
            var values = _values;
            _keys = new TKey[Length - 1];
            _values = new TValue[Length];
            int temp = 0;
            for (int i = 0; i < keys.Length; i++)
            {
                if (i==index)
                {
                    temp++;
                }
                else
                {
                    _keys[i - temp] = keys[i];
                    _values[i - temp] = values[i];
                }
            }
        }
    }
}
