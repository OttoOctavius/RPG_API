using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API{
    public class DefensaEntera:Defensa{
    	public DefensaEntera(Durabilidad durabilidad):super(durabilidad);

    	public float formaDescuento(Equipo afectado,Daño ataque){
            return ataque.descontar(afectado.defensa);
        }
    }

 }