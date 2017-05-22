using System;
using System.Collections.Generic;

namespace Entitys.Equipment{
    public class Guantes : Equipo{
			public Guantes(uint durabilidadMaxima, PesoEquipo tipoEq, float peso)
			:base( durabilidadMaxima,tipoEq,peso) {   }
	}
}
