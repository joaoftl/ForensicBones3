using System.ComponentModel.DataAnnotations;
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

        public int Frontal { get; set; }
        public int Ocipital { get; set; }
        public int Esfenoide { get; set; }
        public int Maxilar { get; set; }
        public int Vomer { get; set; }
        [Display(Name = "Parietal Esquerdo")]
        public int ParietalEsq { get; set; }
        [Display(Name = "Temporal Esquerdo")]
        public int TemporalEsq { get; set; }
        [Display(Name = "Concha Nasal Esquerda")]
        public int ConchaNasalEsq { get; set; }
        [Display(Name = "Etmoide Esquerdo")]
        public int EtmoideEsq { get; set; }
        [Display(Name = "Lacrimal Esquerdo")]
        public int LacrimalEsq { get; set; }
        [Display(Name = "Nasal Esquerdo")]
        public int NasalEsq { get; set; }
        [Display(Name = "Zigomatico Esquerdo")]
        public int ZigomaticoEsq { get; set; }
        [Display(Name = "Parietal Direito")]
        public int ParietalDir { get; set; }
        [Display(Name = "Temporal Direito")]
        public int TemporalDir { get; set; }
        [Display(Name = "Concha Nasal Direito")]
        public int ConchaNasalDir { get; set; }
        [Display(Name = "Etmoide Direito")]
        public int EtmoideDir { get; set; }
        [Display(Name = "Lacrimal Direito")]
        public int LacrimalDir { get; set; }
        [Display(Name = "Zigomático Direito")]
        public int ZigomaticoDir { get; set; }
        public int Hioide { get; set; }

        [Display(Name = "Cartilagem Tireóide")]
        public int CartilagemTireoide { get; set; }

        [Display(Name = "Mandíbula")]
        public int Mandibula { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        public InventarioEsqueleto InventarioEsqueleto { get; set; }
    }
}
