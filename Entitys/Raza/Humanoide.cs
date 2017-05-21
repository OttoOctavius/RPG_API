using System;
using System.Collections.Generic;

using System.Text;
using Combat;
using Entitys.Equipment;
using Utils.Niveles;

namespace Entitys.Raza{
    public class Humanoide : SerVivo{
    	List<Equipo> equipado;

		public Humanoide(Estadisticas atrib, Nivel nivel):base(atrib,nivel){
            equipado = new List<Equipo>();
        }

    	public new void recibirDamage(Damage ataque){
    		foreach(Equipo eq in equipado){//reparte el daño a todo el equipo
				eq.getDefensa.procesarDgm(ataque);
            }

			//resto del ataque, para el personaje
			//foreach (string st in ataque.getTypes())
			//	vida.atenuar((ataque.dmg as iAttack<float>).getAttack(st) ) ;
    	}
		/*
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
        }*/


    }

 }
