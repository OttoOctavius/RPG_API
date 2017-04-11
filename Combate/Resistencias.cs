using System;
using System.Collections.Generic;

using System.Text;

namespace RPG_API{
    public class Resistencia : iIntercambioEfectosCombate{
    	DañoAlterado altMax;
    	DañoAlteradoElemental altElMax;

    	public Resistencia(float veneno,float sangrado,float maldicion,float humedad,float quemaduras,float paralisis){
    		altMax = new DañoAlteradoElemental(veneno, sangrado, maldicion);
    		altElMax = new DañoAlteradoElemental(humedad,quemaduras,paralisis);
    	}
    	
    	float veneno(){ return altMax.veneno();}
    	float sangrado(){ return altMax.sangrado();}
    	float maldicion(){ return altMax.maldicion();}

		float humedad(){ return altElMax.humedad();}
		float quemaduras(){ return altElMax.quemaduras();}
		float paralisis(){ return altElMax.paralisis();}
	}

}
