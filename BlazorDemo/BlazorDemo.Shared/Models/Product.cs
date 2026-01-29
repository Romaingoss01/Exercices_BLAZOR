using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Entrez un nom !")]
        public string Nom { get; set; } = "";

        [Required(ErrorMessage = "Choisissez une catégorie")]
        public string Categorie { get; set; } = "";

        [Range(0, 10000, ErrorMessage = "veuillez entrer un prix")]
        public decimal Prix { get; set; }

        [Range(0, 1000, ErrorMessage = "veuillez mettre une quantité")]
        public int Stock { get; set; }

        public bool Actif { get; set; }
    }
}
