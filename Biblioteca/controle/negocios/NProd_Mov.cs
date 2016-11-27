using Biblioteca.modelo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.modelo.basicas;
using Biblioteca.controle.dados;

namespace Biblioteca.controle.negocios
{
    public class NProd_Mov : IProd_Mov
    {
        DProd_Mov dprod_mov = new DProd_Mov();

        public void alterarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            throw new NotImplementedException();
        }

        public void deletarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            dprod_mov.deletarProd_Mov(prod_mov);
        }

        public void inserirProd_Mov(ProdutoMovimentacao prod_mov)
        {
            dprod_mov.inserirProd_Mov(prod_mov);
        }

        public List<ProdutoMovimentacao> listarProd_Mov(ProdutoMovimentacao prod_mov)
        {
            return dprod_mov.listarProd_Mov(prod_mov);
        }
    }
}
