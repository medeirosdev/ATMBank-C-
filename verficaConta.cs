using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATMBank
{
    public class verficaConta
    {
        public static void verificar(){
            Console.WriteLine("Já tem uma conta? se Sim, digite 1, se não, Digite 2 Para Criar uma!");
            int answer = Convert.ToInt32(Console.ReadLine());
            if(answer == 1){
            }else{
                createAccount.create();
            }

        }
    }
}