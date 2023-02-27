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
        private double balance;


        public cardHolder(String cardNum , String firstName , String lastName , int pin  , double balance ){
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

        public double getBalance(){
            return balance;
        }

        //Setters Functions ============================================

        public void setPin(int newPin){
            pin = newPin;
        }
        public void setNum(int newCardNum){
            cardNum = newCardNum;
        }
        public void setFirstName(int newFirstName){
            firstName = newFirstName;
        }
        public void setLastName(int newLastName){
            lastName = newLastName;
        }
        public void setBalance(int newBalance){
            balance = newBalance;
        }

        //Métodos==============================================================

        void Depositar(cardHolder user){
            Console.WriteLine("Quanto deseja Depositar?");
            double deposito = Double.Parse(Console.ReadLine());
            user.setBalance(deposito + user.getBalance);
            Console.WriteLine("Obrigado, Adeus, seu dinheiro atual é" + user.getBalance);
        }
    
        void Sacar(cardHolder user){
            Console.WriteLine("Quanto deseja Sacar?");
            double valor = Double.Parse(Console.ReadLine());
            if(int.Parse(valor)>int.Parse(user.getBalance)){
                Console.WriteLine("Quanto deseja Depositar?");
                break;
            }else{
                user.setBalance = int.Parse(user.getBalance) - int.Parse(valor);
                Console.WriteLine("Obrigado!");
            }

        }

        void ShowBalance(cardHolder user){
            Console.WriteLine("Seu saldo" + user.getBalance);
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        //cardHolders.Add(new cardHolder("213124"  "Gui" , "Med" , 123 , 234.7 ));
    }
}