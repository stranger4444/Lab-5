using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Користувач
    {
        public string Логін { get; set; }
        public string Пароль { get; set; }
        public List<Замовлення> ІсторіяПокупок { get; set; }

        public Користувач(string логін, string пароль)
        {
            Логін = логін;
            Пароль = пароль;
            ІсторіяПокупок = new List<Замовлення>();
        }
    }
}
