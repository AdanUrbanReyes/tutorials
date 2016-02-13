#include <stdio.h>
#include <stdlib.h>
unsigned char *r;
void initR(){
	r=(unsigned char *)malloc(sizeof(unsigned char)*4);
	*r=1;
	*(r+1)=3;
	*(r+2)=7;
	*(r+3)=11;
}
void printR(unsigned char r){
	printf("r[%hd]=%hd\n",r,r[r]);
}
int main(void){
	initR();
	printR(0);
	printR(3);
	printR(1);
	printR(2);
	return 0;
}
