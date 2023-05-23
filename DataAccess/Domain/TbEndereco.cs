using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Domain {

    public partial class TbEndereco
    {
        public int Id { get; set; }

        public string Rua { get; set; }

        public string Bairro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public int TipoEndereco { get; set; }

        public int CidadeId { get; set; }
    
        public virtual TbCidade Cidade { get; set; }

        public virtual ICollection<TbClienteEndereco> TbClienteEnderecos { get; set; } = new List<TbClienteEndereco>();
    }
}
