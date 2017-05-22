using System;
using System.Collections.Generic;
using Entitys;
using System.Text;
using Entitys.Equipment;

namespace Entitys.Equipment{
    public class Armadura : Equipo{
		
		public Armadura(uint durabilidadMaxima, PesoEquipo tipoEq, float peso)
			:base( durabilidadMaxima,tipoEq,peso) {   }
    }    

 }