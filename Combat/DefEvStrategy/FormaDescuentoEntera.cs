using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API.Combate.DefEvStrategy{
    public class FormaDescuentoEntera{

    	public float formaDescuento(Equipo afectado,Daño ataque){
            return ataque.descontar(afectado.defensa);
        }
    }

 }