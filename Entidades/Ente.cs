using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API{
    public abstract class Ente<Coordenadas>{
  
  	public Coordenadas getPosicion();
    	public void recibirDaño(Daño ataque);
    }

 }
