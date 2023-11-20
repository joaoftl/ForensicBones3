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

        [Display(Name = "Crista Nucal")]
        public char CristaNucal { get; set; }

        [Display(Name = "Processo Mastoide")]
        public char ProcessoMastoide { get; set; }

        [Display(Name = "Eminência Mentoniana")]
        public char EminenciaMentoniana { get; set; }

        [Display(Name = "Supra Orbital")]
        public char SupraOrbital {  get; set; }

        [Display(Name = "Área da Glabela")]
        public char AreaGlabela { get; set; }

        public InventarioCranio InventarioCranio { get; set; }

    }
}
