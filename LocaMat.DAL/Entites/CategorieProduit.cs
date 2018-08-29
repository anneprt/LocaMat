﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMat.Business
{
    [Table("CategoriesProduits")]

    public class CategorieProduit
    {
        public int Id { get; set; }
        public string Nom { get; set; }

    }
}
