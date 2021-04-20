using System;
using System.Collections.Generic;

namespace Calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Parcial primerParcial = new Parcial();
            primerParcial.AgregarCriterio(new Criterio("Trabajo", 0.25f));
            primerParcial.AgregarCriterio(new Criterio("Practicas", 0.25f));
            primerParcial.AgregarCriterio(new Criterio("Participacion/Esfuerzo", 0.1f));
            primerParcial.AgregarCriterio(new Criterio("Proyecto", 0.4f));
            Parcial segundoParcial = new Parcial();
            segundoParcial.AgregarCriterio(new Criterio("Trabajo", 0.25f));
            segundoParcial.AgregarCriterio(new Criterio("Practicas", 0.25f));
            segundoParcial.AgregarCriterio(new Criterio("Participacion/Esfuerzo", 0.1f));
            segundoParcial.AgregarCriterio(new Criterio("Proyecto", 0.4f));
            Parcial tercerParcial = new Parcial();
            tercerParcial.AgregarCriterio(new Criterio("Trabajo", 0.25f));
            tercerParcial.AgregarCriterio(new Criterio("Practicas", 0.25f));
            tercerParcial.AgregarCriterio(new Criterio("Participacion/Esfuerzo", 0.1f));
            tercerParcial.AgregarCriterio(new Criterio("Proyecto", 0.4f));


            List<float> calificacionCriteriosPrimerParcial = new List<float>();
            calificacionCriteriosPrimerParcial.Add(8);
            calificacionCriteriosPrimerParcial.Add(9);
            calificacionCriteriosPrimerParcial.Add(10);
            calificacionCriteriosPrimerParcial.Add(9);
            int calificacionPrimerParcial = primerParcial.CalcularCalificacion(calificacionCriteriosPrimerParcial);

            List<float> calificacionCriteriosSegundoParcial = new List<float>();
            calificacionCriteriosSegundoParcial.Add(8);
            calificacionCriteriosSegundoParcial.Add(9);
            calificacionCriteriosSegundoParcial.Add(10);
            calificacionCriteriosSegundoParcial.Add(9);
            int calificacionSegundoParcial = segundoParcial.CalcularCalificacion(calificacionCriteriosSegundoParcial);

            List<float> calificacionCriteriosTercerParcial = new List<float>();
            calificacionCriteriosTercerParcial.Add(8);
            calificacionCriteriosTercerParcial.Add(9);
            calificacionCriteriosTercerParcial.Add(10);
            calificacionCriteriosTercerParcial.Add(9);
            int calificacionTercerParcial = tercerParcial.CalcularCalificacion(calificacionCriteriosTercerParcial);

            Materia teoriaDeLaComputacion = new Materia(calificacionPrimerParcial, calificacionSegundoParcial, calificacionTercerParcial);

        }
    }
}
