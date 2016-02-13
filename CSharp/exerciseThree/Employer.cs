using System;
//using System.Collection.Generic;
//using System.Ling;
//using System.Text;
namespace exerciseThree{
	public class Employer{
		private string name;
		private int level;
		private int experience;
		private bool isLeader;
		public void setEployer(string name, int level,int experience,bool isLeader){
			this.name=name;
			this.level=level;
			this.experience=experience;
			this.isLeader=isLeader;
		}
		public string getName(){
			return name;
		}
		public int getLevel(){
			return level;
		}
		public int getExperience(){
			return experience;
		}
		public bool getIsLeader(){
			return isLeader;
		}
		public void setName(string name){
			this.name=name;
		}
		public void setLevel(int level){
			this.level=level;
		}
		public void setExperience(int experience){
			this.experience=experience;
		}
		public void setIsLeader(bool isLeader){
			this.isLeader=isLeader;
		}
	}
}
