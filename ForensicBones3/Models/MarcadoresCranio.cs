using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ForensicBones3.Models
{
    [Table("MarcadoresCranios")]
    public class MarcadoresCranio
    {
        [ForeignKey("InventarioCranio")]
        public int MarcadoresCranioId { get; set; }

        [Display(Name = "Código do Relatório")]
        public string InventarioCranioId { get; set; }

        public char Frontal { get; set; }
        public char Ocipital { get; set; }
        public char Esfenoide { get; set; }
        public char Maxilar { get; set; }
        public char Vomer { get; set; }
        [Display(Name = "Parietal Esquerdo")]
        public char ParietalEsq { get; set; }
        [Display(Name = "Temporal Esquerdo")]
        public char TemporalEsq { get; set; }
        [Display(Name = "Concha Nasal Esquerda")]
        public char ConchaNasalEsq { get; set; }
        [Display(Name = "Etmoide Esquerdo")]
        public char EtmoideEsq { get; set; }
        [Display(Name = "Lacrimal Esquerdo")]
        public char LacrimalEsq { get; set; }
        [Display(Name = "Nasal Esquerdo")]
        public char NasalEsq { get; set; }
        [Display(Name = "Zigomatico Esquerdo")]
        public char ZigomaticoEsq { get; set; }
        [Display(Name = "Parietal Direito")]
        public char ParietalDir { get; set; }
        [Display(Name = "Temporal Direito")]
        public char TemporalDir { get; set; }
        [Display(Name = "Concha Nasal Direito")]
        public char ConchaNasalDir { get; set; }
        [Display(Name = "Etmoide Direito")]
        public char EtmoideDir { get; set; }
        [Display(Name = "Lacrimal Direito")]
        public char LacrimalDir { get; set; }
        [Display(Name = "Zigomático Direito")]
        public char ZigomaticoDir { get; set; }
        public char Hioide { get; set; }

        [Display(Name = "Cartilagem Tireóide")]
        public char CartilagemTireoide { get; set; }

        [Display(Name = "Mandíbula")]
        public char Mandibula { get; set; }

        public InventarioCranio InventarioCranio { get; set; }

    }
}
