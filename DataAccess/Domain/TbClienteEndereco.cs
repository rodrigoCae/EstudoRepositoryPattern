﻿using System;
using System.Collections.Generic;

namespace DataAccess.Domain
{

    public partial class TbClienteEndereco
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public int EnderecoId { get; set; }

        public virtual TbCliente Cliente { get; set; }

        public virtual TbEndereco Endereco { get; set; }
    }
}