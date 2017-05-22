using System;

namespace Combat{
    public interface iAttack<T>{
		
		/// <summary>
		/// Obtiene el maximo valor que puede tomar el ataque.
		/// </summary>
		/// <returns>El maximo.</returns>
		T AttackMax();

		/// <summary>
		/// Obtiene la correspondiente magnitud para el "tipo" de daño
		/// </summary>
		/// <returns>La magnitud.</returns>
		/// <param name="tipo">El tipo de daño.</param>
		T getAttack(string tipo);

		/// <summary>
		/// Agrega el ataque al que ya se tiene, componente a componente.
		/// </summary>
		/// <returns>El total.</returns>
		/// <param name="ataque">Ataque a sumar.</param>
		iAttack<T> addAttack(iAttack<T> ataque);

		/// <summary>
		/// Resta el ataque del que se tiene, componente a componente.
		/// </summary>
		/// <returns>El total.</returns>
		/// <param name="ataque">Ataque a restar.</param>
		iAttack<T> remAttack(iAttack<T> ataque);

		/// <summary>
		/// Multiplica el ataque componente a componente.
		/// </summary>
		/// <returns>El total.</returns>
		/// <param name="ataque">Ataque a restar.</param>
		iAttack<T> mulAttack(iAttack<float> ataque);


		/// <summary>
		/// Suma num a todos los ataques.
		/// </summary>
		/// <returns>El total.</returns>
		/// <param name="num">Cuanto a sumar.</param>
		iAttack<T> add(T num);

		/// <summary>
		/// Resta num a todos los ataques.
		/// </summary>
		/// <returns>El total.</returns>
		/// <param name="num">Cuanto a restar.</param>
		iAttack<T> rem(T num);

		/// <summary>
		/// Multiplica num a todos los ataques.
		/// </summary>
		/// <returns>El total.</returns>
		/// <param name="num">Cuanto a multiplicar.</param>
		iAttack<T> mul(float num);

		/// <summary>
		/// Copy esta instancia.
		/// </summary>
		/// <returns>La copy.</returns>
		iAttack<T> copy();

		/// <summary>
		/// Obtiene todos los tipos de ataques.
		/// </summary>
		/// <returns>Los tipos.</returns>
		string[] getTypes();
    }
}