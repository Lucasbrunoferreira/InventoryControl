﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSale { get; set; }

        [Required]
        public string TipoVenda { get; set; }
        [Required]
        public string DataVenda { get; set; }
        [Required]
        public int IdClient { get; set; }
        [Required]
        public int IdContribuitor { get; set; }


    }
}
