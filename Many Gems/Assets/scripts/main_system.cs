using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_system : MonoBehaviour {//класс, отвечающий за проведение игры

	// Use this for initialization
	void Start () {
		Initialization();
		
	}
	
	// Update is called once per frame
	void Update () {
		everyTime loop listener
	}	
		
		
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
				
			}else if (type == GEM[POS.x+1][POS.y-1].type){
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
			//recursion с запоминанием всех уже задействованных эл-тов
		}
		
	}
}
}
