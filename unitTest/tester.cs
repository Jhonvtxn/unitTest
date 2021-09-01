using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTest
{
    public static class tester
    {
        
        public static bool VerificaNome(string nome)
        {
            if (nome == "TesteError") return false;
            else
                return true;
        }
        public static bool VerificaIdade(int idade)
        {
            if (idade < 15) return false;
            else
                return true;
        }
        public static bool VerificaEmail(string email)
        {
            var emailUser = "JonSC@gmail.com";

            if (email != emailUser ) return false;
            else
                return true;
        }
    }
}
