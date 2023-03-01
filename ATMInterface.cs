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
            Console.WriteLine("=========================");
            Console.WriteLine("Escolha uma dessas opções");
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Mostrar Saldo");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("=========================");
            int number= Convert.ToInt32(Console.ReadLine());
            


            switch(number){
                case 1:
                    verficaConta.verificar();
                    //cardHolder.Depositar(User);
                    printOptions();
                    break;  
                case 2:
                    //cardHolder.Sacar(User);
                    printOptions();
                    break;  
                case 3:
                    //cardHolder.ShowBalance(User);
                    printOptions();
                    break;  
                
            }
        }
    }
}