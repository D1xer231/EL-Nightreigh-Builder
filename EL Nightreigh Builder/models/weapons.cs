using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL_Nightreigh_Builder.Models
{
    [Table("weapons")] // таблица в MySQL
    public class Weapon
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("physic")]
        public int Physic { get; set; }

        [Column("magic")]
        public int Magic { get; set; }

        [Column("fire")]
        public int Fire { get; set; }

        [Column("ligt")]
        public int Lightning { get; set; }

        [Column("holy")]
        public int Holy { get; set; }

        [Column("crift")]
        public int Critical { get; set; }

        [Column("image_path")]
        public string? ImagePath { get; set; }

        [Column("sca_strength")]
        public string? ScaleStrength { get; set; }

        [Column("sca_dexterity")]
        public string? ScaleDexterity { get; set; }

        [Column("sca_intelligence")]
        public string? ScaleIntelligence { get; set; }

        [Column("sca_faith")]
        public string? ScaleFaith { get; set; }

        [Column("sca_arcane")]
        public string? ScaleArcane { get; set; }

        [Column("req_strength")]
        public int? ReqStrength { get; set; }

        [Column("req_dexterity")]
        public int? ReqDexterity { get; set; }

        [Column("req_intelligence")]
        public int? ReqIntelligence { get; set; }

        [Column("req_faith")]
        public int? ReqFaith { get; set; }

        [Column("req_arcane")]
        public int? ReqArcane { get; set; }

        [Column("map_link")]
        public string? MapLink { get; set; }

        [Column("location")]
        public string? Location { get; set; }
    }
}
