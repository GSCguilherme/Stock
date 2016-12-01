using System.Collections.Generic;
using Biblioteca.modelo.basicas;
namespace Biblioteca.modelo.interfaces
{
    public interface IMovimentacao
    {
        void inserirMovimentacao(Movimentacao bmov);
        void alterarMovimentacao(Movimentacao bmov);
        void deletarMovimentacao(Movimentacao bmov);
        List<Movimentacao> listarMovimentacao(Movimentacao bmov);
        int getMax();
        decimal Sum(string escolha);
        decimal sumTotal();
    }
}
