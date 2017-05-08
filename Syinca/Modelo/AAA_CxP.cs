namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AAA_CxP
    {
        public long id { get; set; }

        [StringLength(255)]
        public string cod_pro { get; set; }

        public double? sal_doc { get; set; }

        [StringLength(255)]
        public string num_doc { get; set; }

        [StringLength(255)]
        public string per_doc { get; set; }

        [StringLength(255)]
        public string tip_doc { get; set; }

        [StringLength(255)]
        public string ano_doc { get; set; }

        [StringLength(255)]
        public string ano_doc1 { get; set; }

        [StringLength(255)]
        public string num_doc1 { get; set; }

        [StringLength(255)]
        public string per_doc1 { get; set; }

        [StringLength(255)]
        public string tip_doc1 { get; set; }

        public DateTime? fch_doc { get; set; }

        [StringLength(255)]
        public string provee { get; set; }

        [StringLength(255)]
        public string ter_nombre { get; set; }

        [StringLength(255)]
        public string cod_suc { get; set; }
    }
}
