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

            Console.WriteLine("Escolha uma dessas opções");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Mostrar Saldo");
            Console.WriteLine("4 - Sair");

            int number= int.Parse(Console.ReadLine());

            Console.WriteLine("Crie uma conta!");
            Console.WriteLine("numero do cartão!");
            string cardN= Convert.ToString(Console.ReadLine());
            Console.WriteLine("Primeiro Nome:");
            string fName= Convert.ToString(Console.ReadLine());
            Console.WriteLine("último Nome!");
            string lName= Convert.ToString(Console.ReadLine());
            Console.WriteLine("PIN!");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saldo INICIAL");
            double balanc = Convert.ToDouble(Console.ReadLine());

            cardHolder User = new cardHolder(cardN , fName, lName , p , balanc);

            switch(number){
                case 1:
                    cardHolder.Depositar(User);
                    break;  
                case 2:
                    cardHolder.Sacar(User);
                    break;  
                case 3:
                    cardHolder.ShowBalance(User);
                    break;  
                
            }
        }
    }
}