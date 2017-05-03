using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API.Combate{
    public class Defense{

		private FormaDescuento estilo
    	public Ataque defensa;
        Equipo equipo;

    	public Defensa(Equipo equipo, FormaDescuento estilo){
            this.equipo = equipo;
			this.descuento = estilo;
        }

		//COmo el orto, cambie la interfaz de durabilidad!!!
    	public void procesarDaño(Damage dmg){
    		equipo.durabilidad.reducir( formaDescuento(afectado,dmg) );
    	}

		//Aqui usar un strategy
    	protected float formaDescuento(Equipo afectado,Daño ataque){
			estilo.formaDescuento(afectado,ataque);
		}
    }

 }
