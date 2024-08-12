using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Moto
    {
        public string Marca { get; private set; }
        public int Modelo { get; private set; }
        public double ValorFabricacion { get; private set; }

        public Moto(string marca, int modelo, double valorFabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }
        public double CalcularDepreciacionLineal(int añoaCalcular, int vidaUtil)
        {
            double añosdeuso = añoaCalcular - Modelo;
            double ValorActualizado = ValorFabricacion - (ValorFabricacion * (añosdeuso / vidaUtil));

            return ValorActualizado;
        }
        public double CalcularDepreciacionAnual(int añoaCalcular, double tasaDepreciacion)
        {
            double añosdeuso = añoaCalcular - Modelo;
            double ValorActualizado = ValorFabricacion * Math.Pow((1 - tasaDepreciacion), añosdeuso);
            return ValorActualizado;
        }

        public string VerDescripcion()
        {
            string descripcion = $"Marca: {Marca} - Modelo: {Modelo} - Valor Fabricación U$S{ValorFabricacion}";
            return descripcion;
        }

        //HELP HELP HELP SOS
    }
}
