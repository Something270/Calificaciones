using System;

namespace Calificaciones
{
    class Criterio
    {
        public string nombre;

        public float porcentaje;

        public Criterio(string nombre, float porcentaje)
        {
            if (nombre == "" || nombre == null)
            {
                throw new ArgumentException("El nombre es requerido");
            }
            if (!(porcentaje > 0f && porcentaje <= 1f))
            {
                throw new ArgumentException("El porcentaje debe ser mayor que cero y menor o igual que uno");
            }
            this.nombre = nombre;
            this.porcentaje = porcentaje;
        }
    }
}