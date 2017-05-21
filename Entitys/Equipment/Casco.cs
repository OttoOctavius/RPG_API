using System;
using System.Collections.Generic;

using System.Text;

namespace Entitys.Equipment{
    public class Casco : Equipo{
		public Casco(String nombre, String descripcion, float durabilidadMaxima,float peso)
			:base( (uint) durabilidadMaxima){
                //falta configurar la defensa
                this.peso = peso;
            }
    }    

 }
