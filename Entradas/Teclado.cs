using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework.Input;

namespace RPG_API{
    public class Teclado{
        Bag<Combos> combos;
        Map<Botones,Keys> botones;

        List<Botones> registro_precionados;
        Botones foco;

        public Teclado(Map<Botones,Keys> botones){
            combos = new Bag<Combos>();
            this.botones = botones;
            this.registro_precionados = new List<Botones>();
        }

        public bool ComprobarArma()
        {
            foreach (Botones bot in botones.dominio)
            {
                Keys key = botones.map(bot);
                if (InputManager.algo.KeyDown( botones.map(Botones.manoIzq))
                    return true;
            }
        }

        public void perderFoco(){
        	registro_precionados.reset();
        	registro_precionados = null;
        }

		public void ganarFoco(Botones importante){
        	foco = importante;
        }



    }
}
