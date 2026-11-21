using System.ComponentModel.DataAnnotations;

namespace SistemaInscricaoCursosBlazor.Components.Models;

public class InscricaoModel
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "O e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "Informe um e-mail em formato válido.")]
    public string? Email { get; set; }

    // int? para que o [Required] funcione de verdade (campo vazio = null).
    // Com "int" puro, o valor padrão 0 nunca seria considerado "vazio".
    [Required(ErrorMessage = "A idade é obrigatória.")]
    [Range(16, 100, ErrorMessage = "A idade deve estar entre 16 e 100 anos.")]
    public int? Idade { get; set; }

    [Required(ErrorMessage = "Selecione um curso.")]
    public string? CursoId { get; set; }
}