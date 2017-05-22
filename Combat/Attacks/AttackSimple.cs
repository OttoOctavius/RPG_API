using Combat;
using System;
using Utils;

namespace Combat.Attacks{
	public class AttackSimple<T> : iAttack<T>
	{

		protected string tipo;
		protected iVar<T> ataque;
		public static T maximo;

		public AttackSimple(string tipo, iVar<T> val)
		{
			this.tipo = tipo;
			ataque = val;
		}

		public iAttack<T> cast() { return this; }

		#region Interfaz
		iAttack<T> iAttack<T>.copy() { return new AttackSimple<T>(tipo, ataque); }
		string[] iAttack<T>.getTypes() { return new string[] { tipo }; }

		T iAttack<T>.AttackMax()
		{
			return maximo;
		}

		T iAttack<T>.getAttack(string tipo)
		{
			if (string.Equals(this.tipo, tipo))
				return ataque.get();
			else
				return ataque.nulo();
		}

		iAttack<T> iAttack<T>.addAttack(iAttack<T> ataque)
		{
			return cast().add(ataque.getAttack(tipo));
		}

		iAttack<T> iAttack<T>.remAttack(iAttack<T> ataque)
		{
			return cast().rem(ataque.getAttack(tipo));
		}

		iAttack<T> iAttack<T>.mulAttack(iAttack<float> ataque)
		{
			return cast().mul(ataque.getAttack(tipo));
		}

		iAttack<T> iAttack<T>.add(T num)
		{
			this.ataque.add(num);
			if (ataque.CompareTo(maximo) > 0) ataque.set(maximo);
			return this;
		}

		iAttack<T> iAttack<T>.rem(T num)
		{
			this.ataque.reduce(num);
			if (ataque.CompareTo(ataque.nulo()) < 0) ataque.set(ataque.nulo());
			return this;
		}

		iAttack<T> iAttack<T>.mul(float num)
		{
			this.ataque.mult(num);
			return this;
		}
		#endregion
	}

}