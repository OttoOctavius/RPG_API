using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API.Combate.Defensa{
    public class FormaDescuentoFraccionaria{

        public float formaDescuento(Equipo afectado,Daño ataque){
            return ataque.remanente(afectado.defensa);
        }
    }

 }