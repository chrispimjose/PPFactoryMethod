using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPFactoryMethod
{
	// Subclasse que representa um Carro
	public class Carro : Veiculo
	{
		public override void ExibirDetalhes()
		{
			Console.WriteLine("Você escolheu um carro. Este é um veículo de quatro rodas.");
		}
	}
}
