using System;

namespace OldProqect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("КУ, Здаррррррррррррррррррррррв\n, " +
                "у меня тут топ банк и тебе над пооложить немнорго лавэ ,\n ну надеюсь ты же понимаешь?))\n Так вот прикол в том что чем больше положешь тем больше проццццццццццццццццццццццетов набежит ,\n тк что рааааааааааааааааасчихляйся");
            Console.WriteLine( "Введите плс скок положите:");
            Console.WriteLine("===Используйте запятую для дроби===");
            double vkladSum = Convert.ToDouble(Console.ReadLine());
            double vkladWithProc = 0;
            if (vkladSum < 100) 
            {
                vkladWithProc = vkladSum + (vkladSum * 0.05);
                Console.WriteLine($"Твои мани через год:\n {vkladWithProc}");
            }
            if (vkladSum >= 100 & vkladSum <= 200)
            {
                vkladWithProc = vkladSum + (vkladSum * 0.07);
                Console.WriteLine($"Твои мани через год:\n {vkladWithProc}");
            }
            else 
            {
                vkladWithProc = vkladSum + (vkladSum * 0.1);
                Console.WriteLine($"Твои мани через год:\n {vkladWithProc}");
            }
        }
    }
}
