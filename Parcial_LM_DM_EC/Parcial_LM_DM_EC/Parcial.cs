using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{

    class Estudiantes
    {
        private int id;
        private String codigo;
        private String nombre;
        private String facultad;
        private String asignatura;
        private int edad;
        private int nota1;
        private int nota2;
        private int notafinal;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Facultad
        {
            get { return facultad; }
            set { facultad = value; }
        }

        public String Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public int Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        public int Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public int NotaFinal
        {
            get { return notafinal; }
            set { notafinal = value; }
        }



        public Estudiantes(int id, String codigo, string nombre, int edad, string facultad, string asignatura, int nota1, int nota2, int notafinal)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
            this.edad = edad;
            this.facultad = facultad;
            this.asignatura = asignatura;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.notafinal = notafinal;


        }

        public string mostrar()
        {
            return id + " " + codigo + " " + nombre + " " + edad + "" + facultad + "" + asignatura + "" + notafinal;
        }
    }

}
