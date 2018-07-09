
//где-нибудь в нэймспейсе, прописать структуру ГЕМ


namespace gg{
	class g_master{//класс, отвечающий за проведение игры
		
		
		int pool [H_max][W_max];
		
		gmaster(int w, int h){
			Initialization(int w, int h);
		}
		
		void Initialization(int w, int h){
			for (w1<w;w1++)
				for (h1<h;h1++)
					pool [w1][h1] = 0;
			}
			
		
		
		
		
		everyTime loop listener
		
		bool slover(){ //решатель/подсказыватель. вызывать функцию только при совершении действий
		
			
			bool t;
			return t;
			
		}
		
		void listener(){//слушатель перемещений мышки/пальца
			if (touch){
			mem position
			mem on relase position
			}
			
				
		}
		
		bool tryDestroy(POS, type){//смотрим можно ли уничножить ГЕМы нах-иеся рядом
			bool r = false;
			if (type == GEM[POS.x-1][POS.y].type) {
				if (type == GEM[POS.x-2][POS.y].type) || (type == GEM[POS.x-1][POS.y+1].type) (type == GEM[POS.x-1][POS.y-1].type)
					r = true;
			}else if (type == GEM[POS.x+1][POS.y].type){
				if (type == GEM[POS.x+2][POS.y].type) || (type == GEM[POS.x+1][POS.y+1].type) (type == GEM[POS.x+1][POS.y-1].type)
					r = true;
			}else if (type == GEM[POS.x][POS.y+1].type){
				if (type == GEM[POS.x+1][POS.y+1].type) || (type == GEM[POS.x-1][POS.y+1].type) (type == GEM[POS.x][POS.y+2].type)
					r = true;
				
			}else if (type == GEM[POS.x][POS.y-1].type){
				if (type == GEM[POS.x+1][POS.y-1].type) || (type == GEM[POS.x-1][POS.y-1].type) (type == GEM[POS.x][POS.y-2].type)
					r = true;
				
			}
			return r;
		}
		
		void movier{//двигатель
			//bool result;
			DO MOVE
			if (tryDestroy(NEW_POSITION, type))
				desroyer(NEW_POSITION, type);
			else 
				UNDO MOVE
			
			
			
			//return result;
		}
		
		desroyer(POS, type){
			
			POS pose;
			//recursion с запоминанием всех уже задействованных эл-тов через pose
			if (type == GEM[POS.x-1][POS.y].type) && (pool[POS.x-1][POS.y] != 1){
					GEM[POS.x-1][POS.y].Destr;
					pool[POS.x-1][POS.y] = 1;
					pose.x = POS.x-1;
					pose.x = POS.y;
					desroyer(pose, type);
			}
			else if (type == GEM[POS.x+1][POS.y].type) && (pool[POS.x+1][POS.y] != 1){
					GEM[POS.x+1][POS.y].Destr;
					pool[POS.x+1][POS.y] = 1;
					pose.x = POS.x+1;
					pose.x = POS.y;
					desroyer(pose, type);
			
			}
			else if (type == GEM[POS.x][POS.y+1].type) && (pool[POS.x][POS.y+1] != 1){
					GEM[POS.x][POS.y+1].Destr;
					pool[POS.x][POS.y+1] = 1;
					pose.x = POS.x;
					pose.x = POS.y+1;
					desroyer(pose, type);
			
			}
			else if (type == GEM[POS.x][POS.y-1].type) && (pool[POS.x][POS.y-1] != 1){
					GEM[POS.x][POS.y-1].Destr;
					pool[POS.x][POS.y-1] = 1;
					pose.x = POS.x;
					pose.x = POS.y-1;
					desroyer(pose, type);
			
			}
			
				
		}
		
		
	}
}