namespace BinaryInsertionSort
{
    internal class Item
    {
        public int value = 0;
        public Item prev = null;

        public Item(int value, Item prev)
        {
            this.value = value;
            this.prev = prev;
        }
    }
}
