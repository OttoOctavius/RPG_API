using System;
using System.Text;
using System.Collections.Generic;
using RPG_API.Utils;


namespace RPG_API.Utils.NecesidadesBasicas{
    public interface iNecesidades{

        SerVivo getAfectado();
        void update();

        iNecesidades duplicarNecesidades(SerVivo sv);
    }

 }
