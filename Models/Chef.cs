﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Katzavia.Models
{
    public class Chef
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
    }
}
