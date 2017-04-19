using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API.Combate.Defensa{
    public class Evasion: iIntercambioCombate{
        DefensaFraccionaria evasion;

    	public Evasion(DefensaFraccionaria evasion ){
            this.evasion = evasion;
        }

    	public void procesarDaño(Daño ataque, float evadio){
            DañoBuilder def_ficticia = new DañoBuilder();
            Equipo eqFic = new Armadura();
            foreach(String tipo in Daño.getTipo()){ //Para cada daño
                if(evasion.getDaño(tipo)>evadio)    //Si las chances de evasion se cumplen
                    def_ficticia.agregarDañoIndividual(tipo,1.0);  //Absorbe todo
                }
            eqFic.defensa = def_ficticia.build();
            eqFic.procesarDaño(ataque);
    	}

    }

 }
