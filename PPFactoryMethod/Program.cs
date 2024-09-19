namespace PPFactoryMethod
{
	internal class Program
	{
		static void Main(string[] args)
		{
			VeiculoFactory factory = null;

			Console.WriteLine("Escolha o tipo de veículo que deseja criar:");
			Console.WriteLine("1 - Carro");
			Console.WriteLine("2 - Moto");
			Console.Write("Digite sua escolha: ");
			string escolha = Console.ReadLine();

			// Baseado na escolha do usuário, cria a fábrica correspondente
			if (escolha == "1")
			{
				factory = new CarroFactory();
			}
			else if (escolha == "2")
			{
				factory = new MotoFactory();
			}
			else
			{
				Console.WriteLine("Opção inválida! Tente novamente.");
				return;
			}

			// Usa a fábrica para criar e exibir detalhes do veículo
			factory.MostrarVeiculo();
		}
	}	
}
