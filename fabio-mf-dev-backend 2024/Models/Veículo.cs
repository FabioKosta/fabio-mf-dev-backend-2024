﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fabio_mf_dev_backend_2024.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a Placa!")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Ano de Fabricação!")]

        [Display(Name = "Ano de Fabricação")]   
        public int AnoFabicacao { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Ano do Modelo!")]

        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; } 
    }
}
    