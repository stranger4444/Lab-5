using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Товар
    {
        public string Назва { get; set; }
        public decimal Ціна { get; set; }
        public string Опис { get; set; }
        public string Категорія { get; set; }
        public int Рейтинг { get; set; }


        public Товар(string назва, decimal ціна, string опис, string категорія, int рейтинг)
        {
            Назва = назва;
            Ціна = ціна;
            Опис = опис;
            Категорія = категорія;
            Рейтинг = рейтинг;

        }
    }
}
