using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;



namespace TrabalhoRicardo
{
    class Program
    {
        public static List<Produto> listaProduto = new List<Produto>();
        private static List<Cliente> listaCliente = new List<Cliente>();
        private static List<Estoque> listaEstoque = new List<Estoque>();
        private static List<Loja> listaLoja = new List<Loja>();
        private static List<Vendedor> listaVendedor = new List<Vendedor>();
        private static List<Venda> listaVenda = new List<Venda>();
        private static List<decimal> totalpreco = new List<decimal>();
        public static void Main(string[] args)
        {



            while (true){ 
            string comandoEscolhido = "S";
            




               Console.WriteLine("\nEscolha uma opção:");
               Console.WriteLine("1 - Cadastrar Loja.");
               Console.WriteLine("2 - Cadastrar Produto.");
               Console.WriteLine("3 - Cadastrar Produto em um estoque.");
               Console.WriteLine("4 - Cadastrar um Cliente.");
               Console.WriteLine("5 - Cadastrar um Vendedor.");
               Console.WriteLine("6 - Visualizar Lojas Cadastradas.");
               Console.WriteLine("7 - Visualizar Estoques.");
               Console.WriteLine("8 - Visualizar Produtos Cadastrados.");
               Console.WriteLine("9 - Visualizar Clientes Cadastrados.");
               Console.WriteLine("V - Cadastrar uma Venda.");
                Console.WriteLine("S - Sair\n");


            Console.WriteLine("Opção desejada:");
            comandoEscolhido = Console.ReadKey().KeyChar.ToString().ToUpper();


            switch (comandoEscolhido)
            {
                    //Cadastrar Loja

                    case "1":
                        Console.WriteLine("\n Id da Loja:");
                        string idLoja = Console.ReadLine();
                        Console.WriteLine("Nome da Filial:");
                        string nomeFilial = Console.ReadLine();

                        //Cadastrar Estoque
                        Console.WriteLine("\n Id do Estoque:");
                        int idEstoque = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Endereco do Estoque:");
                        string enderecoEstoque = Console.ReadLine();
                        Console.WriteLine("Nome do Estoque:");
                        string nomeEstoque = Console.ReadLine();

                        Estoque estoques = new Estoque(idEstoque, enderecoEstoque, nomeEstoque);
                        listaEstoque.Add(estoques);

                        Loja lojas = new Loja(idLoja, nomeFilial, idEstoque);
                        listaLoja.Add(lojas);
                        Console.WriteLine("\nLoja adicionada com sucesso!");

                        break;
                        
                        
                    //Cadastrar produto:
                    case "2":
                    Console.WriteLine("\n Id do Produto:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Categoria do Produto:");
                    string categoria = Console.ReadLine();
                    Console.WriteLine("Nome do Produto:");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Preço do Produto:");
                    decimal preco = Convert.ToDecimal(Console.ReadLine());
                     
                    Produto produtos = new Produto(Convert.ToInt32(id), categoria, nome, Convert.ToDecimal(preco));
                    listaProduto.Add(produtos);
                    Console.WriteLine("\nProduto adicionado com sucesso!");
                        break;

                    case "3":
    
                      

                        if (listaEstoque.Count > 0 | listaProduto.Count > 0)
                        {
                            Console.WriteLine("\n Lista de Estoque");

                            for (int i = 0; i < listaEstoque.Count; i++)
                            {
                                Console.WriteLine($"Digite {i} para escolher o estoque: {listaEstoque[i].NomeEstoque} ");

                            }
                            Console.WriteLine("\n Qual estoque voce quer adicionar o produto?");
                            int NumEstoque = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n Esses são os produtos");
                            for (int i = 0; i < listaProduto.Count; i++)
                            {
                                Console.WriteLine($"Digite {i} para escolher o estoque: {listaProduto[i].Nome} ");

                            }
                            Console.WriteLine("\n Escolha um produto para adicionar no estoque");
                            int ProdEstoque = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n Quantas unidades desse produto voce quer adicionar?");
                            int QtdEstoque = Convert.ToInt32(Console.ReadLine());
                            listaEstoque[NumEstoque].CadastrarProduto(listaProduto[ProdEstoque], QtdEstoque);
                        }
                        else
                          Console.WriteLine("\nNão há Estoque ou Produtos cadastrados.");

                        break;


                    //Cadastrar Clientes
                    case "4":
                        Console.WriteLine("\n Id do Cliente:");
                        int idCliente = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nome do Cliente:");
                        string nomeCliente = Console.ReadLine();
                        Console.WriteLine("Endereço:");
                        string endereco = Console.ReadLine();
                        Console.WriteLine("Telefone:");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("CPF:");
                        string cpf = Console.ReadLine();

                        Cliente clientes = new Cliente(idCliente,nomeCliente,endereco,telefone,cpf);

                        listaCliente.Add(clientes);
                        Console.WriteLine("\nCliente adicionado com sucesso!");

                        break;


                    //Cadastrar Vendedor
                    case "5":
                        Console.WriteLine("\n Matricula do Vendedor:");
                        int MatriculaVendedor = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nome do Vendedor:");
                        string nomeVendedor = Console.ReadLine();
                        Console.WriteLine("Endereço:");
                        string Vendedorendereco = Console.ReadLine();
                        Console.WriteLine("Telefone:");
                        string Vendedortelefone = Console.ReadLine();
                        Console.WriteLine("CPF:");
                        string Vendedorcpf = Console.ReadLine();
                        Console.WriteLine("Salario:");
                        int VendedorSalario = Convert.ToInt32(Console.ReadLine());

                        Vendedor Vendedores = new Vendedor(MatriculaVendedor, nomeVendedor, Vendedorcpf, Vendedortelefone, Vendedorendereco, VendedorSalario);
                        listaVendedor.Add(Vendedores);
                        Console.WriteLine("\nVendedor adicionado com sucesso!");

                        break;



                    //Visualizar Lojas cadastrado
                    case "6":

                        if (listaLoja.Count > 0)
                        {
                            Console.WriteLine("\n Lista De Lojas");
                            foreach (Loja l in listaLoja)
                            {
                                Console.WriteLine($"\n Id: {l.Id},  Estoque:  {l.IdEstoque}, Nome da Filia:  {l.NomeFilial}");
                            }
                            Console.WriteLine("Pressione qualquer tecla para proseguir..");
                            Console.ReadKey();
                        }
                        else
                            Console.WriteLine("\nNão há Lojas cadastrados.");

                        break;


                    //Visualizar Estoques cadastrado
                    case "7":

                        if (listaEstoque.Count > 0 | listaProduto.Count > 0)
                        {
                            Console.WriteLine("\n Lista De Estoque");
                            foreach (Estoque e in listaEstoque)
                            {
                                Console.WriteLine($"\n Id: {e.Id},  Nome do Estoque: {e.NomeEstoque}, Endereço:  {e.Endereco}");
                            }
                            Console.WriteLine("Pressione qualquer tecla para proseguir..");
                            Console.ReadKey();
                        }
                        else
                            Console.WriteLine("\nNão há Estoque cadastrados.");

                        break;

                    //Visualizar Produtos
                    case "8":
                        if (listaProduto.Count > 0)
                        {
                            Console.WriteLine("\n Lista De Produtos");
                            foreach (Produto p in listaProduto)
                            {
                                Console.WriteLine($"\n Id: {p.Id}   \n Categoria:  {p.Categoria}   \n Nome:  {p.Nome}  \n Preço:  {p.Preco}");
                            }
                            Console.WriteLine("Pressione qualquer tecla para proseguir..");
                            Console.ReadKey();
                        }
                        else
                            Console.WriteLine("\nNão há Produtos cadastrados.");
                      
                        break;


                    //Visualizar Clientes
                    case "9":
                        if (listaCliente.Count > 0)
                        {
                            Console.WriteLine("\n Lista De Clientes");
                            foreach (Cliente c in listaCliente)
                            {
                                Console.WriteLine($"\n Id: {c.Id},  \nNome:  {c.Nome}, \nEndereço:  {c.Endereco}, \nTelefone:  {c.Telefone}, \nCPF: {c.Cpf}");
                            }
                            Console.WriteLine("Pressione qualquer tecla para proseguir..");
                            Console.ReadKey();
                        }
                        else
                            Console.WriteLine("\n Não há clientes cadastrados.");

                        break;

                    case "V":



                        if (listaEstoque.Count > 0 | listaProduto.Count > 0 | listaVendedor.Count > 0 | listaCliente.Count > 0)
                        {

                            Console.WriteLine("\n Id Da Venda");
                            int IdVenda = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n Esses são os Vendedores");
                            for (int i = 0; i < listaVendedor.Count; i++)
                            {
                                Console.WriteLine($"Digite {i} para escolher o Vendedor: {listaVendedor[i].Nome} ");


                            }
                            Console.WriteLine("\n Escolha um Vendedor:");
                            int NumVendedor = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n Lista de Clientes");

                            for (int i = 0; i < listaCliente.Count; i++)
                            {
                                Console.WriteLine($"Digite {i} para escolher o Cliente: {listaCliente[i].Nome} ");


                            }
                            Console.WriteLine("\n Qual Cliente fez a compra?");
                            int NumCliente = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n Lista de Loja");

                            for (int i = 0; i < listaLoja.Count; i++)
                            {
                                Console.WriteLine($"Digite {i} para escolher o Loja: {listaLoja[i].NomeFilial} ");


                            }
                            Console.WriteLine("\n Qual loja está sendo a compra?");
                            int NumeEstoque = Convert.ToInt32(Console.ReadLine());
                            Venda vendas = new Venda(IdVenda, listaVendedor[NumVendedor], listaCliente[NumCliente], listaEstoque[NumeEstoque]);
                            listaVenda.Add(vendas);

                          

                            //COLOCAR PRODUTO NO CARRINHO 
                            Console.WriteLine("\n Confirme Sua Venda:");
                            for (int i = 0; i < listaVenda.Count; i++)
                            {
                                Console.WriteLine($"Digite {i} para escolher a sua venda: \n id: {listaVenda[i].Id}, Cliente: {listaVenda[i].Cliente.Nome}, Vendedor: {listaVenda[i].Vendedor.Nome} ");
                            }
                            Console.WriteLine("\n Confirme sua Venda:");
                            int ConfirmeVenda = Convert.ToInt32(Console.ReadLine());
                            while (true)
                            {
                                totalpreco.Clear();
                                Console.WriteLine("\n Produtos que estão disponiveis para venda:");
                                for (int i = 0; i < listaProduto.Count; i++)
                                {
                                    Console.WriteLine($"Digite {i} para escolher o Produto: {listaProduto[i].Nome} Quantidade: {listaEstoque[NumeEstoque].qtdDisponivel(listaProduto[i])}");
                                }
                                Console.WriteLine("\n Escolha um produto para adicionar a venda:");
                                int ProdutoVenda = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("\n Escolha a quantidade do produto a ser adicionado:");
                                int ProdutoQtdVenda = Convert.ToInt32(Console.ReadLine());
                                listaVenda[ConfirmeVenda].AddProduto(listaProduto[ProdutoVenda]);
                                for (int i = 0; i < ProdutoQtdVenda; i++)
                                {
                                    listaEstoque[NumeEstoque].baixaProduto(listaProduto[ProdutoVenda]);
                                }
                                Console.WriteLine($"\n Agora o produto {listaProduto[ProdutoVenda].Nome} há apenas: {listaEstoque[NumeEstoque].qtdDisponivel(listaProduto[ProdutoVenda])} no estoque");
                                decimal totalvalor = listaProduto[ProdutoVenda].Preco * ProdutoQtdVenda;
                                Console.WriteLine($"\n O preço ficou: R$ {totalvalor}");
                                totalpreco.Add(totalvalor);
                                Console.WriteLine("\n Quer parar de adicionar produtos? (True ou False)");
                                bool sair = Convert.ToBoolean(Console.ReadLine());
                                if (sair)
                                {
                                    decimal soma = 0;
                                    foreach (decimal t in totalpreco)
                                    {
                                        soma =+ t;
                                    }
                                    Console.WriteLine($"\n  O preço ficou: R$:  {soma}");

                                    //Escolher Entrega

                                    Console.WriteLine("\n  Escolha como quer receber:");
                                    Console.WriteLine($"Digite 0 para escolher: Receber entrega por FreeLancer ");
                                    Console.WriteLine($"Digite 1 para escolher: Receber entrega por Entrega Propria ");
                                    Console.WriteLine($"Digite 2 para escolher: Receber entrega por Entrega Tercerizada ");

                                    int EntregaOpcao = Convert.ToInt32(Console.ReadLine());
                                    if (EntregaOpcao == 0)
                                    {
                                        EntregaFreelance EntregaFree = new EntregaFreelance();
                                        EntregaFree.DespacharProdutos(listaVenda[ConfirmeVenda]);
                                    }
                                    if (EntregaOpcao == 1)
                                    {
                                        EntregaPropria EntregaPro = new EntregaPropria();
                                        EntregaPro.DespacharProdutos(listaVenda[ConfirmeVenda]);
                                    }
                                    if (EntregaOpcao == 2)
                                    {
                                        EntregaTerceirizada EntregaTer = new EntregaTerceirizada();
                                        EntregaTer.DespacharProdutos(listaVenda[ConfirmeVenda]);
                                        
                                    }

                                    Console.WriteLine("Venda FINALIZADA com sucesso!");
                                    break;
                                }
                                else
                                    continue;
                            }   
                        }
                        else
                            Console.WriteLine("\nNão há Loja, Cliente, Vendedor ou Produtos cadastrados.");

                        break;







                }
            }

        }
    }
}