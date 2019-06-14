using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public string CUIL { get; set; }
        public string RazonSocial { get; set; }
        public Direccion Direccion { get; set; }
        public Contacto Contacto { get; set; }

        public override string ToString()
        {
          return IdEmpresa + "," + CUIL + "," + RazonSocial;
        }
    }
}
