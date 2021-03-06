using System;
using System.Collections.Generic;
using Combat;
using Utils;
using System.Text;
using Entitys;
using Entitys.Tipos;

namespace Entitys.Equipment{
    public class Equipo : Observer,iRecogibles{

		public Equipo(uint durabilidadMaxima, PesoEquipo tpPeso, float peso ){
            durabilidad = new UInt(durabilidadMaxima);
			this.peso = peso;
			tipoEquipo = tpPeso; 
        }

		public TypeStrategy modificador;
		//Int Huecos;
		//Int magia_requerida;
		//Equipo interno

		protected PesoEquipo tipoEquipo;
		protected UInt durabilidad;
		protected Defense defensa;
    	protected float equilibrio;
	    protected float peso;

        public UInt getDurabilidad { get{ return durabilidad;} }
        public Defense getDefensa { get{ return defensa;} }
        public float getPeso { get{ return peso;} }

		public PesoEquipo TipoEquipo
		{
			get
			{
				return tipoEquipo;
			}
		}

		public string getNombre()
		{
			return modificador.getNombre();
		}

		public string getDescripcion()
		{
			return modificador.getDescripcion();
		}

		void Observer.avisar(string mensaje)
		{
			throw new NotImplementedException();
		}
	}
 }
