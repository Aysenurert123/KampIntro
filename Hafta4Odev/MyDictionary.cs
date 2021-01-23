using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta4Odev
{
    class MyDictionary<K, V>
    {
        K[] ıd;
        K[] tempId;
        V[] name;
        V[] tempName;
        public MyDictionary()
        {
            ıd = new K[0];
            name = new V[0];

        }
        public void Add(K key, V value)
        {
            tempId = ıd;
            tempName = name;

            ıd = new K[ıd.Length + 1];
            name = new V[name.Length + 1];
            for (int i = 0; i < tempName.Length; i++)
            {
                name[i] = tempName[i];
                ıd[i] = tempId[i];
            }
            name[name.Length - 1] = value;
            ıd[ıd.Length - 1] = key;

            Console.WriteLine("ID:" + key + " İsim:" + value + " BAŞARIYLA EKLENDİ.");
        }

    }
    }
