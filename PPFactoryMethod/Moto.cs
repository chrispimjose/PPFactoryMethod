using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPFactoryMethod
{
	// Subclasse que representa uma Moto
	public class Moto : Veiculo
	{
		public override void ExibirDetalhes()
		{
			Console.WriteLine("Você escolheu uma moto. Este é um veículo de duas rodas.");
		}
	}
}
