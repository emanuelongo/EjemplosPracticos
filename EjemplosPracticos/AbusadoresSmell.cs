using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosPracticos
{   //DECLARACIONES DE CAMBIO
    internal class AbusadoresSmell
    {
        public string tipo { get; set; }

        public decimal CalcularSalario(int horas)
        {
            decimal salario = 0;
            switch (tipo)
            {
                case "Gerente":
                    salario = horas * 150;
                    break;
                case "Ingeniero":
                    salario = horas * 100;
                    break;
                default:
                    salario = horas * 50;
                    break;
            }
            return salario;
        }
    }
}
