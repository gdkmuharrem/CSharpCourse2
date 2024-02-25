using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İStanbul");
            sehirler2.Add("İStanbul");
            sehirler2.Add("İStanbul");
            sehirler2.Add("İStanbul");
            sehirler2.Add("İStanbul");
            sehirler2.Add("İStanbul");
            Console.WriteLine(sehirler2.Count);

            Console.ReadLine();
        }
    }
    class MyList <T> // <T> bu classı artık Generic bir class yaptı yani dışardan aldığını tipi direkt olarak koda uygulayacak.
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            /*
                Her yeni veri eklendiğinde dizimizi newleyip genişletmemiz gerekmekte fakat bu da demek oluyor ki newlediğimiz zaman
            dizimizdeki tüm değer kaybolacak bunun önüne geçebilmek için önce dizideki verileri temp isimli geçici dizimize aktarıyoruz,
            daha sonra dizimizi newleyip eski verileri yerine yerleştiriyoruz.
             */
            _tempArray = _array;
            _array = new T[_array.Length+1]; // Her yeni veri eklendiğinde newliyoruz.
            for (int i =0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length-1] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }

    }
}
