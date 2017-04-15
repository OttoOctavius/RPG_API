using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API.Combate.Defensa{
    public class DefensaFraccionaria: Defensa{
    	public DefensaFraccionaria(Durabilidad durabilidad):super(durabilidad);

        protected float formaDescuento(Equipo afectado,Daño ataque){
            return ataque.remanente(afectado.defensa);
        }
    }

 }