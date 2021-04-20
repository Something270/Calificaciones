using System;
using System.Collections.Generic;
using System.Linq;

namespace Calificaciones
{
    class Parcial
    {

        public List<Criterio> criterios = new List<Criterio>();




        public void AgregarCriterio(Criterio criterio)
        {
            this.criterios.Add(criterio);
        }


        public bool ValidarSumaCriterios(float porcentaje)
        {
            float SumCriterios = 0f;

            for (int i = 0; i < this.criterios.Count; i++)
            {
                SumCriterios = SumCriterios + this.criterios[i].porcentaje;

            }
            if (SumCriterios == 1.0f)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public bool ValidarCriteriosDistintos()
        {

            var hashset = new HashSet<string>();
            var duplicates = new HashSet<string>();
            var count = 0;
            foreach (var criterio in criterios)
            {
                if (!hashset.Add(criterio.nombre))
                {
                    count++;

                    if (duplicates.Add(criterio.nombre))
                    {

                    }
                }
            }
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool ValidarCriteriosDefinidos()
        {

            int total = 0;
            foreach (Criterio criterio in criterios)
            {
                total = criterios.Count;
            }

            if (total != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int CalcularCalificacion(List<float> calificacionesDeCadaCriterio)
        {
            float ValorDeCalificacion = 0f;
            for (int i = 0; i < this.criterios.Count; i++)
            {
                ValorDeCalificacion = ValorDeCalificacion + (float)calificacionesDeCadaCriterio[i] * (float)criterios[i].porcentaje;
            }

            decimal result;
            result = Convert.ToDecimal(ValorDeCalificacion);

            return (int)Decimal.Round(result);
        }
    }
}