﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo título é obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo diretor é obrigatório!")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "O genero não pode exceder 30 caracteres!")]
        public string Genero { get; set; }

        [Range(1, 600, ErrorMessage = "A duração precisa ter no mínimo 1 e no máximo 600 minutos!")]
        public int Duracao { get; set; }
    }
}
