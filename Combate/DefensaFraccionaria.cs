using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API{
    public class DefensaFraccionaria: Defensa{
    	public DefensaFraccionaria(Durabilidad durabilidad):super(durabilidad);

        public float formaDescuento(Equipo afectado,Daño ataque){
            return ataque.remanente(afectado.defensa);
        }
    }

 }