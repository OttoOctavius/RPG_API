using System;
using System.Text;
using System.Collections.Generic;
using RPG_API.Utils;


namespace RPG_API.Entidades{
    public abstract class SerVivo : Ente, iNecesidades{
    	Atributos atrib;
    	Nivel lv;

    	float vida_act;
    	float stamina_act;
    	float mana_act;
        iNecesidades nec;

        public SerVivo(Atributos atrib,Nivel nivel){
            lv = nivel;
            this.actualizarNivel();

            vida_act = atrib.vida;
            stamina_act = atrib.stamina;
            mana_act = atrib.mana;
        }

    	public bool murio(){
    		return vida_act<=0;
    	}

        public void actualizarNivel();

        //region necesidades
        public SerVivo getAfectado(){ return this;}     //Solo esta no sirve :/
        public void update();

        public iNecesidades duplicarNecesidades(SerVivo sv){
                return nec.duplicarNecesidades(sv);
        }
        //endregion

    }

 }
