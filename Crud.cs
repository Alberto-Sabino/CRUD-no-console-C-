using System;

public class Crud
{

	static int maximoCadastro = 3;

	static string[] nomeCompleto = new string[maximoCadastro];
	static int[] idade = new int[maximoCadastro];

	public static void cadastrar(int contador)
	{

		if (contador < maximoCadastro)
		{
			Console.Write("Nome Completo:  ");
			nomeCompleto[contador] = Console.ReadLine();
			Console.Write("\n Idade:  ");
			idade[contador] = int.Parse(Console.ReadLine());

			Console.Write("\n\nCadastrado com sucesso!");
		}
		else
		{
			Console.WriteLine("\tERRO. Banco Cheio!");
		}

		Console.ReadKey();
		Console.Clear();
	}

	public static void listar()
	{
		int lista;

		Console.WriteLine("----------------------------------------");
		Console.WriteLine("Usuários:\n\n");

		for (lista = 0; lista < maximoCadastro; lista++)
		{
			Console.WriteLine("\n\tID: " + (lista + 1));
			Console.WriteLine("\tNome: " + nomeCompleto[lista] +
			"\n\tIdade: " + idade[lista]);
			Console.Write("____________________\n");
		}

		Console.ReadKey();
		Console.Clear();
	}

	public static void alterar()
	{
		int id;
		Console.Write("Digite a ID a ser alterada:  ");
		id = int.Parse(Console.ReadLine());

		id = id - 1;//Porque as posições do vetor começam em 0

		Console.Write("Dados atuais:\n\t {0}, {1}.\n\n",
		nomeCompleto[id], idade[id]);

		Console.WriteLine("Dados alterados:");

		Console.Write("\tNome: ");
		nomeCompleto[id] = Console.ReadLine();
		Console.Write("\t  idade: ");
		idade[id] = int.Parse(Console.ReadLine());

		Console.Write("\n\nAlterado com sucesso!");

		Console.ReadKey();
		Console.Clear();
	}

	public static void deletar()
	{
		int id;
		string op;

		Console.Write("Digite a ID a ser excluída:  ");
		id = int.Parse(Console.ReadLine());
		id = id - 1;

		Console.Write("Dados salvos:\n\t {0}, {1}.\n\n",
		nomeCompleto[id], idade[id]);

		Console.WriteLine("Deseja realmente excluir? (S / N)");
		op = Console.ReadLine();
		op = op.Substring(0, 1);

		if ((op == "s") || (op == "S"))
		{
			if (id == maximoCadastro)
			{
				nomeCompleto[id] = null;
				idade[id] = 0;
			}
			else
			{
				nomeCompleto[id] = nomeCompleto[id + 1];
				idade[id] = idade[id + 1];

				nomeCompleto[id + 1] = null;
				idade[id + 1] = 0;
			}

			Console.Write("\n\nExcluído com sucesso!");
		}
		Console.ReadKey();
		Console.Clear();
	}

}