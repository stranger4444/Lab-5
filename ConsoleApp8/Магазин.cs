using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Магазин
    {
        public List<Товар> Товари { get; set; }
        public List<Користувач> Користувачі { get; set; }
        public List<Замовлення> Замовлення { get; set; }

        public Магазин()
        {
            Товари = new List<Товар>();
            Користувачі = new List<Користувач>();
            Замовлення = new List<Замовлення>();
        }

        public void ДодатиКористувача(Користувач користувач)
        {
            Користувачі.Add(користувач);
        }

        public void ДодатиТовар(Товар товар)
        {
            Товари.Add(товар);
        }

        public void ОформитиЗамовлення(Користувач користувач, List<Товар> товари, List<int> кількість)
        {
            decimal загальнаВартість = 0;

            for (int i = 0; i < товари.Count; i++)
            {
                decimal ціна = товари[i].Ціна;
                int кільк = кількість[i];
                загальнаВартість += ціна * кільк;
            }

            Замовлення замовлення = new Замовлення(товари, кількість, загальнаВартість);
            Замовлення.Add(замовлення);

            користувач.ІсторіяПокупок.Add(замовлення);
        }

        public List<Товар> ПошукПоЦіні(decimal мінЦіна, decimal максЦіна)
        {
            return Товари.Where(товар => товар.Ціна >= мінЦіна && товар.Ціна <= максЦіна).ToList();
        }

        public List<Товар> ПошукПоКатегорії(string категорія)
        {
            return Товари.Where(товар => товар.Категорія == категорія).ToList();
        }
        public List<Товар> ПошукЗаРейтингом(int рейтинг)
            
            {
                return Товари.Where(товар => товар.Рейтинг == рейтинг).ToList();



            }
        }
    }

