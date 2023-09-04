﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace ListaContatos.Entidades
{
    public abstract class Entidade
    {
        public abstract void transferirDados(MySqlCommand comando);
        public abstract void transferirDadosIdentificador(MySqlCommand comando);
        public abstract void lerDados(MySqlDataReader leitorDados);
    }
}
