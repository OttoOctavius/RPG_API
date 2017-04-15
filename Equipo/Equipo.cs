using System;
using System.Collections.Generic;
using RPG_API.Combate;
using RPG_API.Utils;
using System.Text;

namespace RPG_API.Equipo{
    public abstract class Equipo : Rompible{
    	String nombre;
    	String descripcion;
    	PesoEquipo tipoEquipo;
        //Int Huecos;
    	//Int magia_requerida;
        //Equipo interno

        Durabilidad durabilidad;
        Defensa defensa;
    	float equilibrio;
	    float peso;
        

    }
 }
