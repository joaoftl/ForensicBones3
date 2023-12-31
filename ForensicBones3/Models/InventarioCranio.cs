﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForensicBones3.Models
{
    [Table("InventariosCranio")]
    public class InventarioCranio
    {
        [ForeignKey("InventarioEsqueleto")]
        public int InventarioCranioId { get; set; }

        [Display(Name = "Código do Inventário")]
        public string InventarioEsqueletoId { get; set; }

        [Display(Name = "Fotos do Crânio")]
        public string FotoCranio { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        public InventarioEsqueleto InventarioEsqueleto { get; set; }
    }
}
