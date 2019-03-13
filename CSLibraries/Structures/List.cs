using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLibraries.Structures
{
    public class List<T>
    {
        private T[] content;

        private int capacity;
        /// <summary>
        /// Get of set list's data capacity that structure can hold without resizing.
        /// </summary>
        /// TODO: Coder la suite de tests
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
        /// Get or set element at specified index.
        /// </summary>
        /// <param name="index">Index to edit.</param>
        /// <returns>Value at specified index</returns>
        /// TODO: Coder la fonction
        /// TODO: Coder la suite de tests
        public T this[int index]
        {
            get => content[index];
            set => content[index] = value;
        }

        /// <summary>
        /// Add element at the end of the List.
        /// </summary>
        /// <param name="newItem">The element to add</param>
        public void Add(T newItem)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Delete all the elements from the List.
        /// </summary>
        /// TODO: Coder la fonction
        /// TODO: Coder la suite de tests
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
        /// TODO: Coder la suite de tests
        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Get number of elements contains in List.
        /// </summary>
        /// TODO: Coder la suite de tests
        public int GetCount()
        {
            int count = 0;
            foreach (T element in content)
                count++;
            return count;

        }

        /// <summary>
        /// Find and specified object index in the list.
        /// </summary>
        /// <param name="item">item to be located</param>
        /// <returns>The index of the founded item, otherwise -1</returns>
        /// TODO: Coder la fonction
        /// TODO: Coder la suite de tests
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
        /// TODO: Coder la suite de tests
        public void Insert(T item, int index)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Initialize a new instance of List class which is empty and got default capacity.
        /// </summary>
        /// TODO: Coder la fonction
        /// TODO: Coder la suite de tests
        public List()
        {
            content = new T[20];
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Initialize a new instance of List class which is empty and got specified capacity.
        /// </summary>
        /// <param name="capacity">Capacity of the new list</param>
        /// TODO: Coder la fonction
        /// TODO: Coder la suite de tests
        public List(int capacity)
        {
            content = new T[capacity];
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Remove first occurence of specified element.
        /// </summary>
        /// <param name="item">Element to remove</param>
        /// TODO: Coder la fonction
        /// TODO: Coder la suite de tests
        public void Remove(T item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Remove element at specified index from List.
        /// </summary>
        /// <param name="index">Index of the object to remove</param>
        /// TODO: Coder la fonction
        /// TODO: Coder la suite de tests
        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Reverse order of the elements in list.
        /// </summary>
        /// TODO: Coder la fonction
        /// TODO: Coder la suite de tests
        public void Reverse()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Give a string that symbolize the List.
        /// </summary>
        /// <returns>a string that symbolize the List.</returns>
        /// TODO: Coder la suite de tests
        public override string ToString()
        {
            string ret = "|";
            for(int iterator = 0; iterator < capacity; iterator++)
            {
                ret += content[iterator] + "|";
            }
            return ret;
        }
    }
}
