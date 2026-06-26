using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_POO
{
    public class Motocicleta: Vehiculo
    {
        public int Cilindrada { get; set; }
        public Motocicleta(int horas, int cilindrada) : base(horas)
        {
            Cilindrada = cilindrada;
        }
        public Motocicleta() : base()
        {
            Cilindrada = 0;
        }
        public override double CalcularTarifa()
        {
            return horasEstancia * 15.0;
        }
        public override string Describir()
        {
            return $"Motocicleta {Cilindrada}cc con {horasEstancia} horas de estancia.";
        }

    }
}
