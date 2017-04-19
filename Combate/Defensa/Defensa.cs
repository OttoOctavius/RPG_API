using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API.Combate.Defensa{
    public abstract class Defensa: iAtaque{

    	public DañoMixto capacidad;
        Durabilidad durabilidad;

    	public Defensa(Durabilidad durabilidad){
            this.durabilidad = durabilidad;
        }

		//COmo el orto, cambie la interfaz de durabilidad!!!
    	public void procesarDaño(Equipo afectado,Daño ataque){
    		if(afectado ==null)	return ataque;//al final de la cadena siempre hay un null
    		afectado.durabilidad -= formaDescuento(afectado,ataque);
    		if(afectado.durabilidad <= 0.0)
    			afectado.serompio();
    	}

    	protected float formaDescuento(Equipo afectado,Daño ataque);
    }

 }
