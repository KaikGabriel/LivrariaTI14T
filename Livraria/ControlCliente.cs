using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlCliente
    {
        Cliente cliente;    

        private int opcao;
        public ControlCliente()
        {
            cliente = new Cliente();
        }//Fim do construtor

        public int AcessarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }//Fim do AcessarOpção

        public void Menu()
        {
            
            Console.WriteLine("\n\nEscolha uma das opções abaixo:\n\n" +
                              "1. Cadastrar\n" +
                              "2. Consultar\n" +
                              "3. Atualizar Nome\n" +
                              "4. Atualizar Telefone\n" +
                              "5. Atualizar Endereço\n" +
                              "6. Excluir\n" +
                              "0. Sair");
            AcessarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do método menu


        public void Executar()
        {
            do
            {
                Menu();
                switch (AcessarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1:
                        Console.WriteLine("Informe o código: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe um nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe um telefone: ");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Informe um nome de usuário: ");
                        string usuario = Console.ReadLine();
                        Console.WriteLine("Informe uma senha: ");
                        string senha = Console.ReadLine();
                        Console.WriteLine("Informe sua Data de Nascimento: ");
                        //dataDeNascimento = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Dados cadastratos com sucesso!");
                        break;

                    case 2:
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(cliente.Consultar(codigo));
                        Console.ReadLine();
                        break;
                        

                    case 3:
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe um novo nome: ");
                        nome = Console.ReadLine();
                        Console.WriteLine(cliente.AtualizarNome(codigo, nome));
                        break;

                    case 4:
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um novo telefone: ");
                        telefone = Console.ReadLine();
                        Console.WriteLine(cliente.AtualizarTelefone(codigo, telefone));
                        break;

                    case 5:
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um novo usuario: ");
                        usuario = Console.ReadLine();
                        Console.WriteLine(cliente.AtualizarUsuario(codigo, usuario));
                        break;

                    case 6:
                        Console.WriteLine("Informe um código para ser excluido: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(cliente.Excluir(codigo));
                        Console.WriteLine("Dados excluidos com sucesso");
                        break;

                    default:
                        Console.WriteLine("Opção invalida! Tente novamente!");
                        break;
                }//Fim do Swtich
            } while (AcessarOpcao != 0);
        }//Fim do executar

    }//Fim da Control
}//Fim do projeto
