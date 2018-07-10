

class GEM{
	int type;
	double scor;
	POS current_pos;
	
	///в данной функции происходит создание модели на верхней части экрана и последующее подение ее на нужную позицию
	void spawn(POS.y, POS.x){
		instatinate (pos.x, MAX_Y) 
		type = random();
		fall(POS);
	}
	
	void Start(){
		scor = type * 25;//определяем получаемые очки за уничтожение
	}
	
	double Destr(){ //функция уничтожения + возвращение кол-ва очков
		
		Play animation;
		Destroy();
		return score;
		
	}
	
	void fall(new_pos)//функция "падения на новую позицию"
	{
		Play animation;
		current_pos = new_pos;
	}
	
	
	
	
}