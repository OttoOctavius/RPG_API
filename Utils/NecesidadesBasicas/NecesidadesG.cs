using System;
using System.Text;
using System.Collections.Generic;
using RPG_API.Utils;


namespace RPG_API.Utils.NecesidadesBasicas{
    public class NecesidadesG<U> : iNecesidades{
        SerVivo afectado;
        Map<String,U> tope,act;

        public NecesidadesG(SerVivo afectado,Map<String,U> necesidades){
            this.afectado = afectado;
            tope = necesidades;
            act = necesidades.copy();   //Se requiere el mismo dominio, pero estara en las condiciones extremas
        }

        public void setNecesidad(String nombre,U unidades){
            if( unidades > tope.find(nombre))
                act.find(nombre) = tope.find(nombre);   //getNecesidad permitira modificarlo?
            else
                act.find(nombre) = unidades;
        }

        public U getNecesidad(String nombre){ return act.find(nombre); }

        #region CumpliendoInterface
        public SerVivo getAfectado(){ return afectado; }
        public void update(){ getAfectado.update(); }

        public iNecesidades duplicarNecesidades(SerVivo sv){
            NecesidadesG<U> nuevo = new NecesidadesG<U>(afectado,tope);
            foreach(String nombre in tope.dom())
                nuevo.setNecesidad( nombre, nuevo.getNecesidad(nombre));

            return nuevo;
        }
        #endregion
    }

 }
