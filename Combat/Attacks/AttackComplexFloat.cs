using System.Collections.Generic;
using Combate;
using System;
using Combat;
using Utils;

namespace Combat.Attacks
{
	
	public class AttackComplexFloat : AttackComplex<float>
	{
		public AttackComplexFloat(float minimo, float maximo){
			base( new Float(minimo), new Float(maximo) );
		}


		public AttackComplexFloat addAttack(string tipo, float ataque)
		{
			base.addAttack( new AttackSimple<float>(tipo,ataque) );
			return this;
		}

		public AttackComplexFloat remAttack(string tipo, float ataque)
		{
            base.remAttack( new AttackSimple<float>(tipo,ataque) );
			return this;
		}

		public AttackComplexFloat mulAttack(float ataque)
		{
			base.mulAttack(ataque);
			return this;
		}

	}
}