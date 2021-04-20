using System;
using NUnit.Framework;

namespace Calificaciones
{
    [TestFixture]
    class MateriaTest
    {

        [Test, Description("Se validan correctamente las calificaciones de los parciales para crear una Materia")]
        public void TestCalificacionesParciales()
        {
            Assert.DoesNotThrow(
               () =>
               {
                   Materia UserExperience = new Materia(7, 9, 10);
                   Materia MultiPublicidad = new Materia(0, 8, 9);
                   Materia Disenio = new Materia(9, 9, 10);
               }
           );

            Assert.Throws<ArgumentException>(
                 () =>
                 {
                     Materia UserExperience = new Materia(7, -6, 9);
                     Materia MultiPublicidad = new Materia(-9, 30, 9);
                     Materia Disenio = new Materia(0, 2, 12);
                     Materia RecDePatrones = new Materia(0, 1, 9);
                 }
             );
        }

        [Test, Description("Se calcula correctamente el promedio de los primeros 2 parciales")]
        public void TestPromedioParciales()
        {
            Materia UserExperience = new Materia(7, 8, 10);
            Assert.That(UserExperience.CalcularPromedioParciales(), Is.EqualTo(7.5f));
            Materia MultiPublicidad = new Materia(6, 6, 10);
            Assert.That(MultiPublicidad.CalcularPromedioParciales(), Is.EqualTo(6f));
        }

        [Test, Description("Se calcula correctamente el promedio final")]
        public void TestPromedioFinal()
        {
            Materia UserExperience = new Materia(8, 7, 9);
            Assert.That(UserExperience.CalcularPromedioFinal(), Is.EqualTo(8));
            Materia MultiPublicidad = new Materia(5,5,8);
            Assert.That(MultiPublicidad.CalcularPromedioFinal(), Is.EqualTo(6));
        }

        [Test, Description("Se indica correctamente cuando se requiere aplicar evaluación extraordinaria")]
        public void TestEvaluacionExtraordinario()
        {
            Materia UserExperience = new Materia(7, 5, 8);
            Assert.That(UserExperience.RevisarRequiereAplicarEvaluacionExtraordinario(), Is.EqualTo(true));
            Materia MultiPublicidad = new Materia(6, 5, 10);
            Assert.That(MultiPublicidad.RevisarRequiereAplicarEvaluacionExtraordinario(), Is.EqualTo(true));
            Materia Disenio = new Materia(10, 10, 9);
            Assert.That(Disenio.RevisarRequiereAplicarEvaluacionExtraordinario(), Is.EqualTo(true));
        }
    }
}