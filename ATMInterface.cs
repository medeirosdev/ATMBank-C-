using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATMBank
{
    public class ATMInterface
    {
        public void printOptions()

        {
            cardHolder cardHolder = new cardHolder();

            Console.WriteLine("Escolha uma dessas opções");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Mostrar Saldo");
            Console.WriteLine("4 - Sair");

            int number= int.Parse(Console.ReadLine());

            Console.WriteLine("Crie uma conta!");
            Console.WriteLine("numero do cartão!");
            string cardN= Console.ReadLine();
            Console.WriteLine("Primeiro Nome:");
            string fName= Console.ReadLine();
            Console.WriteLine("último Nome!");
            string lName= Console.ReadLine();
            Console.WriteLine("PIN!");
            int p = Console.ReadLine();
            Console.WriteLine("Saldo INICIAL");
            double balanc = Console.ReadLine();
            //(String cardNum , String firstName , String lastName , int pin  , double balance )
            cardHolder User = new cardHolder(cardN , fName, lName , p , balanc);

            switch(number){
                case 1:
                    cardHolder.Depositar(User);
                case 2:
                    cardHolder.Sacar(User);
                case 3:
                    cardHolder.ShowBalance(User);

                default:
                    Console.WriteLine("Adeus");
            }
        }
    }
}