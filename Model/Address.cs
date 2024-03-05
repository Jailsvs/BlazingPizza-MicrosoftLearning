namespace BlazingPizza;
using System.ComponentModel.DataAnnotations;


public class Address
{
    public int Id { get; set; }
    
    [Required, MinLength(3, ErrorMessage = "Por favor utilize um Nome maior que 3 caracteres."), MaxLength(100, ErrorMessage = "Por favor utilize um Nome menor que 100 caracteres.")]
    public string Name { get; set; }
    
    [Required, MinLength(5, ErrorMessage = "Por favor utilize um Endereço maior que 5 caracteres."), MaxLength(100, ErrorMessage = "Por favor utilize um Endereço menor que 100 caracteres.")]
    public string Line1 { get; set; }
    
    [MaxLength(100)]
    public string Line2 { get; set; }

    [Required, MinLength(3, ErrorMessage = "Por favor utilize uma Cidade maior que 3 caracteres."), MaxLength(50, ErrorMessage = "Por favor utilize uma Cidade menor que 50 caracteres.")]
    public string City { get; set; }

    [Required, MinLength(3, ErrorMessage = "Por favor utilize uma Região maior que 3 caracteres."), MaxLength(20, ErrorMessage = "Por favor utilize uma Região menor que 20 caracteres.")]
    public string Region { get; set; }

    [Required, RegularExpression(@"^([0-9]{5})$", ErrorMessage = "Por favor utilize um Código Postal válido com 5 números.")]
    public string PostalCode { get; set; }
}

