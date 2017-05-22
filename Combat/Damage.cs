using System;
using Combat.Attacks;

namespace Combat{
	public class Damage :iDamage<float> {

		private iAttack<float> atq;

		public Damage(iAttack<float> attack){
			atq = attack;
		}

		/**
        Se espera que el que lo invoco sea del tipo fraccionario
        */
		public float remanente(iAttack<float> atenuado)
		{
			float recibido = 0f;	//Se podria usar un lindo fold, no?
			var atkMax = atenuado.copy().add(atenuado.AttackMax());

			foreach (var item in getTypes())
				recibido += atq.getAttack(item) * atenuado.getAttack(item);	
			
			atq.mulAttack( atkMax.remAttack(atenuado) );
			return recibido;
		}

		/**
        Se le resta el valor de descuento al ataque
         */
		public float descontar(iAttack<float> descuento){
			float recibido = 0f;
			var cp = atq.copy();
			atq.remAttack( descuento );

            foreach (var item in getTypes())
				recibido +=  cp.getAttack(item) - atq.getAttack(item);
			return recibido;           
		}

		public string[] getTypes()
		{
			return atq.getTypes();
		}

    }
}