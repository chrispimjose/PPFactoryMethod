using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPFactoryMethod
{
	// Classe Fábrica que define o Factory Method para criar veículos
	public abstract class VeiculoFactory
	{
		// Método Factory que será implementado pelas subclasses
		public abstract Veiculo CriarVeiculo();

		// Método para mostrar os detalhes do veículo
		public void MostrarVeiculo()
		{
			// Usa o Factory Method para criar o veículo
			Veiculo veiculo = CriarVeiculo();
			veiculo.ExibirDetalhes();
		}
	}
}
