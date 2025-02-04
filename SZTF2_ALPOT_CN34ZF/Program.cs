using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF2_ALPOT_CN34ZF
{
    class Program
    {
        public static void Rendeles(string etelNeve, string megrendelo, bool sikerultE)
        {
            if (sikerultE)
            {
                Console.WriteLine($"[{megrendelo}] Az étel elkészült: {etelNeve}");
            }
            else
            {
                Console.WriteLine($"[{megrendelo}] Az étel nem készült el: {etelNeve}");
            }
        }
        static void Main(string[] args)
        {
            Pizza[] pizzas = new Pizza[10];
            ExtraPizza[] extrapizzas = new ExtraPizza[10];

            pizzas[0] = new Pizza("Al Pacino", 800, "Niki");
            pizzas[1] = new Pizza("Macskusz", 1000, "Adrián");
            pizzas[2] = new Pizza("Michael Jackson", 500, "Krisztofer");
            pizzas[3] = new Pizza("Gibson", 4000, "János");
            pizzas[4] = new Pizza("Margharita", 3000, "Elemér");
            pizzas[5] = new Pizza("Elemér", 1200, "Elemér");
            pizzas[6] = new Pizza("Ond", 1000, "Józsi");
            pizzas[7] = new Pizza("Kond", 2500, "Lajos");
            pizzas[8] = new Pizza("Tas", 2000, "Sanyi");
            pizzas[9] = new Pizza("Huba", 1500, "Dávid");

            extrapizzas[0] = new ExtraPizza("Pizzatorony", 10000, "Alajos");
            extrapizzas[1] = new ExtraPizza("Óriás", 5000, "Emil");
            extrapizzas[2] = new ExtraPizza("Víziló", 7000, "Ernő");
            extrapizzas[3] = new ExtraPizza("Vadkacsa", 7500, "Endre");
            extrapizzas[4] = new ExtraPizza("Ló", 8000, "Adrián");

            Konyha<IÉtel> pizzaphone = new Konyha<IÉtel>(100000);
            pizzaphone.RendelesTeljesitve += Rendeles;

            try
            {
                pizzaphone.Megrendeles(pizzas[0]);
                pizzaphone.Megrendeles(pizzas[1]);
                pizzaphone.Megrendeles(pizzas[2]);
                pizzaphone.Megrendeles(pizzas[3]);
                pizzaphone.Megrendeles(pizzas[4]);
                pizzaphone.Megrendeles(pizzas[5]);
                pizzaphone.Megrendeles(pizzas[6]);
                pizzaphone.Megrendeles(pizzas[7]);
                pizzaphone.Megrendeles(pizzas[8]);
                pizzaphone.Megrendeles(pizzas[9]);
                pizzaphone.Megrendeles(extrapizzas[0]);
                pizzaphone.Megrendeles(extrapizzas[1]);
                pizzaphone.Megrendeles(extrapizzas[2]);
                pizzaphone.Megrendeles(extrapizzas[3]);
                pizzaphone.Megrendeles(extrapizzas[4]);
            }
            catch (TúlSokMegrendelés e)
            {
                Console.WriteLine(e.Message);
            }

            pizzaphone.Kiszolgalas(10000);

            Console.ReadKey();
        }
    }
}
