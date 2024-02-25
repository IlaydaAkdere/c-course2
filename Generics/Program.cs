using NPOI.SS.Formula.Functions;
using System;
using System.Threading.Tasks;

namespace Generics
{
    class program
    {
        static void Main(string[] args)
        {

            List<string> sehirler = new List<string>();
            sehirler.Add("ıstanbul");
            sehirler.Add("ıstanbul");
            sehirler.Add("ıstanbul");
            sehirler.Add("ıstanbul");
            sehirler.Add("ıstanbul");
            sehirler.Add("ıstanbul");
            sehirler.Add("ıstanbul");
            //Console.WriteLine(sehirler.Count);



            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Istanbul");
            sehirler2.Add("Istanbul");
            sehirler2.Add("Istanbul");
            sehirler2.Add("Istanbul");
            sehirler2.Add("Istanbul");
            sehirler2.Add("Istanbul");
            sehirler2.Add("Istanbul");
            sehirler2.Add("Istanbul");
            sehirler2.Add("Istanbul");

            Console.WriteLine(sehirler2.Count);
            //sehirler2.Add("Istanbul");


        }
    }
    class MyList // Generic Class
    {
        T[] _array;
        T[] emparray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _temparray = array;
            _array = new T[_array.Length + i];
            for (int i = 0; i < _temparray.Length; i++)
            {
                _array[i] = _temparray[i];
            }
            _array[_array.Length - 1]];
        }
        public void Add(T item)
        {
            _array = new T[_array.Length + i];


        public int count
        {
            get { return _array.Length; }
        }
    }

    //internal class T
    //{

//}