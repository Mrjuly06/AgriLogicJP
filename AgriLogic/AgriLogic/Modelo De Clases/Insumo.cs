﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriLogic.Modelo_De_Clases
{
    public class Insumo
    {
        // Propiedades del insumo
        public int InsumoID { get; set; }
        public string NombreInsumo { get; set; }
        public int CantidadDisponible { get; set; }
        public string UnidadMedida { get; set; }
        public DateTime FechaUltimoReabastecimiento { get; set; }
    }
}

    
