using System;
using System.Text;
using System.Collections.Generic;
using RPG_API.Utils;

namespace RPG_API.Utils{
	public class Estadisticas {
		Map<String,uint> atributo;
		
		List<String> dominio_modificable;
		public List<String> dominio { get{ return dominio_modificable; }; 
							 set{ dominio_modificable.add(value); }; 
		}
/*		
		Daño damage_base;
		Defensa defense_base;
		Evasion evation_base;
*/
		public Estadisticas(){
			dominio_modificable = new ArrayList<String>();
			atributo = new Map<String,uint>();
/*
			damage_base = new Daño();
			defense_base = new Defensa();
			evation_base = new Evasion();*/
		}

/* 
		public Estadisticas(Daño damage, Defensa defense, Evasion evation){
			dominio_modificable = new ArrayList<String>();
			atributo = new Map<String,uint>();

			damage_base = damage;
			defense_base = defense;
			evation_base = evation;
		}
		*/
		public int qatributo { get(String nombre){ atributo.get("nombre")}; set; }

	    /*uint  fuerza;
	    uint  destreza;
	    uint  agilidad;
	    uint  aguante;

	    uint  vitalidad;
	    uint  stamina;
	    uint  mana;

		uint 	fe;
	    uint  inteligencia
	    uint  sabiduria;*/

		public Estadisticas getReporteMejoras(String atributo);
	}
 }
