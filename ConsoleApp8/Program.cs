﻿// See https://aka.ms/new-console-template for more information
using ConsoleApp8;


class Program
{
    static void Main()
    {
        
        Магазин магазин = new Магазин();

        
        магазин.ДодатиТовар(new Товар("Ноутбук", 1000, "Потужний ноутбук", "Електроніка",1));
        магазин.ДодатиТовар(new Товар("Смартфон", 500, "Сучасний смартфон", "Електроніка",2));
        магазин.ДодатиТовар(new Товар("Книга", 20, "Цікава книга", "Книги",3));

        
        магазин.ДодатиКористувача(new Користувач("user1", "password1"));
        магазин.ДодатиКористувача(new Користувач("user2", "password2"));

        
        Користувач користувач1 = магазин.Користувачі[0];
        Користувач користувач2 = магазин.Користувачі[1];
        List<Товар> товари1 = магазин.Товари.Where(товар => товар.Категорія == "Електроніка").ToList();
        List<Товар> товари2 = магазин.ПошукЗаРейтингом(3);

        магазин.ОформитиЗамовлення(користувач1, товари1, new List<int> { 1, 2 });
        

        
        foreach (Користувач користувач in магазин.Користувачі)
        {
            Console.WriteLine($"Історія покупок користувача {користувач.Логін}:");
            foreach (Замовлення замовлення in користувач.ІсторіяПокупок)
            {
                Console.WriteLine($"Замовлення на суму {замовлення.ЗагальнаВартість} зі статусом '{замовлення.Статус}'");
            }
        }

        
        List<Товар> дорогіТовари = магазин.ПошукПоЦіні(500, 1000);
        List<Товар> електроніка = магазин.ПошукПоКатегорії("Електроніка");

        Console.WriteLine("Дорогі товари:");
        foreach (Товар товар in дорогіТовари)
        {
            Console.WriteLine($"{товар.Назва} - {товар.Ціна}");
        }

        Console.WriteLine("Товари в категорії 'Електроніка':");
        foreach (Товар товар in електроніка)
        {
            Console.WriteLine($"{товар.Назва} - {товар.Категорія}");
        }
    }
}