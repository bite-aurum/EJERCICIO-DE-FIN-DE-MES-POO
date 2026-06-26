using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_POO
{
    internal class Camioneta: Vehiculo
    {
        public int NumeroEjes;

        public int NumeroEjes
        {
            get { return NumeroEjes; }
            set { NumeroEjes = value; }
        }

        public Camioneta(int horas, int ejes) : base(horas)
        {
            this.NumeroEjes = ejes;
        }

        public Camioneta(): base()
        {
            NumeroEjes = 2;
        }


        public override double CalcularTarifa()
        {
            return horasEstancia = 45.0;
        }

        public override string Describir()
        {
            return $"Camioneta con {NumeroEjes} ejes, {horasEstancia} horas de estancia:";
        }
    }
}
