namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MIG_DetCxP
    {
        public long id { get; set; }

        public long CabCxP { get; set; }

        [StringLength(255)]
        public string cod_pro { get; set; }

        public double? sal_doc { get; set; }

        [StringLength(255)]
        public string num_doc { get; set; }

        [StringLength(255)]
        public string per_doc { get; set; }

        [StringLength(255)]
        public string ano_doc { get; set; }

        [StringLength(255)]
        public string ano_doc1 { get; set; }

        [StringLength(255)]
        public string num_doc1 { get; set; }

        [StringLength(255)]
        public string per_doc1 { get; set; }

        [StringLength(255)]
        public string tip_doc { get; set; }

        public DateTime? fch_doc { get; set; }

        [StringLength(255)]
        public string provee { get; set; }

        [StringLength(255)]
        public string ter_nombre { get; set; }

        [StringLength(255)]
        public string cod_cco { get; set; }

        [StringLength(255)]
        public string cod_cl1 { get; set; }

        [StringLength(255)]
        public string det_doc { get; set; }

        [StringLength(255)]
        public string tip_doc1 { get; set; }

        [StringLength(255)]
        public string cod_suc { get; set; }

        public virtual MIG_CabCxP MIG_CabCxP { get; set; }
    }
}
