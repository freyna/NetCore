using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("¡Hola Alumnos!");

            using (var db = new AppVentaCursosContext())
            {
                #region Primer ejemplo
                // var cursos = db.Curso.AsNoTracking();
                
                // foreach (var curso in cursos)
                // {
                //     Console.WriteLine(curso.Titulo);
                // }
                #endregion

                #region Segundo ejemplo

                // var cursos = db.Curso.Include(item=>item.InstructorLink).ThenInclude(item=>item.Instructor);

                // foreach(var curso in cursos)
                // {
                //     Console.WriteLine(curso.Titulo);
                //     foreach (var instructorLink in curso.InstructorLink)
                //     {
                //         Console.WriteLine("====> " + instructorLink.Instructor.Nombre);
                //     }
                // }
                #endregion
            
                #region Tercer ejemplo Insert
                // var nuevoInstructor = new Instructor
                // {
                //     Nombre = "Juan",
                //     Apellidos = "Pérez",
                //     Grado = "Master en computación"
                // };

                // db.Add(nuevoInstructor);

                // var nuevoInstructor2 = new Instructor
                // {
                //     Nombre = "José",
                //     Apellidos = "Mariano",
                //     Grado = "Master en computación"
                // };

                // db.Add(nuevoInstructor2);

                // var estadoTransaccion = db.SaveChanges();

                // Console.WriteLine("Estado de la transacción ==>" + estadoTransaccion);

                #endregion
            
                #region Cuarto ejemplo update

                // var instructor = db.Instructor.Single(p=>p.Nombre == "Lorenzo");

                // if(instructor != null)
                // {
                //     instructor.Apellidos = "Castro de Romana";
                //     instructor.Grado = "Biologo con experiencia";

                //     var estadoTransaccion = db.SaveChanges();

                //     Console.WriteLine("El estado de la transacción ==>"+ estadoTransaccion);
                // }
                #endregion
            
                #region Quinto ejemplo delete

                var instructor = db.Instructor.Single(p=>p.InstructorId == 7);

                if(instructor != null)
                {
                    db.Remove(instructor);

                    var estadoTransaccion = db.SaveChanges();

                    Console.WriteLine("Estado de la transacción ==> " + estadoTransaccion);
                }

                #endregion
            }
        }
    }
}
