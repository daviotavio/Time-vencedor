using System;

namespace time_vencedor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um código que leia o nome de dois times e o número de gols marcados na partida (para cada time). O nome do vencedor deverá ser escrito. Caso não haja um, deverá ser impressa a palavra “empate”

            string time1,time2;
            int golsTime1,golsTime2;

            Console.Write("Qual time jogou ontem? ");
            time1 = Console.ReadLine();

            Console.Write(time1 + " Jogou contra quem? ");
            time2 = Console.ReadLine();

            Console.Write("Quantos gols o " + time1 + " fez? ");
            golsTime1 = int.Parse(Console.ReadLine());

            Console.Write("E o " + time2 + ", fez quantos gols? ");
            golsTime2 = int.Parse(Console.ReadLine());

            //Estruturas condicionais

            if (golsTime1 > golsTime2)
            {
                Console.Write(time1 + " venceu o jogo!");
            } 
            else if (golsTime2 > golsTime1)
            {
                Console.Write(time2 + " venceu o jogo");
            }
            else
            {
                Console.Write("Deu empate");
            }
        }
    }
}
