namespace API_VideoJuegos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class consola
    {
        public int id { get; set; }

        [Required]
        [StringLength(25)]
        public string marca { get; set; }

        [Required]
        [StringLength(25)]
        public string modelo { get; set; }

        public int anio { get; set; }

        public int nueva { get; set; }

        public int precio { get; set; }

        public int stock { get; set; }
    }
}
