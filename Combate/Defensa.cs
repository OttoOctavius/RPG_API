using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API{
    public abstract class Defensa: iIntercambioCombate{

    	public DañoMixto capacidad;
        Durabilidad durabilidad;

    	public Defensa(Durabilidad durabilidad){
            this.durabilidad = durabilidad;
        }

    	public void procesarDaño(Equipo afectado,Daño ataque){
    		if(afectado ==null)	return ataque;//al final de la cadena siempre hay un null
    		afectado.durabilidad = formaDescuento(afectado,ataque);
    		if(afectado.durabilidad <= 0.0)
    			afectado.serompio();
    	}

    	public float formaDescuento(Equipo afectado,Daño ataque);
    }

 }