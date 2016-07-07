#include <stdio.h>
int main(void){
	char *s=NULL;
	int a=22;
	sprintf(s,"hi my name is ayan and i have %d years old :S",a);
	printf("s=|%s|\n",s);
	return 0;
}
