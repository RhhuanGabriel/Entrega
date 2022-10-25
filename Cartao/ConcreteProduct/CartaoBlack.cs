﻿using Entrega.Product;

namespace Entrega.ConcreteProduct
{
    public class CartaoBlack : CartaoCredito
    {
        private readonly string _tipo;
        private float _limite;
        private float _cobrancaAnual;

        public CartaoBlack(float limite, float cobrancaAnual)
        {
            this._tipo = "Black";
            this._limite = limite;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override string Tipo
        {
            get { return _tipo; }
        }

        public override float Limite
        {
            get { return _limite; }
            set { _limite = value; }
        }

        public override float CobrancaAnual
        {
            get { return _cobrancaAnual; }
            set { _cobrancaAnual = value; }
        }
    }
}