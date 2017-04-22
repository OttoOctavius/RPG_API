using System;
using System.Collections.Generic;
using RPG_API.Combate;
using RPG_API.Utils;
using RPG_API.Utils.ParametrosVariables;
using System.Text;

namespace RPG_API.Recogibles{
    public interface iRecogibles
    {
        String getNombre(); 
        String getDescripcion();
    }
}