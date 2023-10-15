using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal interface ISearchablee
    {
        List<Товар> ПошукПоЦіні(decimal мінЦіна, decimal максЦіна);
        List<Товар> ПошукПоКатегорії(string категорія);
        List<Товар> ПошукЗаРейтингом(int рейтинг);1
    }
}
