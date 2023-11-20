using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ForensicBones3.Models
{
    [Table("InventariosEsqueleto")]
    public class InventarioEsqueleto
    {
        [ForeignKey("Relatorio")]
        public int InventarioEsqueletoId { get; set; }

        [Display(Name = "Código do Relatório")]
        public string RelatorioId { get; set; }

        [Display(Name = "Fotos do Esqueleto")]
        public string FotoEsqueleto { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        public Relatorio Relatorio { get; set; }


        [Display(Name = "Inventário Crânio")]
        public InventarioCranio Cranio { get; set; }

        //[Display(Name = "Id Inventário do Crânio")]
        //public int InventarioCranioId { get; set; }

        //[ForeignKey("InventarioCranio")]
        //public InventarioCranio InventarioCranio { get; set; }

    }
}
