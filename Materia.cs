using System;

namespace Calificaciones
{
    class Materia
    {


        public int primerParcial;
        public int segundoParcial;
        public int tercerParcial;

        public Materia(int primerParcial, int segundoParcial, int tercerParcial)
        {
            this.primerParcial = primerParcial;
            this.segundoParcial = segundoParcial;
            this.tercerParcial = tercerParcial;

            if (!(primerParcial == 0 || primerParcial >= 5 && primerParcial <= 10))
            {
                throw new ArgumentException("La calificacion del parcial uno debe ser cero o mayor o igual a cinco y menor o igual a diez");
            }

            if (!(segundoParcial == 0 || segundoParcial >= 5 && segundoParcial <= 10))
            {
                throw new ArgumentException("La calificacion del parcial dos debe ser cero o mayor o igual a cinco y menor o igual a diez");
            }

            if (!(tercerParcial == 0 || tercerParcial >= 5 && tercerParcial <= 10))
            {
                throw new ArgumentException("La calificacion del parcial tres debe ser cero o mayor o igual a cinco y menor o igual a diez");
            }
        }

        public float CalcularPromedioParciales()
        {
            float promedioParciales = ((float)primerParcial + (float)segundoParcial) / 2;
            return promedioParciales;
        }

        public float CalcularPromedioFinal()
        {

            float valorpromFinal = 0f;
            valorpromFinal = (CalcularPromedioParciales() + tercerParcial) / 2;

            decimal result;
            result = Convert.ToDecimal(valorpromFinal);

            return (int)Decimal.Round(result);

        }

        public bool RevisarRequiereAplicarEvaluacionExtraordinario()
        {
            if (tercerParcial == 0 || primerParcial == 0 || segundoParcial == 0 || tercerParcial == 5)
            {
                return true;
            }
            else if (CalcularPromedioParciales() < 12)
            {
                return true;
            }
            else if (CalcularPromedioFinal() < 7)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}