﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario
    {
        public int CdUsuario { get; set; }
        public string DsLogin { get; set; }
        public string DsSenha { get; set; }
        public bool Administrador { get; set; }
    }
}
