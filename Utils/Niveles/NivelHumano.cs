using System;
using System.Collections.Generic;

namespace Utils.Niveles{
    public class NivelHumano : Nivel{
		public static Dictionary<uint,uint> tablaComun;

		public NivelHumano(Niveliable ente, uint nivel, uint experiencia) 
				: base(ente, tablaComun, nivel, experiencia) { }
    
		}

 }
