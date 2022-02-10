using System;
using System.Collections.Generic;
using System.Text;

namespace Pensonato
{
    class Quartos
    {
        public string Nome;
        public string Email;
        

        public Quartos(string nome, string email)
        {
            Nome = nome;
            Email = email;
            
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }





    }
}
