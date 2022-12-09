using System;

namespace BinaryInsertionSort
{
    internal class Stack
    {
        public Item lastItem = null;
        public int size = 0;

        public void Push(int value)
        {
            Item item = new Item(value, lastItem);
            lastItem = item;
            size++;
        }

        public int Pop()
        {
            if (lastItem == null)
            {
                throw new Exception("Stack is empty");

            }
            int val = lastItem.value;
            lastItem = lastItem.prev;
            size--;
            return val;
        }

        public int Get(int index)
        {
            Stack tempStack = new Stack();
            for (int i = size - 1; i > index; i--)
            {
                tempStack.Push(Pop());
            }
            int val = lastItem.value;

            for (int i = tempStack.size; i > 0; i--)
            {
                Push(tempStack.Pop());
            }
            return val;
        }

        public void Set(int index, int val)
        {
            Stack tempStack = new Stack();
            for (int i = size - 1; i > index; i--)
            {
                tempStack.Push(Pop());
            }
            lastItem.value = val;
            for (int i = tempStack.size; i > 0; i--)
            {
                Push(tempStack.Pop());
            }
        }

        public void Print()
        {
            Item item = lastItem;
            while (item != null)
            {
                Console.Write(item.value + ", ");
                item = item.prev;
            }
            Console.WriteLine();

        }
    }
}
