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

            int number= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Crie uma conta!");
            //===============================================
            Console.WriteLine("numero do cartão!");
            string cardN;
            do{
                cardN = Convert.ToString(Console.ReadLine());
                if(cardN == null){
                    continue;
                }else{
                    break;
                }
            }
            while(cardN == null);
            //===============================================
            string lName;
            Console.WriteLine("Primeiro Nome:");
            do{
                lName = Convert.ToString(Console.ReadLine());
                if(lName == null){
                    continue;
                }else{
                    break;
                }
            }while(lName == null);
            //===============================================
            Console.WriteLine("último Nome!");
            string fName;
            do{
                fName = Convert.ToString(Console.ReadLine());
                if(fName == null){
                    continue;
                }else{
                    break;
                }
            }while(fName == null);
            Console.WriteLine("PIN!");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saldo INICIAL");
            decimal balanc = Convert.ToDecimal(Console.ReadLine());

            cardHolder User = new cardHolder(cardN , fName, lName , p , balanc);

            switch(number){
                case 1:
                    cardHolder.Depositar(User);
                    printOptions();
                    break;  
                case 2:
                    cardHolder.Sacar(User);
                    printOptions();
                    break;  
                case 3:
                    cardHolder.ShowBalance(User);
                    printOptions();
                    break;  
                
            }
        }
    }
}