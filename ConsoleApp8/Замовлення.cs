using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Замовлення
    {
        public List<Товар> Товари { get; set; }
        public List<int> Кількість { get; set; }
        public decimal ЗагальнаВартість { get; set; }
        public string Статус { get; set; }

        public Замовлення(List<Товар> товари, List<int> кількість, decimal загальнаВартість)
        {
            Товари = товари;
            Кількість = кількість;
            ЗагальнаВартість = загальнаВартість;
            Статус = "Очікує на обробку";
        }
    }
}
