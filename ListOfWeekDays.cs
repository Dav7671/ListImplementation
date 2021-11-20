using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFunctions
{
    class ListOfWeekDays
    {
        private string[] _items = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        public Enumerator GetEnumerator()
        {
            return new Enumerator(_items, _items.Length);
        }

        public class Enumerator
        {
            private int _size;
            private int _count = 0;
            private string[] _items;

            public Enumerator(string[] items, int size)
            {
                _items = items;
                _size = size;
            }

            public object Current { get => _items[_count++]; }
            public bool MoveNext()
            {
                return _count < _size;
            }
            
            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
        
    }
}
