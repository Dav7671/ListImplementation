using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            _List _list = new _List();
            _list.Add(10);
            _list.Add(11);
            _list.Add(12);
            _list.Add(13);
            _list.Add(14);

            _list.Insert(3, 36);    

            foreach(var item in _list)
            {
                Console.WriteLine(item);
            }

            ListOfWeekDays days = new ListOfWeekDays();
            foreach  (string item in days)
            {
                Console.WriteLine(item);
            }
        
           
            Console.ReadKey();
        }
    }
}
