using System;
using System.Collections.Generic;
using RPG_API.Combate;
using RPG_API.Utils;
using RPG_API.Utils.ParametrosVariables;
using System.Text;

namespace RPG_API.Equipo{
    public abstract class Equipo : Observer{
    	private String nombre;
        public String getNombre { get{ return nombre;}; }
    	private String descripcion;
        public String getDescrip { get{ return descripcion;}; }

        public Equipo(String nombre, String descripcion, float durabilidadMaxima){
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.durabilidad = new ParametroRecargable(durabilidadMaxima,this,"Durabilidad");
        }
        
        //Int Huecos;
    	//Int magia_requerida;
        //Equipo interno

        protected PesoEquipo tipoEquipo = PesoEquipo.MuyLigero;
        protected ParametroRecargable durabilidad;
        protected Defensa defensa;
    	protected float equilibrio;
	    protected float peso;

        public ParametroRecargable getDurabilidad { get{ return durabilidad;}; }
        public Defensa getDefensa { get{ return defensa;}; }
        public float getPeso { get{ return peso;}; }

        void avisar(String mensaje){
            System.Windows.Forms.MessageBox.Show("roto");
        }
    }
 }
