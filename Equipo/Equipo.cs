using System;
using System.Collections.Generic;
using RPG_API.Combate;
using RPG_API.Utils;
using System.Text;

namespace RPG_API.Equipo{
    public abstract class Equipo : Rompible{
    	private String nombre;
        public String getNombre { get{ return nombre;}; }
    	private String descripcion;
        public String getDescrip { get{ return descripcion;}; }

        public Equipo(String nombre, String descripcion, float durabilidadMaxima){
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.durabilidad = new Durabilidad(durabilidadMaxima,this);
        }
        
        //Int Huecos;
    	//Int magia_requerida;
        //Equipo interno

        protected PesoEquipo tipoEquipo = PesoEquipo.MuyLigero;
        protected Durabilidad durabilidad;
        protected Defensa defensa;
    	protected float equilibrio;
	    protected float peso;

        public Durabilidad getDurabilidad { get{ return durabilidad;}; }
        public Defensa getDefensa { get{ return defensa;}; }
        public float getPeso { get{ return peso;}; }
    }
 }
