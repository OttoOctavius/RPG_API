using System;
using System.Collections.Generic;

using System.Text;
using Combat;
using Entitys.Equipment;
using Utils.Niveles;

namespace Entitys.Raza{
    public class Humano : SerVivo{
        List<Equipo> equipado;

		public Humano(Estadisticas atrib,Nivel nivel):base(atrib,nivel){
            equipado = new List<Equipo>();
        }


        public void recibirDamage(Damage ataque){/*
            foreach(Equipo eq in equipado){              //reparte el daño a todo el equipo
				ataque = eq.getDefensa.defensa;         //resto del ataque, para el personaje
            }
            ataque.Descontardelpersonaje();*/
        }

        public Equipo getEquipo(String tipoEquipo){
            Equipo actual = null;                       //Hace de cuenta que no existe
			actual = equipado.Find((Equipo obj) => obj.getNombre().Equals(tipoEquipo) );
            
            return actual;								//y mandalo
        }

        public Equipo sacarEquipo(String tipoEquipo){
            Equipo actual = getEquipo(tipoEquipo);      //Busca el tipo que corresponda
			equipado.Remove(actual);                    //eliminas del equipo
            
            return actual;
        }

        public Equipo equipar(Equipo eq){
            Equipo viejo = null; /*
            bool nohay = true;
            foreach(Equipo puesto in equipado){         //revisar todo el equipo
                if(puesto== tipoEquipo){    //para comprobar si ya hay del mismo tipo
                    nohay = false;
                    viejo = puesto;
                    equipado.add(eq);                   //ponetelo encima
                    equipado.remove(puesto);            //y elimina lo que tenias     
               }
            }

            if(nohay) equipado.add(eq); 
*/
            return viejo;
        }

    }

 }