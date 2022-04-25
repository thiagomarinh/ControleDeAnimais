using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais
{
    class Animal
    {
        private String nome;

        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        private String tipo;

        public String Tipo
        {
            get { return this.tipo; }
            set 
            { 
                if(value == "cachorro" || value == "gato" || value == "peixe")
                {
                    this.tipo = value;
                }
                else
                {
                    this.tipo = "peixe";
                }
            }


        }

    }
}
