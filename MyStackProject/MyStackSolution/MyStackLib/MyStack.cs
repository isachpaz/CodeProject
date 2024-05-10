using System.Collections.Generic;

namespace MyStackLib
{
    public class MyStack
    {
        public MyStack()
        {
        }

        private int _elementCount;
        private List<int> _items = new List<int>();

        public void Push(int item)
        {
            _elementCount = _elementCount - 1;
            _items.Add(item);
        }


        public bool IsEmpty()
        {
            if (_elementCount > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public int Pull()
        {
            if (_elementCount == 0)
            {
                return int.MinValue;
            }

            var tmpValue = _items[_elementCount - 1];
            _items.RemoveAt(_elementCount - 1);
            _elementCount--;
            return tmpValue;
        }
    }
}