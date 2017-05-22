using System;
using System.Collections.Generic;
using System.Text;
using Combat.DefEvStrategy;
using Combat.Attacks;
using Utils;

namespace Combat{
    public class Defense{

		iReceptor afec;
		FormaDescuento descuento;

		public iAttack<float> defensa;

		public Defense(iReceptor rec,FormaDescuento estilo){
			this.afec = rec;
			this.descuento = estilo;
        }

    	public void procesarDgm(Damage dmg){
			foreach (string item in defensa.getTypes())
				;
				//afec.receptor(item).atenuar( descuento.formaDescuento(afec,dmg) );
    	}
    }

 }
