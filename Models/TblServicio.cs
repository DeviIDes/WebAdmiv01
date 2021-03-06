using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebAdmin.Models
{
    public partial class TblServicio
    {
        [Key]

        public int IdServicio { get; set; }

        [Display(Name = "Codigo Interno")]
        public string CodigoInterno { get; set; }

        [Display(Name = "Codigo Externo")]
        [Required(ErrorMessage = "Campo Requerido")]
        public string CodigoExterno { get; set; }

        [Display(Name = "Tipo Servicio")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int IdTipoServicio { get; set; }
        [Display(Name = "Descripcion Tipo Servicio")]
        [NotMapped]
        public string TipoServicioDesc { get; set; }
        [Display(Name = "Descripcion Servicio")]
        public string DescServicio { get; set; }

        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "Campo Requerido")]
        public decimal ServicioPrecioUno { get; set; }

        [Display(Name = "Porcentaje")]
        public decimal PorcentajePrecioUno { get; set; }

        public decimal SubCosto { get; set; }
        public decimal Costo { get; set; }

        [Display(Name = "Usuario Modifico")]
        public Guid IdUsuarioModifico { get; set; }

        [Column("FechaRegistro")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Registro")]
        public DateTime FechaRegistro { get; set; }

        [Display(Name = "Estatus")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int IdEstatusRegistro { get; set; }
    }
}