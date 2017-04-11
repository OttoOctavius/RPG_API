using System;
using System.Collections.Generic;
using RPG_API.Combate;
using System.Text;

namespace RPG_API{
    public abstract class Equipo : Niveliable,Rompible{
    	String nombre;
        String tipoEquipo; 
    	String descripcion;

	    NivelComun destreza;
    	
        Int Huecos;
    	Int magia_requerida;

        Durabilidad durabilidad;
        Defensa defensa;
    	float equilibrio;
	    float peso;
    }

 }
