using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_3
{
    public class Participante
    {
        public int NroParticipante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Tiempo { get; set; }
        public int Altura { get; set; }
        public string Categoria { get; set; }

        public Participante(int Nro)
        {
            this.NroParticipante = Nro;
            this.Categoria = "Sin Categoria";
        }
    }
}