using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_solid_transporte
{
    public class Tren : ITransporte
    {
        private string _nombre;
        private int _velocidadActual;
        private int _velocidadMaxima;

        public Tren(string nombre, int velocidadActual, int velocidadMaxima)
        {
            _nombre = nombre;
            _velocidadActual = velocidadActual;
            _velocidadMaxima = velocidadMaxima;
        }

        public int  getVelocidadActual()
        {
            return _velocidadActual;
        }

        public void Acelerar(int velocidad)
        {
            if ((this._velocidadActual + velocidad) <= this._velocidadMaxima)
            {
                this._velocidadActual += velocidad;
            }
        }

        public void Desacelerar(int velocidad)
        {
            if ((this._velocidadActual - velocidad) >= 0)
            {
                this._velocidadActual -= velocidad;
            }
            else
            {
                this._velocidadActual = 0;
            }
        }

    }
}
