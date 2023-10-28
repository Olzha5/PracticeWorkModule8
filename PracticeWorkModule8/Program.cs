using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWorkModule8
{
    internal class Program
    {
        static void zadasha1()
        {
            // Создание экземпляра RangeOfArray с индексами от -3 до 3
            RangeOfArray myArray = new RangeOfArray(-3, 3);

            // Заполнение массива значениями
            for (int i = -3; i <= 3; i++)
            {
                myArray[i] = i; // Значения равны их индексам
            }

            // Вывод содержимого массива
            Console.WriteLine("Элементы массива:");
            for (int i = -3; i <= 3; i++)
            {
                Console.WriteLine($"myArray[{i}] = {myArray[i]}");
            }
        }
        static void zadasha2()
        {
            // Создаём список цен на продукты
            List<double> prices = new List<double> { 100, 200, 50, 75 }; // Примерные цены

            // Получаем текущее время
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            // Создаём экземпляр класса Supermarket
            Supermarket supermarket = new Supermarket();

            // Рассчитываем общую стоимость с учетом возможной скидки
            double total = supermarket.CalculateTotal(prices, currentTime);

            // Выводим результат
            Console.WriteLine($"Общая сумма покупок: {total} KZT.");
        }
        static void zadasha3()
        {
            double[] pastSales = { 150, 200, 250, 300, 350 }; // Объем продаж за последние 5 месяцев
            SalesForecast forecast = new SalesForecast();
            double[] predictions = forecast.PredictNextThreeMonths(pastSales);

            Console.WriteLine("Прогноз на следующие три месяца:");
            foreach (var prediction in predictions)
            {
                Console.WriteLine(prediction);
            }

        }
        static void Main(string[] args)
        {
            zadasha1 ();
            zadasha2 ();
            zadasha3 ();
        }
    }
}
