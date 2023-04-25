using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_solid_transporte
{
    public interface ITransporte
    {
        public void Acelerar(int velocidad);
        public void Desacelerar(int velocidad);
    }
}
