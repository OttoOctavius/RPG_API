using System;
using System.Collections.Generic;

using System.Text;

namespace Entitys.Equipment{
    public class Casco : Equipo{
		public Casco(float durabilidadMaxima,PesoEquipo tipoEq, float peso)
			:base( (uint) durabilidadMaxima,tipoEq,peso){
            }
    }    

 }
