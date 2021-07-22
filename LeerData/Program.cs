using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola Alumnos!");

            using (var db = new AppVentaCursosContext())
            {
                #region Primer ejemplo
                // var cursos = db.Curso.AsNoTracking();
                
                // foreach (var curso in cursos)
                // {
                //     Console.WriteLine(curso.Titulo);
                // }
                #endregion

                var cursos = db.Curso.Include(item=>item.InstructorLink).ThenInclude(item=>item.Instructor);

                foreach(var curso in cursos)
                {
                    Console.WriteLine(curso.Titulo);
                    foreach (var instructorLink in curso.InstructorLink)
                    {
                        Console.WriteLine("====> " + instructorLink.Instructor.Nombre);
                    }
                }
            }
        }
    }
}
