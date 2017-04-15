using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API.Combate.Defensa{
    public class DefensaEntera:Defensa{
    	public DefensaEntera(Durabilidad durabilidad):super(durabilidad);

    	protected float formaDescuento(Equipo afectado,Daño ataque){
            return ataque.descontar(afectado.defensa);
        }
    }

 }