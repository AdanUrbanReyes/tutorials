#include <stdio.h>
int main(void){
//	unsigned char ip[2]={22,4};
	unsigned char sb[3][2]={{2,3},{6,7},{8,7}};
	unsigned char r,c;
	for(r=0;r<3;r++){
		for(c=0;c<2;c++){
			printf("sb[%hd][%hd]=%hd\n",r,c,sb[r][c]);
		}
	}
	return 0;
}
