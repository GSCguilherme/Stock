

using System;
using System.Collections.Generic;
using Biblioteca.modelo.basicas;
using Biblioteca.modelo.interfaces;
using Biblioteca.controle.dados;

namespace Biblioteca.controle.negocios
{
    public class NMovimentacao : IMovimentacao
    {
        DMovimentacao dmov = new DMovimentacao();

        public void alterarMovimentacao(Movimentacao bmov)
        {
            dmov.alterarMovimentacao(bmov);
        }

        public void deletarMovimentacao(Movimentacao bmov)
        {
            dmov.deletarMovimentacao(bmov);
        }

        public int getMax()
        {
            return dmov.getMax();
        }

        public void inserirMovimentacao(Movimentacao bmov)
        {
            dmov.inserirMovimentacao(bmov);
        }

        public List<Movimentacao> listarMovimentacao(Movimentacao bmov)
        {
            return dmov.listarMovimentacao(bmov);
        }
    }
}
