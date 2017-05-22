using System;
namespace Combat
{
	public interface iDamage<T>
	{
		/// <summary>
		/// Reparte la defensa, una parte es absorbida por ella y sale como perdidas, lo demas disminuye el ataque.
		/// </summary>
		/// <returns>Lo que resta y va a disminuir la durabilidad o vida del anfitrion.</returns>
		/// <param name="atenuado">El descuento, su maximo debe ser 1f. Es de la defensa en contra.</param>
		T remanente(iAttack<float> atenuado);

		/// <summary>
		/// Se resta el ataque del daño, la parte efectiva de ello se devuelve.
		/// </summary>
		/// <returns>Lo que se restara de la durabilidad o vida del anfitrion.</returns>
		/// <param name="descuento">Lo que ofrece la defensa en contra.</param>
		T descontar(iAttack<T> descuento);
	}
}
