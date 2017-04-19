using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API{
    public class Humano : SerVivo{
        List<Equipo> equipado;

        public Humano(Atributos atrib,Nivel nivel):super(atrib,nivel){
            equipado = new ArrayList<Equipo>();
        }


        public recibirDaño(Daño ataque){
            foreach(Equipo eq sin equipado){              //reparte el daño a todo el equipo
                ataque = eq.recibirDaño(ataque);         //resto del ataque, para el personaje
            }
            ataque.Descontardelpersonaje();
        }

        public Equipo getEquipo(String tipoEquipo){
            Equipo actual = null;                       //Hace de cuenta que no existe

            foreach(Equipo eq in equipado){             //buscalo en el equipo
                if(eq.tipoEquipo == tipoEquipo)         //si lo encontras
                    actual = eq;                        //reemplazalo 
            }

            return actual;								//y mandalo
        }

        public Equipo sacarEquipo(String tipoEquipo){
            Equipo actual = getEquipo(tipoEquipo);      //Busca el tipo que corresponda
            equipado.remove(actual);                    //eliminas del equipo
            
            return actual;
        }

        public Equipo equiparEquipo(Equipo eq){
            Equipo viejo = null;
            bool nohay = true;
            foreach(Equipo puesto in equipado){         //revisar todo el equipo
                if(puesto.tipoEquipo == tipoEquipo){    //para comprobar si ya hay del mismo tipo
                    nohay = false;
                    viejo = puesto;
                    equipado.add(eq);                   //ponetelo encima
                    equipado.remove(puesto);            //y elimina lo que tenias     
               }
            }

            if(nohay) equipado.add(eq); 

            return viejo;
        }

    }

 }