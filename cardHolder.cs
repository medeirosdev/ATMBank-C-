using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATMBank
{
    public class cardHolder
    {
        private String cardNum;
        private String firstName;
        private String lastName;
        private int pin;
        private decimal balance;


        public cardHolder(String cardNum , String firstName , String lastName , int pin  , decimal balance ){
            this.cardNum = cardNum;
            this.balance = balance;
            this.firstName= firstName;
            this.lastName = lastName;
            this.pin = pin;

        }
        //Getter Functions ============================================
        public String getNum(){
            return cardNum;
            }

        public int getPin(){
            return pin;
            }

        public string getFirstName(){
            return firstName;
        }
        public string getLastName(){
            return lastName;
        }

        public decimal getBalance(){
            return balance;
        }

        //Setters Functions ============================================

        public void setPin(int newPin){
            pin = newPin;
        }
        public void setNum(string newCardNum){
            cardNum = newCardNum;
        }
        public void setFirstName(string newFirstName){
            firstName = newFirstName;
        }
        public void setLastName(string newLastName){
            lastName = newLastName;
        }
        public void setBalance(decimal newBalance){
            balance = newBalance;
        }

        //Métodos==============================================================

        public static void Depositar(cardHolder user){
            Console.WriteLine("Quanto deseja Depositar?");
            decimal deposito = Convert.ToDecimal(Console.ReadLine());
            user.setBalance(deposito + user.getBalance());
            Console.WriteLine("Obrigado, Adeus, seu dinheiro atual é" + user.getBalance());
        }
    
        public static void Sacar(cardHolder user){
            Console.WriteLine("Quanto deseja Sacar?");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            decimal userB = user.getBalance();
            if(valor>userB){
                Console.WriteLine("Não");
            }else{
                user.setBalance(userB - valor);
                Console.WriteLine("Obrigado!");
            }


        }

        public static void ShowBalance(cardHolder user){
            decimal userB = user.getBalance();
            Console.WriteLine("Seu saldo" + userB);
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        //cardHolders.Add(new cardHolder("213124"  "Gui" , "Med" , 123 , 234.7 ));
    }
}