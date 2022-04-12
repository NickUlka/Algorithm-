using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите баланс проездной карты");
            int balance = Convert.ToInt32(Console.ReadLine());
            int costvar = 50; //стоимость проезда
            int cost = costvar;
            if (balance >= cost)
            {
                int counter = 3; //max количество прохода через турникет
                int i = counter;
                do
                {
                    i--;
                    Console.Write("Проход открыт? да/нет - ");
                    string doorOpen = Console.ReadLine();
                    if (doorOpen == "да" || doorOpen == "Да" || doorOpen == "ДА")
                    {
                        balance = balance - cost;
                        Console.WriteLine($"Пожалуйста, проходите. Ваш баланс - {balance}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Перейдите к следующему турникету");
                        if (i == 0)
                        {
                            Console.WriteLine("У Вас неисправная карта. Ее необходимо заменить!");
                        }
                    }
                }
                while (i != 0);  
            }
            else
            {
                Console.WriteLine($"Стоимость проезда - {cost}. Ваш баланс - {balance}. Необходимо пополнить карту.");
            }
        }
        
}
}
