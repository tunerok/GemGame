using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;
using System.IO;


public class GEM : MonoBehaviour {
		
		Image Im;
		int score;
		int ability;
		int type;
		string pathtofolder;

	GEM(int lvl, int width, bool inverted){
		
		switch (Math.Round(Random.Range(1.0f,4.0f))
		{
			case 1:
				type = 1;
				pathtofolder+ = "br";
					//if (inverted)
					//	temp = ранд(от 8 до целое_но_меньше_12(9 + лвл/10))
					//else
					//	temp = ранд(от 1 до целое_но_меньше_8(1 + лвл/10))
				//type = type + temp;
				break;
			case 2:
				type = 13;
				pathtofolder+ = "ge";
				break;
			case 3:
				type = 23;
				pathtofolder+ = "ro";
				break;
			case 4:	
				type = 35;
				pathtofolder+ = "te";
				break;
			default:
			break;
		}



	}
		
		void dest_anim(){
			//play_distroy_animation();
			this.Delete();
		}
		
		bool spawn(int pose_x, int pose_y){
			move(int pose_x, int pose_y);
			return true;
			
		}
		
}
