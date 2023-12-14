using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vittar.Pablo.RPP;

namespace Entidades
{
 

    public class LibroDeCienciaFiccion : Libro
    {
        public enum ENivelDificultad { Baja, Media, Alta };
        private ENivelDificultad nivelDificultad;
 
        public LibroDeCienciaFiccion(string nombre ) : base(nombre)
        {
            Clasificar();
        }
        public override void Clasificar()
        {
            switch (nivelDificultad)
            {
                case ENivelDificultad.Baja:
                    clasificacion = EClasificacion.Todos;
                    break;
                case ENivelDificultad.Media:
                    clasificacion = EClasificacion.Adolescentes;
                    break;
                case ENivelDificultad.Alta:
                    clasificacion = EClasificacion.Adultos;
                    break;
                default:
                    throw new ArgumentException("Dificultad no valida ");
            }
        }

        public new string AdicionarInformacion()
        {
            string baseInfo = base.AdicionarInformacion();
            return $"{baseInfo} - Nivel de Dificultad: {nivelDificultad}";
        }
    }
}
