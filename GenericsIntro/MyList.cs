﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        // constructor 
        public MyList()
        {
            items = new T[0];// diziyi 0 elemanlı yaptık
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];// eleman sayısını 1 arttırdık.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; // istenen eleman eklendi.
        }


        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }


}
