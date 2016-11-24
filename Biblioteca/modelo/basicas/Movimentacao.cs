namespace Biblioteca.modelo.basicas
{
    public class Movimentacao
    {
        private int cod_mov;
        private string mov;
        private string tipo;
        private string endereco;
        private string email;
        private string data_mov;
        private int qtd_mov;

        public int Cod_mov
        {
            get
            {
                return cod_mov;
            }

            set
            {
                cod_mov = value;
            }
        }

        public string Mov
        {
            get
            {
                return mov;
            }

            set
            {
                mov = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Data_mov
        {
            get
            {
                return data_mov;
            }

            set
            {
                data_mov = value;
            }
        }

        public int Qtd_mov
        {
            get
            {
                return qtd_mov;
            }

            set
            {
                qtd_mov = value;
            }
        }
    }
}
