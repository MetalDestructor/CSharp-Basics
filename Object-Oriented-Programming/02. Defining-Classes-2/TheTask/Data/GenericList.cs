using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTask.Data
{
    public class GenericList<T>
    {
        public T[] Elements { get; set; }
        public int Size { get; private set; }

        public GenericList(int size)
        {
            this.Size = size;
            this.Elements = new T[size];
        }

        public void Add(T element)
        {
            T[] newCollection;
            if (this.Elements.Length < this.Size)
            {
                int capacity = this.Elements.Length;
                this.Elements[capacity + 1] = element;
            }
            else
            {
                this.Size *= 2;
                newCollection = new T[this.Size];
                int capacity = this.Elements.Length;
                for (int i = 0; i < capacity; i++)
                {
                    newCollection[i] = this.Elements[i];
                }
                newCollection[capacity + 1] = element;
                capacity += 1;
                this.Elements = new T[this.Size];
                for (int i = 0; i < capacity; i++)
                {
                    this.Elements[i] = newCollection[i];
                }                
            }
        }

        public T At(int index)
        {
            return this.Elements[index];
        }

        public void Remove(int index)
        {
            T[] newCollection = new T[this.Size];
            int capacity = this.Elements.Length;
            for (int i = 0; i < index; i++)
            {
                newCollection[i] = this.Elements[i];
            }
            for (int i = index + 1; i < capacity; i++)
            {
                newCollection[i - 1] = this.Elements[i];
            }
            for (int i = 0; i < capacity; i++)
            {
                this.Elements[i] = newCollection[i];
            }
        }


    }
}
