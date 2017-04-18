using System;
using System.Text;
using System.Collections.Generic;
using RPG_API.Utils.*;


namespace RPG_API.Entidades{
    public abstract class SerVivo : Ente, iNecesidades, Observer ,Niveliable{
    	Atributos atrib;
    	Nivel lv;

        public ParametrosVariables vida,stamina,mana;

        iNecesidades nec;

        public SerVivo(Atributos atrib,Nivel nivel){
            lv = nivel;
            this.actualizarNivel();

            vida = new ParametrosVariables(atrib.vida,this,"vida");
            stamina = new ParametrosVariables(atrib.stamina,this,"stamina");
            mana = new ParametrosVariables(atrib.mana,this,"mana");
        }

    	public bool murio(){
    		return vida.getEstado()<=0;
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
