using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vittar.Pablo.RPP.Libro;
using Vittar.Pablo.RPP;

namespace Entidades
{
    public class LibroDeMisterio : Libro
    {
        private static Random random = new Random();

        public LibroDeMisterio(string nombre, bool edicionEspecial) : base(nombre, edicionEspecial)
        {
            this.edicionEspecial = edicionEspecial; 
            Clasificar();
        }

        public override void Clasificar()
        {
            int randomNumber = random.Next(2); 
            clasificacion = (randomNumber == 0) ? EClasificacion.Adolescentes : EClasificacion.Adultos;
        }
    }
}
