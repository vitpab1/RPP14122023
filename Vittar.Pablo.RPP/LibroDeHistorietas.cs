using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vittar.Pablo.RPP;

namespace Entidades
{
    public class LibroDeHistorietas : Libro 
    {
        private bool ilustracionesColoridas; 

        public LibroDeHistorietas(string nombre, bool ilustracionesColoridas) : base(nombre, ilustracionesColoridas)
        {
            this.ilustracionesColoridas = ilustracionesColoridas; 
            Clasificar();
            edicionEspecial = true; 
        }
        public override void Clasificar()
        {
            clasificacion = EClasificacion.Todos;
        }
        public new string AdicionarInformacion()
        {
            string edicion = ilustracionesColoridas ? "Edicion Rayo Cromatico" : "Edicion Maestro MonoCromo";
            string baseInfo = base.AdicionarInformacion();
            return string.Format("{0} - {1}", baseInfo, edicion);
        }
    }
}
