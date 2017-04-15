using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API{
    public class Casco{
		public Casco(String nombre, String descripcion, float durabilidadMaxima,float peso)
            :super(nombre,descripcion,durabilidadMaxima){
                defensa = new DefensaEntera(this.getDurabilidad);
                //falta configurar la defensa
                this.peso = peso;
            }
    }    

 }
