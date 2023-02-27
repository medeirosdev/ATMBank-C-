using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATMBank
{
    public class ATMInterface
    {
        void printOptions()
        {
            Console.WriteLine("Escolha uma dessas opções");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Mostrar Saldo");
            Console.WriteLine("4 - Sair");
        }
    }
}