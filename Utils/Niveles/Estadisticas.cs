using System;
using System.Text;
using System.Collections.Generic;
using Utils;

namespace Utils.Niveles{
	public class Estadisticas {
		Dictionary<String,UInt> atributo;
		
		List<string> dominio_modificable;
		public List<string> dominio{ 
			get{ return dominio_modificable; }
			set{ dominio_modificable.AddRange(value); }
		}
/*		
		Daño damage_base;
		Defensa defense_base;
		Evasion evation_base;
*/
		public Estadisticas(){
			dominio_modificable = new List<string>();
			atributo = new Dictionary<string, UInt>();
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
		public UInt qatributo(string nombre){
			return atributo[nombre];
		}

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

		public virtual Estadisticas getReporteMejoras(string atributo){
			throw new Exception();
		}
	}
 }
