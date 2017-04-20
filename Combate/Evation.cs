using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API.Combate{
    public class Evation{

    	public Ataque evasion;
        Equipo equipo;

    	public Defensa(Equipo equipo){
            this.equipo = equipo;
        }

    	public void procesarDgm(Damage dmg, float evadio){
            foreach(String tipo in dmg.getTipo()){     //Para cada daño
                if(evasion.getAtaque(tipo)>evadio)     //Si las chances de evasion se cumplen
                    dmg.remover(tipo);                   //Absorbe todo
                }
            equipo.procesarDgm(dmg);
    	}

    }

 }
