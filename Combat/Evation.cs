using System;
using System.Collections.Generic;
using Combat.Attacks;
using System.Text;
using Utils;

namespace Combat{
    public class Evation<T>{

    	public iAttack<float> evasion;
		private iReceptor afectado;

		public Evation(iReceptor rec){
			this.afectado = rec;
        }

    	public void procesarDgm(Damage dmg, float evadio){
			var max = evasion.AttackMax();
			var atkEfectivo = evasion.copy().rem( max );
			foreach(string tipo in dmg.getTypes()){     //Para cada tipo de ataque del daño
				if (evasion.getAttack(tipo) > evadio)     //Si las chances de evasion se cumplen
					atkEfectivo.addAttack(new AttackSimple<float>(tipo, new Float(max)));
                }

			dmg.remanente(atkEfectivo);
    	}

    }

 }
