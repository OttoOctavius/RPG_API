using System;
using System.Text;
using System.Collections.Generic;
using RPG_API.Utils;


namespace RPG_API.Entidades{
    public abstract class SerVivo : Ente{
    	Atributos atrib;
    	Nivel lv;

    	float vida_act;
    	float stamina_act;
    	float mana_act;


        Int hambre,sed;
        public SerVivo(Atributos atrib,Nivel nivel){
            lv = nivel;
            this.actualizarNivel();

            vida_act = atrib.vida;
            stamina_act = atrib.stamina;
            mana_act = atrib.mana;
            hambre = 0;
            sed = 0;
        }

    	public bool murio(){
    		return vida_act<=0;
    	}

        public void actualizarNivel();
    }

 }
