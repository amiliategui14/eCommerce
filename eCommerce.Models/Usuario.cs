using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; } 
        public string? Sexo { get; set; }
        public string? RG { get; set; }
        public string CPF { get; set; } 
        public string? NomeMae { get; set; }
        public string? NomePai { get; set; }

        public string? SituacaoCadastro { get; set; }
        public DateTimeOffset DataCadastro { get; set; }

        public Contato? Contato { get; set; }
        public ICollection<EnderecoEntrega>? EnderecoEntrega { get; set; } // Foi usado ICollection pois o usuário pode ter vários endereços de entrega //
        public ICollection<Departartamento>? Departartamentos { get; set; }

    }
}
