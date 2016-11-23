
namespace Biblioteca.modelo.basicas
{
    public class Gerente : Pessoa
    {
        private string nickname;
        private string senha_g;

        public string Nickname{
            get{
                return nickname;
            }

            set{
                nickname = value;
            }
        }

        public string Senha_g{
            get{
                return senha_g;
            }

            set{
                senha_g = value;
            }
        }
    }
}
