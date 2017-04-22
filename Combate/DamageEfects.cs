using RPG_API.Combate.Ataque;

namespace RPG_API.Combate{
    public DamageEfects{
    	private AtaqueSimple ataque;

    	public DamageEfects(AtaqueSimple min,EfectoType efect){
    		ataque = min;
    		efecto = efect;
    	}

    	public bool check(Ataque dmg){
    		return dmg.tipo(ataque.tipo) ;
    	}
    	public void apply(){
    		
    	}
    }
}