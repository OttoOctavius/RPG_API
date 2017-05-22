using System;
using System.Collections.Generic;

using System.Text;
using Entitys;
using Entitys.Equipment;

namespace Entitys.Equipment{
    public class Botas : Equipo{
			public Botas(uint durabilidadMaxima, PesoEquipo tipoEq, float peso)
				:base( durabilidadMaxima,tipoEq,peso ) { 
		}
    }    

 }
