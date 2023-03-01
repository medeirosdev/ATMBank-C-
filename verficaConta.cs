using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ATMBank
{
    public class verficaConta
    {
        public static async void verificar(){
            Console.WriteLine("Já tem uma conta? se Sim, digite 1, se não, Digite 2 Para Criar uma!");
            int answer = Convert.ToInt32(Console.ReadLine());
            if(answer == 1){
                Console.WriteLine("Qual o numero da sua conta?");
                string cardNn = Console.ReadLine();
                string json = $"{cardNn}.json";
                FileStream openStream = File.OpenRead(json);
                createAccount.accountJson? AccountJson =
                    await JsonSerializer.DeserializeAsync<createAccount.accountJson>(openStream);
                cardHolder AccountJson?.cardHolder = new cardHolder();
                cardHolder.Depositar(AccountJson?.cardN);
            }else{
                createAccount.create();
            }

        }
    }
}