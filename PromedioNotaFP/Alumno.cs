using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioNotaFP
{
    public class Alumno
    {
        double nota1; string nombre; double nota2; double nota3; double promedio;

        public string Pnombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public double Pnota1
        {
            set { nota1 = value; }
            get { return nota1; }
        }
        public double Pnota2
        {
            set { nota2 = value; }
            get { return nota2; }
        }
        public double Pnota3
        {
            set { nota3 = value; }
            get { return nota3; }
        }

        public Alumno()
        {
            nota1 = 0;
            nota2 = 0;
            nota3 = 0;
        }

        public double Promedio()
        {
            promedio = 0;
            promedio = (nota1 + nota2 + nota3) / 3;
            return promedio;
        }
    }
}