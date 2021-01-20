using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //ctor-->constractor classı newleyince otomatik çalışır
        public MyList()
        {
            items = new T[0];
        }
        //eleman=item
        public void Add(T item)
        {
            //tempArray-- geçiciDizi
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }
            items[items.Length - 1] = item;
        }
    }
}
