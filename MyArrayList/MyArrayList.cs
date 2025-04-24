using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayList
{
    class MyArrayList
    {

        private int Index;
        object[] MyList = new object[4];
        public MyArrayList()
        {
            Index = 0;
        }
        public void Add(object obj)
        {
            //Yeni öğe sona eklenir
           if(Index == MyList.Length){ RangeControl(); }
            MyList[Index] = obj;
            Index++;
        }

        public void Insert(int index, object obj)
        {
            //Belirtilen indekse bir öğe eklenir, diğer öğeler sağa kaydırılır.
            if(index > Index||index<0) { throw new ArgumentOutOfRangeException("Index is out of range"); }
            if (Index == MyList.Length) { RangeControl(); }
            object temp = MyList[index];
            for (int i = Index - 1; i >= index; i--)
            {
                MyList[i + 1] = MyList[i];
            }
            MyList[index] = obj;
            Index++;
        }

        public void RemoveAt(int index)
        {
            // Belirtilen indeksdeki öğe kaldırılır.
            if (index >= Index || index < 0) { throw new ArgumentOutOfRangeException("Index is out of range"); }
            MyList[index] = null;
            Index--;
            for (int i = index; i < Index; i++)
            {
                MyList[i] = MyList[i + 1];
            }
        }

        public object Get(int index)
        {
            //Belirtilen indeksteki öğeyi döndürür.
            if (index >= Index || index < 0) { throw new ArgumentOutOfRangeException("Index is out of range"); }
            return MyList[index] != null ? MyList[index] : "Belirtilen index boş";
        }

        public int Count()
        {
            //Listede bulunan öğe sayısını döndürür.
            return Index;
        }

        public override string ToString()
        {
            //Listedeki öğeleri virgül ile ayrılmış bir biçimde döndürür.
            string res = "[";
            for (int i = 0; i < Index; i++)
            {
                res += MyList[i];
                if (i + 1 != Index)
                {
                    res += ",";
                }
            }
            res += "]";
            return res;
        }

        public void RangeControl()
        {
            Array.Resize(ref MyList, MyList.Length*2);
        }
    }
}
