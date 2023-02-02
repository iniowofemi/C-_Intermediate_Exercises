using System;
using System.Collections.Generic;

namespace StackDesign
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();  
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You can't add a null object to the stack.");

            _list.Add(obj);
            int entries = _list.Count;

            if (entries > 1)
            {
                for (int i = entries - 1; i > 0; i--)
                {
                    _list[i] = _list[i - 1];
                }
                _list[0] = obj;
            }
            
        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("There's no entries in the stack yet.");
            
            object toReturn = _list[0];

            _list.RemoveAt(0);
            
            return (toReturn);
        }

        public void Clear()
        {
            for (int i = 1; i < _list.Count; i++)
            {
                _list.RemoveAt(0);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }
}
