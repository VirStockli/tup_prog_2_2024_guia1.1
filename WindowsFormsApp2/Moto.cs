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
        public string Marca;
        public int Modelo;
        public double ValorFabricacion;

        public void CrearMoto(string marca, int modelo, double valorFabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorFabricacion;
        }
        public double CalcularDepreciacionLineal(int añoaCalcular, int vidaUtil)
        {
            double tasaDepreciacion = ValorFabricacion - (ValorFabricacion * (ValorFabricacion / vidaUtil));

            return tasaDepreciacion;
        }
        public double CalcularDepreciacionAnual(int añoaCalcular, double tasaDepreciacion)
        {
            return Math.Pow(ValorFabricacion * (1 - tasaDepreciacion),añoaCalcular);
        }


        public string VerDescripcion()
        {
            return $"Marca: {Marca} - Modelo: {Modelo} - Valor Fabricación ${ValorFabricacion}";
        }
    }
}
