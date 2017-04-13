using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API.Entidades.Test{
    public class TestSerVivo{

    	@Test
    	public setUpCrearSerVivo(Atributos atrib,Nivel nivel){
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
