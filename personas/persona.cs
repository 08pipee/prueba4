using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace persona
{
    internal class persona
    {
        public persona(string nombre, DateTime fechanacimiento)
        {
            NOMBRE = nombre;
            FECHANACIMIENTO = fechanacimiento;
        }
        public persona() {}
        private string nombre;
        private DateTime fechanacimiento;
        private string sexo;
        private string color_piel;
        private double estatura;
        private int edad;
        private double peso;



        public string NOMBRE { get => NOMBRE; set => NOMBRE = value; }
        public DateTime FECHANACIMIENTO { get => FECHANACIMIENTO; set => FECHANACIMIENTO = value;}
        public string SEXO { get => SEXO; set => SEXO = value;}
        public string COLORPIEL { get => COLORPIEL; set => COLORPIEL = value;}
        public string COLOROJOS { get => COLOROJOS; set => COLOROJOS = value;}
        public double Estatura { get => Estatura; set => Estatura = value;}
        public int EDAD { get => EDAD; set => EDAD = value;}
        public double PESO { get => PESO; set => PESO = value;}

     
    } 

}
