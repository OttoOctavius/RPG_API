using Combat;
using System;
using Utils;

namespace Combate.Attacks
{
	public class AttackSimple : iAttack<float>{

	protected String tipo1;
	protected float ataque1;

	private float maximo;

	public AttackSimple(String tipo, float val, float maximo)
	{
		tipo1 = tipo;
		this.maximo = maximo;
		ataque1 = (val > maximo) ? maximo : val;
	}

	public AttackSimple(String tipo, float val)
	{
		tipo1 = tipo;
		maximo = val;
		ataque1 = val;
	}


		float iAttack<float>.getAttack(string tipo)
		{
			if (tipo1.equals(tipo))
				return ataque1;
			else
				return 0f;
		}

		iAttack<float> iAttack<float>.copy()
		{
			return new AttackSimple(tipo1, ataque1, maximo);
		}

		string[] iAttack<float>.getTypes()
		{
			return new string[] { tipo1 };
		}
	}
}