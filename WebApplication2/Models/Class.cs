﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Class
    {
        [Display(Name = "Podaj liczbe" )]

        public int liczba { get; set; }

        public string odpowiedz;
    }
}