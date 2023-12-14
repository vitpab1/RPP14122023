using System.Text;

namespace Vittar.Pablo.RPP
{
    public abstract class Libro
    {
        public enum EClasificacion { Todos, Adolescentes, Adultos };

        protected EClasificacion clasificacion;
        protected bool edicionEspecial; //cambiar
        private string nombre;

    

         protected Libro (string nombre) : this (nombre, edicionEspecial: false)
        {

        }
        protected Libro(string nombre, bool edicionEspecial)
        {
            this.nombre = nombre;
            this.edicionEspecial = edicionEspecial;
        }
        public string Tipo
        {
            get { return GetType().Name; }
        }

        public string Detalle
        {
            get { return AdicionarInformacion(); }
        }

        public abstract void Clasificar(); 

        public override string ToString()
        {
            return $"Nombre: {nombre}, Tipo: {GetType().Name}";
        }
        /// <summary>
        /// Se adiciona informacion sobre el libro 
        /// </summary>
        /// <returns></returns>
        public string AdicionarInformacion()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine($"Nombre: {nombre}");
            info.AppendLine($"Tipo: {GetType().Name}");
            info.AppendLine($"Clasificacion: {clasificacion}");
            info.AppendLine($"Es Edicion Especial: {edicionEspecial}");
            return info.ToString();
        }


        public static bool operator ==(Libro v1, Libro v2)
        {
            return v1 is not null && v2 is not null && v1.GetType() == v2.GetType() && v1.clasificacion == v2.clasificacion && v1.edicionEspecial == v2.edicionEspecial && v1.nombre == v2.nombre;
        }
        public static bool operator !=(Libro v1, Libro v2)
        {

            return !(v1 == v2);
        }
    }
}