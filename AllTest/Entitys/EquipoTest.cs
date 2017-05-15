using System;
using System.Collections.Generic;
using RPG_API.Combate;
using RPG_API.Utils;
using System.Text;

namespace RPG_API.Equipo.Test{
    public class EquipoTest{
        
        public void testComprobarCreacionEquipo(){
            Equipo eq = new Guantes("nom", "desc", 10f,10f);
            assert(eq.getNombre == "nom");
            assert(eq.getDescripcion == "desc");
            assert(eq.getDurabilidad.deQue == 10f);
            assert(eq.getPeso == 10f);
        }
 
    }
 }
