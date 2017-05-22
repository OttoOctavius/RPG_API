using Combat;
using System;
using System.Collections.Generic;
using Utils;

namespace Combat.Attacks{
	/**Sirve para aclarar cuales son todos los tipos de ataque
     */
	public class AttackComplex<T> : iAttack<T>
	{
		private Dictionary<string, iVar<T>> ataques;
		private iVar<T> max, min;

		public AttackComplex(iVar<T> minimo, iVar<T> maximo)
		{
			ataques = new Dictionary<string, iVar<T>>();

			max = maximo;
			min = minimo;
		}

		private iVar<T> buscarOcrear(string tipo)
		{
			Console.WriteLine(ataques.Keys.Count);
			if (!ataques.ContainsKey(tipo))
			{
				var nuevo = min.copy();
				ataques.Add(tipo, nuevo);
				return nuevo;
			}
			else
			{
				return ataques[tipo];
			}
		}

		public iAttack<T> cast() { return this; }

		/// <summary>
		/// Elimina los ataques inutiles. Se recomienda usar al final.
		/// </summary>
		public AttackComplex<T> formatear()
		{
			foreach (var item in ataques.Keys)
				if (ataques[item].Equals(min)) ataques.Remove(item);
			return this;
		}

		#region Interfaz
		T iAttack<T>.getAttack(string tipo)
		{
			if (ataques.ContainsKey(tipo))
				return ataques[tipo].get();
			else
				return min.get();
		}

		string[] iAttack<T>.getTypes()
		{
			var cadenas = new string[ataques.Keys.Count];
			ataques.Keys.CopyTo(cadenas, 0);
			return cadenas;
		}

		iAttack<T> iAttack<T>.copy()
		{
			return (new AttackComplex<T>(min, max) as iAttack<T>).addAttack(this);
		}

		T iAttack<T>.AttackMax()
		{
			return this.max.get();
		}

		iAttack<T> iAttack<T>.addAttack(iAttack<T> ataque)
		{
			foreach (string tipo in ataque.getTypes())
			{
				var buscado = buscarOcrear(tipo);
				buscado.add(ataque.getAttack(tipo));
				if (buscado.CompareTo(max) == 1) buscado.set(max.get());
			}
			return this;
		}

		iAttack<T> iAttack<T>.remAttack(iAttack<T> ataque)
		{
			foreach (var tipo in ataque.getTypes() )
			{
				var buscado = buscarOcrear(tipo);
				buscado.reduce(ataque.getAttack(tipo));
				if (buscado.CompareTo(min) == -1) buscado.set(min.get());
			}				

			return this;
		}

		iAttack<T> iAttack<T>.mulAttack(iAttack<float> ataque)
		{
			foreach (var tipo in ataque.getTypes())
			{
				var buscado = buscarOcrear(tipo);
				buscado.mult(ataque.getAttack(tipo));
				if(buscado.CompareTo(max) == 1) buscado.set(max.get());
					else if(buscado.CompareTo(min) == -1) buscado.set(min.get());
			}
			return this;
		}

		iAttack<T> iAttack<T>.add(T num)
		{
			foreach (string tipo in cast().getTypes())
				buscarOcrear(tipo).add(num);
			return this;
		}

		iAttack<T> iAttack<T>.rem(T num)
		{
			foreach (string tipo in cast().getTypes())
				buscarOcrear(tipo).reduce(num);
			return this;
		}

		iAttack<T> iAttack<T>.mul(float num)
		{
			foreach (string tipo in cast().getTypes())
				buscarOcrear(tipo).mult(num);
			return this;
		}
		#endregion
	}
}