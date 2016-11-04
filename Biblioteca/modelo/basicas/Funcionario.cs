

namespace Biblioteca.modelo.basicas
{
    public class Funcionario : Pessoa
    {
        private string nickname;
        private string senha;

        public string Nickname
        {
            get
            {
                return nickname;
            }

            set
            {
                nickname = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }
    }
}
