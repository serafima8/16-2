using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Ввести две даты и определить количество дней между ними.
            //DateTime date1 = new DateTime(2023, 12, 30);
            //Console.WriteLine(date1);
            //DateTime date2 = new DateTime(2024, 04, 28);
            //Console.WriteLine(date2);
            //Console.WriteLine($"Количество времени между датами: {date2.Subtract(date1)}");


            //2.Определить, сколько дней осталось до конца месяца.
            //Console.WriteLine($"До конца месяца осталось: {DateTime.DaysInMonth(date1.Year, date1.Month) - date1.Day} дней");


            //3.Ввести свою дату рождения.
            //DateTime date3 = new DateTime(2007, 01, 07);


            //a) определить день недели, в котором вы родились.
            //Console.WriteLine($"День недели, в который я родилась: {date3.DayOfWeek}");


            //c) определить, является ли ваш год рождения високосным.
            //if (date3.Year % 4 == 0)
            //{
            //    Console.WriteLine("Год моего рождения является високосным");
            //}
            //else
            //{
            //    Console.WriteLine("Год моего рождения не является високосным");
            //}

            //d) вывести дату ближайшего дня рождения
            //DateTime date4 = new DateTime(2025, 01, 07);
            //Console.WriteLine($"Ближайшая дата рождения: {date4.ToLongDateString()}");


            //e) определить количество полных лет;
            //int age = DateTime.Now.Year - DateTime.Now.Month - date3.Year;
            //Console.WriteLine($"Количество полных лет: {age}");

            //f) определить сколько дней осталось от сегодняшней даты до вашего ближайшего дня рождения
            //TimeSpan z = date4-DateTime.Now;
            //Console.WriteLine($"До ближайшего дня рождения осталость {z} дней");

            Console.ReadKey();
        }
    }
}
