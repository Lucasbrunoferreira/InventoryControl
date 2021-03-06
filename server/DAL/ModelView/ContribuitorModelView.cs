﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.ModelView
{
    public class ContribuitorModelView
    {

        //public Boolean StatusContribuitor { get; set; }
        public string Nome { get; set; }
        [Required]
        public string Usuario { get; set; }
        public string Senha { get; set; }
        [Required]
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        [Required]
        public DateTime DataCadastro { get; set; }
        [Required]
        public int IdSector { get; set; }


    }
}
