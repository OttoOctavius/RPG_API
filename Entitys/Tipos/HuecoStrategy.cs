using System;
using Entitys.Tipos;

namespace Entitys.Tipos
{
	public class HuecoStrategy :TypeStrategy
	{
		byte inicial, final;
		public HuecoStrategy(byte cantidadMaxima) : base("", "") {
			inicial = 1;
			final = cantidadMaxima;
		}

		public HuecoStrategy(byte huecosIniciales,byte cantidadMaxima) : base("", "") {
			inicial = huecosIniciales;
			final = cantidadMaxima;			
		}

		public override TypeStrategy change()
		{
			if (inicial < final)
			{
				inicial++;

			}
			return this;
		}

		//public void repair(float cantidad,Requerimiento costo){ }
		private void upgrade() { }
	}
}