using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Cliente
    {
        private int codigo;
        private string nome;
        private string telefone;
        private string usuario;
        private string senha;
        private DateTime dataDeNascimento;


        public Cliente()
        {
            AcessarCodigo = 0;
            AcessarNome = "";
            AcessarTelefone = "";
            AcessarUsuario = "";
            AcessarSenha = "";
            AcessarDataDeNascimento = new DateTime();
        }//Fim do método construtor
        /// ////////////////////////////////////////////////////////////Cadastrar/////////////////////////////////////////////////////////////////////////////
        public void Cadastrar(int codigo, string nome, string telefone, string usuario, string senha, DateTime dataDeNascimento)
        {
            AcessarCodigo = codigo;
            AcessarNome = nome;
            AcessarTelefone = telefone;
            AcessarUsuario = usuario;
            AcessarSenha = senha;
            AcessarDataDeNascimento = dataDeNascimento;
        }//Fim do método cadastrar

        /// ////////////////////////////////////////////////////////////Consultar/////////////////////////////////////////////////////////////////////////////
        public string Consultar(int codigo)
        {
            if (AcessarCodigo == codigo)
            {
                return "Código: " + AcessarCodigo +
                       "\nNome Completo: " + AcessarNome + 
                       "\nTelefone: " + AcessarTelefone + 
                       "\nUsuário: " + AcessarUsuario +
                       "\nSenha: " + AcessarSenha;
            }
            else
            {
                return "Código Informado Não é Valido!";
            }
        }//fim do método consultar

        /// ////////////////////////////////////////////////////////////Atualizar/////////////////////////////////////////////////////////////////////////////

        public string AtualizarNome(int codigo, string nome)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarNome = nome;
                return "Nome atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é valido!";
            }
        }//Fim do método atualizar Nome

        public string AtualizarTelefone(int codigo, string telefone)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarTelefone = telefone;
                return "Telefone atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é valido!";
            }
        }//Fim do método atualizar Telefone

        public string AtualizarUsuario(int codigo, string usuario)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarUsuario = usuario;
                return "Usuário atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é valido!";
            }
        }//Fim do método atualizar Usuário

        public string AtualizarSenha(int codigo, string senha)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarSenha = senha;
                return "Senha atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é valido!";
            }
        }//Fim do método atualizar Senha

        public string AtualizarDataDeNascimento(int codigo, DateTime dataDeNascimento)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarDataDeNascimento = dataDeNascimento;
                return "Data de nascimento atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é valido!";
            }
        }//Fim do método atualizar Data de nascimento


        /// ////////////////////////////////////////////////////////////Excluir/////////////////////////////////////////////////////////////////////////////


        public string Excluir(int codigo)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarCodigo = 0;
                AcessarNome = "";
                AcessarTelefone = "";
                AcessarUsuario = "";
                AcessarSenha = "";
                AcessarDataDeNascimento = new DateTime();
                return "Dados excluídos com sucesso!";
            }
            else
            {
                return "Código informado não é valido!";
            }
        }


        /// /////////////////////////////////////////////////////////////////////////Gets e Sets//////////////////////////////////////////////////////////////////////////////////////////
        /// 

        public int AcessarCodigo
        {
            get
            {
                return codigo;
            }
            set
            {
                this.codigo = value;
            }
        }//Fim do método de Acessar Codigo

        public string AcessarNome
        {
            get
            {
                return nome;
            }
            set
            {
                this.nome = value;
            }
        }//Fim do método de Acessar nome

        public string AcessarTelefone
        {
            get
            {
                return telefone;
            }
            set
            {
                this.telefone = value;
            }
        }//Fim do método de Acessar Telefone

        public string AcessarUsuario
        {
            get
            {
                return usuario;
            }
            set
            {
                this.usuario = value;
            }
        }//Fim do método de Acessar Usuario

        public string AcessarSenha
        {
            get
            {
                return senha;
            }
            set
            {
                this.senha = value;
            }
        }//Fim do método de Acessar Senha

        public DateTime AcessarDataDeNascimento
        {
            get
            {
                return dataDeNascimento;
            }
            set
            {
                this.dataDeNascimento = value;
            }
        }//Fim do método de Acessar Data de Nascimento

    }//Fim da classe

    class Reserva
    {
        private int codigoReserva;
        private DateTime dataReserva;
        private int quantidade;



        public Reserva()
        {
            AcessarCodigoReserva = 0;
            AcessarQuantidade = 0;
            AcessarDataReserva = new DateTime();
        }//Fim do método construtor






        /// /////////////////////////////////////////////////////////////Get e Set


        public int AcessarCodigoReserva
        {
            get
            {
                return codigoReserva;
            }
            set
            {
                this.codigoReserva = value;
            }
        }//Fim AcessarCodigoReserva

        public DateTime AcessarDataReserva
        {
            get
            {
                return dataReserva;
            }
            set
            {
                this.dataReserva = value;
            }
        }//Fim AcessarDataReserva

        public int AcessarQuantidade
        {
            get
            {
                return quantidade;
            }
            set
            {
                this.quantidade = value;
            }
        }//Fim AcessarQuantidade


    }//Fim da classe Reserva


}//Fim do projeto
