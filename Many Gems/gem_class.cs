class GEM{
	int type;
	double scor;
	POS current_pos;
	
	void spawn(POS.y, POS.x_max){
		type = random();
	}
	
	void Start(){
		scor = type * 25;//определяем получаемые очки за уничтожение
		
	}
	
	double Destr(){ //функция уничтожения + возвращение кол-ва очков
		
		Play animation;
		Destroy();
		return score;
		
	}
	
	void fall(new_pos)
	{
		Play animation;
		current_pos = new_pos;
	}
	
	
	
	
}