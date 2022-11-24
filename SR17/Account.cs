using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR17
{
    internal class Account<T>
    {
        private T Num { get; set; }
        private string Name { get; set; }
        private int Balance { get; set; }

        public string GetInfo()
        {
            return $"{Num} {Name} {Balance}";
        }
        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            Balance = Convert.ToInt32(Console.ReadLine());
        }
    }
}
