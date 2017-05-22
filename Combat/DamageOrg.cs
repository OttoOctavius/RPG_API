using System;
using Combat;

namespace Combate
{
	public class DamageOrg : iDamage<float>
	{

		public iAttack<float> dmg;


        /Se espera que el que lo invoco sea del tipo fraccionario
        
		public float remanente(iAttack<float> atenuado)
		{
			float recibido = 0f;
			foreach (var item in dmg.getTypes())
			{
				recibido += dmg.getAttack(item) * atenuado.getAttack(item);
				dmg.atenuarAtaqueSimple(item, restante(atenuado.getAttack(atenuado)));
			}
			return recibido;
		}

		/**
        Se le resta el valor de descuento al ataque
         */
		public float descontar(iAttack<float> descuento)
		{
			float recibido = 0f, diferencia = 0f;

			foreach (var item in dmg.getTypes())
			{
				diferencia = dmg.getAttack(item); //Valor viejo
				dmg.getAttack(item).reducir(descuento.getAttack(item).getEstado()); //nuevo, minimo 0
				recibido += diferencia - dmg.getAttack(item).getEstado();
			}
			return recibido;
		}

		protected float restante(float num) { return 1 - num; }
	}
}