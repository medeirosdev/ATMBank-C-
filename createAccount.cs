using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ATMBank
{
    public class createAccount
    {
        public class accountJson {
            public string cardN { get; set; } 
            public string lName  { get; set; } 
            public string fName { get; set; } 
            public int pin { get; set; } 
            public decimal balanc { get; set; } 
        }

        public static void create(){
    
            //===============================================
            Console.WriteLine("numero do cartão!");
                string cardN = Console.ReadLine();
            //=================================================
            string path = @$"D:\Projetos\C#\ATMBank\{cardN}.json";
            //===============================================
            if(!File.Exists(path)){
                //Create a fille to store the data ==========
                StreamWriter sw = File.CreateText(path);
            }
            //===============================================
            Console.WriteLine("Primeiro Nome:");
            string lName = Console.ReadLine().ToString();
            //===============================================
            Console.WriteLine("último Nome!");
            string fName = Console.ReadLine();
            //===============================================
            Console.WriteLine("PIN!");
            int p = Convert.ToInt32(Console.ReadLine());
            //===============================================
            Console.WriteLine("Saldo INICIAL");
            decimal balanc = Convert.ToDecimal(Console.ReadLine());
            //===============================================
            //============Salvar Dados Json==================
            //===============================================
            var accountJsons = new accountJson {
                cardN = cardN,
                lName = lName,
                fName = fName,
                pin = p ,
                balanc = balanc

            };
            //===============================================
            string jsonString = JsonSerializer.Serialize(accountJsons);
            Console.WriteLine(jsonString);
            string text = $"{cardN} : " + jsonString + ",";
            File.WriteAllText(path , text);
            




        }

        
    }
}