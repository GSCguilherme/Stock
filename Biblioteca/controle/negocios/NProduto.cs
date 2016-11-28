using System;
using System.Collections.Generic;
using Biblioteca.modelo.basicas;
using Biblioteca.modelo.interfaces;
using Biblioteca.controle.dados;
using Biblioteca.controle.xml;

namespace Biblioteca.controle.negocios
{
    public class NProduto : IProduto{

        DProduto dprod = new DProduto();
        XMLProduto xprod = new XMLProduto();

        public void alterarProduto(Produto bprod)
        {
            dprod.alterarProduto(bprod);
        }

        public void deletarProduto(Produto bprod)
        {
            dprod.deletarProduto(bprod);
        }

        public void inserirProduto(Produto bprod)
        {
            dprod.inserirProduto(bprod);
            xprod.insertXML(bprod);
        }

        public List<Produto> listarProduto(Produto bprod)
        {
            return dprod.listarProduto(bprod);
        }
    }
}
