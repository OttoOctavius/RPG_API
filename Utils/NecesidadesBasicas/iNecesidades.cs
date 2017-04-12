using System;
using System.Text;
using System.Collections.Generic;
using RPG_API.Utils;


namespace RPG_API.Utils.NecesidadesBasicas{
    public interface iNecesidades{

        public SerVivo getAfectado();
        public void update();

        public iNecesidades duplicarNecesidades(SerVivo sv);
    }

 }
