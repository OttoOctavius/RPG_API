using System;
using System.Text;
using System.Collections.Generic;
using RPG_API.Utils;


namespace RPG_API.Utils.NecesidadesBasicas{
    public class NecesidadesHambreySed<H,S> : iNecesidades{
        SerVivo afectado;
        H tope_hambre, hambre;
        S tope_sed, sed;

        public NecesidadesHambreySed(SerVivo sv,H maximaHambre,S maximaSed){
            afectado = sv;
            tope_hambre = maximaHambre;
            maximaSed = tope_sed;
        }

        public void setHambre(H act){ hambre = act; }

        public void setSed(S act){ sed = act; }

        public H getHambre(){ return hambre; }
        public S getSed(){ return sed; }


        #region CumpliendoInterface
        public SerVivo getAfectado(){ return afectado; }
        public void update(){ getAfectado.update(); }

        public iNecesidades duplicarNecesidades(SerVivo sv){
            NecesidadesHambreySed<H,S> nuevo = new NecesidadesHambreySed<H,S>(sv,tope_hambre,tope_sed);
            nuevo.setHambre( this.getHambre());
            nuevo.setSed( this.getSed());
            return nuevo;
        }
        #endregion
    }

 }
