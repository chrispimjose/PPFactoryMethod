using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPFactoryMethod
{
	// Subclasse que implementa a fábrica de motos
	public class MotoFactory : VeiculoFactory
	{
		public override Veiculo CriarVeiculo()
		{
			return new Moto();
		}
	}
}
