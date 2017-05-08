namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CNT_PreasientoNIIF
    {
        public long id { get; set; }

        [Required]
        [StringLength(100)]
        public string TipoDocumento { get; set; }

        [Required]
        [StringLength(20)]
        public string CtaContable { get; set; }

        [Required]
        [StringLength(150)]
        public string NomCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string Naturaleza { get; set; }

        [Required]
        [StringLength(2)]
        public string Acreedora { get; set; }

        [Required]
        [StringLength(50)]
        public string Interface { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string Grupo { get; set; }

        public virtual CNT_TipoDocumento CNT_TipoDocumento { get; set; }
    }
}
