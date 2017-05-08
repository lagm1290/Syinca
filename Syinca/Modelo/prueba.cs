namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("prueba")]
    public partial class prueba
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string ano_doc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string per_doc { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string tip_doc { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(14)]
        public string num_doc { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "numeric")]
        public decimal reg_doc { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(5)]
        public string trans { get; set; }

        [StringLength(15)]
        public string cod_pro { get; set; }

        [StringLength(4)]
        public string ano_ref { get; set; }

        [StringLength(2)]
        public string per_ref { get; set; }

        [StringLength(3)]
        public string tip_ref { get; set; }

        [StringLength(14)]
        public string num_ref { get; set; }

        public DateTime? fec_ven { get; set; }

        [Column(TypeName = "money")]
        public decimal? val_fac { get; set; }

        [Column(TypeName = "money")]
        public decimal? val_doc { get; set; }

        [Column(TypeName = "money")]
        public decimal? sal_doc { get; set; }

        [Column(TypeName = "money")]
        public decimal? por_iva { get; set; }

        [Column(TypeName = "money")]
        public decimal? val_iva { get; set; }

        [Column(TypeName = "money")]
        public decimal? ret_iva { get; set; }

        [Column(TypeName = "money")]
        public decimal? sub_doc { get; set; }

        [Column(TypeName = "money")]
        public decimal? por_des { get; set; }

        [Column(TypeName = "money")]
        public decimal? val_des { get; set; }

        [Column(TypeName = "money")]
        public decimal? net_doc { get; set; }

        [Column(TypeName = "money")]
        public decimal? por_ret { get; set; }

        [Column(TypeName = "money")]
        public decimal? val_ret { get; set; }

        [Column(TypeName = "money")]
        public decimal? ant_doc { get; set; }

        [StringLength(14)]
        public string doc_ant { get; set; }

        public int? dia_ven { get; set; }

        [Column(TypeName = "money")]
        public decimal? val_ica { get; set; }

        [Column(TypeName = "money")]
        public decimal? por_ica { get; set; }

        [Column(TypeName = "money")]
        public decimal? por_riv { get; set; }

        [StringLength(4)]
        public string ano_ant { get; set; }

        [StringLength(2)]
        public string per_ant { get; set; }

        [StringLength(3)]
        public string tip_ant { get; set; }

        [StringLength(12)]
        public string cod_cl1 { get; set; }

        [StringLength(12)]
        public string cod_cl2 { get; set; }

        [StringLength(12)]
        public string cod_cl3 { get; set; }

        [StringLength(3)]
        public string cod_suc { get; set; }

        [StringLength(10)]
        public string cod_cco { get; set; }

        [StringLength(3)]
        public string ind_con { get; set; }

        [StringLength(1)]
        public string final { get; set; }

        public short? reg_ant { get; set; }

        [StringLength(10)]
        public string numche { get; set; }

        [StringLength(10)]
        public string ban_pos { get; set; }

        public DateTime? fec_che { get; set; }

        [StringLength(10)]
        public string num_che { get; set; }

        [Column(TypeName = "money")]
        public decimal? may_val { get; set; }

        [Column(TypeName = "money")]
        public decimal? men_val { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? reg_ref { get; set; }

        [StringLength(2)]
        public string cod_cat { get; set; }

        [StringLength(3)]
        public string ind_afe { get; set; }

        [Column(TypeName = "money")]
        public decimal? por_tim { get; set; }

        [Column(TypeName = "money")]
        public decimal? val_tim { get; set; }

        [StringLength(14)]
        public string pre_fac { get; set; }

        [Column(TypeName = "money")]
        public decimal? val_pag { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime fec_pag { get; set; }

        [StringLength(3)]
        public string tip_ret { get; set; }

        [StringLength(1)]
        public string val_imp { get; set; }

        [StringLength(12)]
        public string num_impcue { get; set; }

        [StringLength(3)]
        public string ser_imp { get; set; }

        [StringLength(5)]
        public string sub_tip { get; set; }

        [Column(TypeName = "money")]
        public decimal? bas_rti { get; set; }

        [Column(TypeName = "money")]
        public decimal? bas_rii { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal por_sum1 { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal mon_sum1 { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal por_sum2 { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal mon_sum2 { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal por_sum3 { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal mon_sum3 { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal por_sum4 { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal mon_sum4 { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal por_res1 { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "money")]
        public decimal mon_res1 { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "money")]
        public decimal por_res2 { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "money")]
        public decimal mon_res2 { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "money")]
        public decimal por_res3 { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "money")]
        public decimal mon_res3 { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "money")]
        public decimal por_res4 { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "money")]
        public decimal mon_res4 { get; set; }
    }
}
