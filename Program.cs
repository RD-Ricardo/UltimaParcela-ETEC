using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            double valueF ,  respValue; 
            int valueQ ;      
            Console.WriteLine("------------------");
            Console.WriteLine("--Ultima Parcela--");
            Console.WriteLine("------------------");
            Console.Write("Valor Total do financiamento:");
            valueF = Convert.ToDouble(Console.ReadLine());
            Console.Write("Valor Total do financiamento:");
            valueQ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            respValue = valueF / valueQ;
            DateTime dateNow = new DateTime(2020, 05 ,13);  
            DateTime date = dateNow.AddMonths(valueQ).Date;
            string dateText = date.ToShortDateString();
            Console.WriteLine($"Sua ultima parcela será em  {dateText}, no valor de R$ {respValue}  ");
        }
    }
}
