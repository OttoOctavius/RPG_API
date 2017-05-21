using System;
using System.Text;
using System.Collections.Generic;
using Utils;
using Utils.Niveles;
using Combat;

namespace Entitys.Raza{
    public abstract class SerVivo : Ente, Observer ,Niveliable{
		Estadisticas atrib;
    	Nivel lv;

        public ParametroRecargable vida,stamina,mana;

        public SerVivo(Estadisticas atrib,Nivel nivel){
            lv = nivel;
        

			vida = new ParametroRecargable(atrib.qatributo("vida"),this);
			stamina = new ParametroRecargable(atrib.qatributo("stamina"),this);
            mana = new ParametroRecargable(atrib.qatributo("mana"),this);
        }

    	public bool murio(){
			return vida.getEstado.get() <=0;
    	}

		public void subioNivel()
		{
			throw new NotImplementedException();
		}

		public void puedeSubir()
		{
			throw new NotImplementedException();
		}

		public void avisar(string mensaje)
		{
			throw new NotImplementedException();
		}

		public void recibirDamage(Damage ataque)
		{
			throw new NotImplementedException();
		}
	}

 }
