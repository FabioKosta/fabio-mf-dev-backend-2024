using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fabio_mf_dev_backend_2024.Models
{
    [Table("Consumo")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar a Descrição")]

        [Display(Name="Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Data")]
        public DateTime Data  { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Quilometragem")]
        public int Km { get; set; }

        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name = "Veículo")]

        [Required(ErrorMessage = "Obrigatório informar a Veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }

    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}
    