﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Direccion
    {
        public int IdDireccion { get; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
        public int Piso { get; set; }
        public string Departamento { get; set; }
        public Localidad Localidad { get; set; }
        public Provincia Provincia { get; set; }
        public Pais Pais { get; set; }


        public override string ToString()
        {
            return Calle + "("+ Localidad.Descripcion + ")" ;
        }
    }
}
