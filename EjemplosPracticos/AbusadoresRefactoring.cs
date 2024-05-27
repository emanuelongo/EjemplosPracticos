using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPracticos
{   //REEMPLAZAR CONDICIONAL CON POLIMORFISMO
    public abstract class Empleado
    {
        public abstract decimal CalcularSalario(int horas);
    }
    public class Gerente : Empleado
    {
        public override decimal CalcularSalario(int horas)
        {
            return horas * 150;
        }
    }

    public class Ingeniero : Empleado
    {
        public override decimal CalcularSalario(int horas)
        {
            return horas * 100;
        }
    }

    public class Asistente : Empleado
    {
        public override decimal CalcularSalario(int horas)
        {
            return horas * 50;
        }
    }
    
    
}
