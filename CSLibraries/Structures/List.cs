namespace CSLibraries.Structures
{
    public class List<T>
    {
        private T[] content;
        private int capacity;

        /// <summary>
        /// Get of set list's data capacity that structure can hold without resizing.
        /// </summary>
        public int Capacity
        {
            get => capacity;
            set
            {
                int iterator;
                T[] newContent = new T[value];
                if (value > capacity) iterator = capacity - 1;
                else iterator = value - 1;
                while(iterator > -1)
                {
                    newContent[iterator] = content[iterator];
                    iterator--;
                }
                content = newContent;
                capacity = value;
            }
        }

        /// <summary>
        /// Get count of all elements inside the list.
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// Get or set element at specified index.
        /// </summary>
        /// <param name="index">Index to edit.</param>
        /// <returns>Value at specified index</returns>
        /// TODO: Coder la fonction
        public T this[int index]
        {
            get => content[index];
            set => content[index] = value;
        }

        /// <summary>
        /// Add element at the end of the List.
        /// </summary>
        /// <param name="newItem">The element to add</param>
        /// TODO: Coder la fonction
        public void Add(T newItem)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Delete all the elements from the List.
        /// </summary>
        /// TODO: Coder la fonction
        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Used to find an item in List.
        /// </summary>
        /// <param name="item">Item to be found</param>
        /// <returns>true if the item was found, otherwise false.</returns>
        /// TODO: Coder la fonction
        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Find and specified object index in the list.
        /// </summary>
        /// <param name="item">item to be located</param>
        /// <returns>The index of the founded item, otherwise -1</returns>
        /// TODO: Coder la fonction
        public int IndexOf(T item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Insert given item at specified index.
        /// </summary>
        /// <param name="item">Element to insert</param>
        /// <param name="index">Index to put the new element</param>
        /// TODO: Coder la fonction
        public void Insert(T item, int index)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Initialize a new instance of List class which is empty and got default capacity.
        /// </summary>
        public List()
        {
            content = new T[20];
            capacity = 20;
            Count = 0;
        }

        /// <summary>
        /// Initialize a new instance of List class which is empty and got specified capacity.
        /// </summary>
        /// <param name="capacity">Capacity of the new list</param>
        public List(int newCapacity)
        {
            content = new T[capacity];
            capacity = newCapacity;
            Count = 0;
        }

        /// <summary>
        /// Remove first occurence of specified element.
        /// </summary>
        /// <param name="item">Element to remove</param>
        /// TODO: Coder la fonction
        public void Remove(T item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Remove element at specified index from List.
        /// </summary>
        /// <param name="index">Index of the object to remove</param>
        /// TODO: Coder la fonction
        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Reverse order of the elements in list.
        /// </summary>
        /// TODO: Coder la fonction
        public void Reverse()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Give a string that symbolize the List.
        /// </summary>
        /// <returns>a string that symbolize the List.</returns>
        public override string ToString()
        {
            if (Count == 0)
                return "| |";

            string ret = "|";
            foreach(T element in content)
            {
                if (element == null)
                    ret += "  |";
                else
                    ret += $" {element.ToString()} |";
            }
            return ret;
        }
    }
}
