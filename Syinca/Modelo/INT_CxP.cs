namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INT_CxP
    {
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string Documento { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(2)]
        public string Exportado { get; set; }

        [StringLength(4)]
        public string ano_doc { get; set; }

        [StringLength(2)]
        public string per_doc { get; set; }

        [StringLength(3)]
        public string tip_doc { get; set; }

        [StringLength(14)]
        public string num_doc { get; set; }

        [StringLength(4)]
        public string reg_doc { get; set; }

        [StringLength(12)]
        public string fch_doc { get; set; }

        [StringLength(15)]
        public string cod_pro { get; set; }

        [StringLength(30)]
        public string val_doc { get; set; }

        [StringLength(4)]
        public string por_iva { get; set; }

        [StringLength(30)]
        public string mon_iva { get; set; }

        [StringLength(4)]
        public string por_des { get; set; }

        [StringLength(30)]
        public string mon_des { get; set; }

        [StringLength(4)]
        public string por_ret { get; set; }

        [StringLength(30)]
        public string mon_ret { get; set; }

        [StringLength(4)]
        public string por_ica { get; set; }

        [StringLength(30)]
        public string mon_ica { get; set; }

        [StringLength(4)]
        public string por_riv { get; set; }

        [StringLength(30)]
        public string mon_riv { get; set; }

        [StringLength(3)]
        public string ind_con { get; set; }

        [StringLength(4)]
        public string ano_ref { get; set; }

        [StringLength(2)]
        public string per_ref { get; set; }

        [StringLength(3)]
        public string tip_ref { get; set; }

        [StringLength(14)]
        public string num_ref { get; set; }

        [StringLength(30)]
        public string reg_ref { get; set; }

        [StringLength(4)]
        public string ano_ant { get; set; }

        [StringLength(2)]
        public string per_ant { get; set; }

        [StringLength(3)]
        public string tip_ant { get; set; }

        [StringLength(14)]
        public string doc_ant { get; set; }

        [StringLength(4)]
        public string reg_ant { get; set; }

        [StringLength(4)]
        public string ant_doc { get; set; }

        [StringLength(1)]
        public string ind_tra { get; set; }

        [StringLength(3)]
        public string cod_suc { get; set; }

        [StringLength(10)]
        public string cod_cco { get; set; }

        [StringLength(12)]
        public string cod_cl1 { get; set; }

        [StringLength(12)]
        public string cod_cl2 { get; set; }

        [StringLength(12)]
        public string cod_cl3 { get; set; }

        [StringLength(70)]
        public string det_doc { get; set; }

        [StringLength(8)]
        public string fec_ven { get; set; }

        [StringLength(2)]
        public string ind_mp { get; set; }

        [StringLength(8)]
        public string fec_tas { get; set; }

        [StringLength(6)]
        public string tasa { get; set; }

        [StringLength(14)]
        public string num_fac { get; set; }

        [StringLength(2)]
        public string dia_pla { get; set; }

        [StringLength(5)]
        public string cod_ciu { get; set; }

        [StringLength(3)]
        public string tip_ret { get; set; }
    }
}
