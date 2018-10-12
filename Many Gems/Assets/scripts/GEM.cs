using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GEM : MonoBehaviour {
		
		Image Im;
		int score;
		int ability;
		int type;
		
	GEM(int lvl, int width, bool inverted){
		
		switch (rand)
		{
			case 1:
				type = 1;
				folder = "br";
					if (inverted)
						temp = ранд(от 8 до целое_но_меньше_12(9 + лвл/10))
					else
						temp = ранд(от 1 до целое_но_меньше_8(1 + лвл/10))
				type = type + temp;
			case 2:
				type = 13;
				folder = "ge";
				
			case 3:
				type = 23;
				folder = "ro";
			case 4:	
				type = 35;
				folder = "te";
			default:
		}
		
		void dest_anim(){
			play_distroy_animation();
			this.Delete();
		}
		
		bool spawn(int pose_x, int pose_y){
			move(from y_max,pose_x to pose_y,pose_x);
			return true;
			
		}
		
	}
	
}
