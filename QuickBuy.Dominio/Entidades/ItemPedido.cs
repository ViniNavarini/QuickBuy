﻿using System;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public static bool Any { get; internal set; }
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        internal static bool Any()
        {
            throw new NotImplementedException();
        }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
