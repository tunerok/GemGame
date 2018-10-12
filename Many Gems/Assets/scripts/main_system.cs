using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_system : MonoBehaviour {//класс, отвечающий за проведение игры



	// Use this for initialization
	void Start () {
		draw_init();
	}
	
	// Update is called once per frame
	void Update () {
		everyTime loop movier
	}	
		
		
		bool after_change_slover(){ //
			for (all){
			if (tryDestroy(POS, type))
				desroyer(POS, type);
			}
			bool t;
			return t;
			
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
		
		void movier(){//двигатель//слушатель перемещений мышки/пальца
			//bool result;
			drawer()
			if (touch){
				mem position
				mem on relase position
				type = GEM.position.type;
			
			DO MOVE//anim
			if (tryDestroy(NEW_POSITION, type))
				desroyer(NEW_POSITION, type);
			else 
				UNDO MOVE//anim
			}
			
			
			
			//return result;
		}
		
		void drawer(){ //отрисовщик
			for (all){
				if (check_empty){ 
					GEM[POS][POS] = new Gem(lvl, width, inverted)//спавним объект с его хар-ками.
					if(GEM[POS][POS].SPAWN(POS))// в спаунере добавить, что тип гема меняется только при окончании его перемещения(падения)
					{
						continue;
					}
				}
			}
		}
		
		void desroyer(POS, type){
			
			change(pos.type = z);
			//recursion с запоминанием всех уже задействованных эл-тов
			if (type == GEM[POS.x-1][POS.y].type){
				GEM.POS.dest_ani();
				desroyer(GEM[POS.x-1][POS.y], type);
			}
			else if (type == GEM[POS.x+1][POS.y].type){
				GEM.POS.dest_ani();
				desroyer(GEM[POS.x+1][POS.y], type);
			}
			else if (type == GEM[POS.x][POS.y+1].type){
				GEM.POS.dest_ani();
				desroyer(GEM[POS.x][POS.y+1], type);
			}
			else if (type == GEM[POS.x][POS.y-1].type){
				GEM.POS.dest_ani();
				desroyer(GEM[POS.x][POS.y-1], type);
			}
			
			drawer();
		}
		
		//запилить дест систем с замещением 
		
	}
}
}
