using BusinessLogic;
using DataAccess.Domain;
using System;

namespace TesteRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;
            do
            {
                Console.WriteLine("[ 1 ] Incluir Cliente");
                Console.WriteLine("[ 2 ] Excluir Cliente");
                Console.WriteLine("[ 3 ] Atualizar Cliente");
                Console.WriteLine("[ 4 ] Listar Clientes");
                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite uma opção: ");
                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        incluirCliente();
                        break;
                    case 2:
                        excluirCliente();
                        break;
                    case 3:
                        atualizarCliente();
                        break;
                    case 4:
                        listarClientes();
                        break;
                    default:
                        saiPrograma();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            while (opcao != 0);
        }

        private static void saiPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("Você encerrou o Programa. Clique qq tecla para sair...");
        }

        private static void listarClientes()
        {
            using (var bll = new ClienteBusinessLogic())
            {
                var clientes = bll.ListarClientes();
                foreach (var cli in clientes)
                {
                    Console.WriteLine($"{cli.Id} - {cli.Nome} - {cli.Email}");
                }
            }
        }

        private static void atualizarCliente()
        {
            using (var bll = new ClienteBusinessLogic())
            {
                try
                {
                    Console.WriteLine("Informe o codigo do cliente a atualizar");
                    int codigo = Int32.Parse(Console.ReadLine());
                    var cliente = bll.GetClientePorId(codigo);
                    Console.WriteLine("Informe o nome do cliente ");
                    string nome = Console.ReadLine();
                    cliente.Nome = nome;
                    Console.WriteLine("Informe o email do cliente ");
                    string email = Console.ReadLine();
                    cliente.Email = email;
                    bll.AlterarCliente(cliente);
                    Console.WriteLine("Cliente Atualizado com sucesso");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao excluir cliente : " + ex.Message);
                }
            }
        }

        private static void excluirCliente()
        {
            using (var bll = new ClienteBusinessLogic())
            {
                try
                {
                    Console.WriteLine("Informe o codigo do cliente");
                    int codigo = Int32.Parse(Console.ReadLine());
                    var cliente = bll.GetClientePorId(codigo);
                    bll.ExcluirCliente(cliente);
                    Console.WriteLine("Cliente excluido com sucesso");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao excluir cliente : " + ex.Message);
                }
            }
        }

        private static void incluirCliente()
        {
            using (var bll = new ClienteBusinessLogic())
            {
                try
                {
                    TbCliente cli = new TbCliente();
                    Console.WriteLine("Informe o nome do cliente ");
                    string nome = Console.ReadLine();
                    cli.Nome = nome;
                    Console.WriteLine("Informe o email do cliente ");
                    string email = Console.ReadLine();
                    cli.Email = email;
                    bll.AdicionarCliente(cli);
                    Console.WriteLine("Cliente incluido com sucesso");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao incluir cliente : " + ex.Message);
                }
            }
        }
    }
}
