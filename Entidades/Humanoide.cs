using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API{
    public class Humanoide : SerVivo{
    	List<Equipo> equipado;

        public Humanoide(Atributos atrib,Nivel nivel):super(atrib,nivel){
            equipado = new List<Equipo>();
        }

    	public recibirDaño(Daño ataque){
    		foreach(Equipo eq in equipado){              //reparte el daño a todo el equipo
                ataque = eq.recibirDaño(ataque);         //resto del ataque, para el personaje
            }
            ataque.Descontardelpersonaje();
    	}

        public Equipo getEquipo(String tipoEquipo){
            Equipo actual = null;                       //Hace de cuenta que no existe

            foreach(Equipo eq in equipado){             //buscalo en el equipo
                if(eq.tipoEquipo == tipoEquipo)         //si lo encontras
                    actual = eq;                        //reemplazalo y mandalo
            }

            return actual;
        }

        //MALLLLLLLLLLLLLLLLLLLLl, el otro tambien
        public Equipo sacarEquipo(String tipoEquipo){
            Equipo actual = getEquipo(tipoEquipo);      //Busca el tipo que corresponda
            try{                                        //puede que falle porque no lo tenes
                equiparEquipo(actual.interno);          //te equipas con lo que tengas debajo
                equipado.remove(actual);                //eliminas la capa superior
            }
            catch(Exception e){}
            return actual;
        }

        public void equiparEquipo(Equipo eq){
            bool nohay = true;

            foreach(Equipo puesto in equipado){         //revisar todo el equipo
                if(puesto.tipoEquipo == tipoEquipo){    //para comprobar si ya hay del mismo tipo
                    nohay = false;
                    equipado.remove(puesto);            //elimina lo que tenias   
                    eq.interno = puesto;
                    equipado.add(eq);                   //ponetelo encima
  
               }
            }

            if(nohay) equipado.add(eq); 
        }


    }

 }
