﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class PisoDTO
    {
        
        public string Nombre { get; set; }
       
        public string Descripcion { get; set; }
        public int Stock { get; set; }

      
    }
}

