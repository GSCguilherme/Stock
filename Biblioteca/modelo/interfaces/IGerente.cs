using Biblioteca.modelo.basicas;
using System.Collections.Generic;

namespace Biblioteca.modelo.interfaces
{
   public interface IGerente
    {
        void inserirGerente(Gerente bgeren);
        void alterarGerente(Gerente bgeren);
        void deletarGerente(Gerente bgeren);
        List<Gerente> listarGerente(Gerente bgeren);
    }
}
