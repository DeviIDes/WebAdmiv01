using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAdmin.Models
{
    public class TblCompra
    {
        [Display(Name = "ID Cotización")]
        [Key]
        public Guid IdCompra { get; set; }

        [Display(Name = "Numero Cotización")]
        public int NumeroCompra { get; set; }

        [Display(Name = "Usuario")]
        public Guid IdUsuarioCompra { get; set; }

        [Display(Name = "Centro")]
        public Guid IdCentro { get; set; }

        [Display(Name = "Alumno")]
        [Required(ErrorMessage = "Campo Requerido")]
        public Guid IdCliente { get; set; }

        [Display(Name = "Tipo de Pago")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int IdTipoPago { get; set; }

        [Display(Name = "Codigo / Referencia")]
        public string CodigoPago { get; set; }

        [Display(Name = "Fecha Altera")]
        [DataType(DataType.Date)]
        public DateTime FechaAlterna { get; set; }
        [Display(Name = "Corporativo / Centro")]
        public int IdCorpCent { get; set; }

        [Display(Name = "Usuario")]
        public Guid IdUsuarioModifico { get; set; }

        [Display(Name = "Fecha Registro")]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }

        [Display(Name = "Estatus")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int IdEstatusRegistro { get; set; }

        [Display(Name = "Total")]
        public double Total { get; set; }

        public virtual List<RelCompraProducto> RelCompraProductos { get; set; }
    }
}