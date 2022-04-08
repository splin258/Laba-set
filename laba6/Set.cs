using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    public class Set
    {
        public int[] mas;
        public int size;
        public int capacity;
       
        public int getSize() //Текущий размер массива
        {
            return this.size;
        }

        public int getCapacity() //Вместимость массива
        {
            return this.capacity;
        }

        public int getElem(int i) //Получение элемента
        {
            return this.mas[i];
        }

        public void resize() //Расширение массива
        {
            int[] tmp_arr = new int[capacity * 2];
            for (int i = 0; i < size; i++)
            {
                tmp_arr[i] = mas[i];
            }
            this.mas = tmp_arr;
            capacity *= 2;
        }

        public bool findX(int X) //поиск элемента
        {
            for (int i = 0; i < size; i++)
            {
                if (mas[i] == X)
                {
                    return true;
                }
            }
            return false;
        }

        public void add(int X) //Добавление уникальных элементов
        {
            if (!findX(X))
            {
                mas[size] = X;
                size++;
                if (size == capacity)
                {
                    resize();
                }
            }
        }
        public Set Intersection(Set a) //пересечение множеств
        {
            Set rezult = new Set();
            rezult.mas = new int[capacity];
            for (int i = 0; i < this.getSize(); i++)
            {
                for (int j = 0; j < a.getSize(); j++)
                {
                    if (this.getElem(i) == a.getElem(j))
                    {
                        rezult.add(this.getElem(i));
                        break;
                    }
                }
            }
            return rezult;
        }

        public Set Combine(Set a) //объединение множеств
        {
            Set rezult = new Set();
            rezult.mas = new int[capacity];
            for (int i = 0; i < size; i++)
            {
                rezult.add(this.getElem(i));
            }
            for (int i = 0; i < a.getSize(); i++)
            {
                rezult.add(a.getElem(i));
            }
            return rezult;
        }
    }

};  
