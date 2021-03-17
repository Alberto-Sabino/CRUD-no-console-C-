using System;

class MainClass : Crud
{
	public static void Main(string[] args)
	{

		int contador = 0;
		string opcao;

		Console.Clear();
		do
		{
			Console.Write("\n\n\tCRUD no console!");

			Console.WriteLine("\n\nOpções:\n");
			Console.Write("\t\"C\"- Create | \"R\"- Read | \"U\"- Update | \"D\"- Delete\n\n");

			Console.Write("Digite a opção ou S para Sair:  ");
			opcao = Console.ReadLine();

			Console.Write("\n\n");

			opcao = opcao.Substring(0, 1);

			if ((opcao == "c") || (opcao == "C"))
			{
				cadastrar(contador);
				contador++;

			}
			else if ((opcao == "r") || (opcao == "R"))
			{
				listar();

			}
			else if ((opcao == "u") || (opcao == "U"))
			{
				if (contador > 0)
				{
					alterar();

				}
				else
				{
					Console.Write("Não existem usuários cadastrados.");
					Console.ReadKey();
					Console.Clear();
				}

			}
			else if ((opcao == "d") || (opcao == "D"))
			{
				if (contador > 0)
				{
					deletar();
					contador--; //para poder cadastrar denovo ;)

				}
				else
				{
					Console.Write("Não existem usuários cadastrados.");
					Console.ReadKey();
					Console.Clear();
				}

			}

		} while ((opcao != "s") && (opcao != "S"));

		Console.Write("\n\nPrograma encerrado.");

	}
}