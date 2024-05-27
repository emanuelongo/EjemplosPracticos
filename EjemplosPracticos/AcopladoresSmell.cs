using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPracticos
{   //INTIMIDAD INAPROPIADA
    public class AcopladoresSmell
    {
        public int devolverNumeroNecesario()
        {
            return 1;
        }
    }
    public class Numero
    {
        AcopladoresSmell acopladores = new AcopladoresSmell();
        public Numero()
        {
            this.acopladores = acopladores;
        }
        int numero = acopladores.Numero();

    }
}
