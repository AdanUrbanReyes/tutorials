#include <stdio.h>
#include <stdlib.h>
#include <string.h>
typedef union Data{
	int integer;
	double decimal;
	char *string;
}Data;
typedef struct Lexema{
	Data value;
	char *token;
}Lexema;
Lexema *recognizedLexema(char *token,Data value){
	Lexema *lexema=(Lexema *)malloc(sizeof(Lexema));
	lexema->value=value;
	lexema->token=strdup(token);
	return lexema;
}
int main(int ari,char **arc){
	Lexema *lexema;
	char *token=(char *)malloc(sizeof(char)*10);
	//strcpy(token,"INTEGER");
	//strcpy(token,"DOUBLE");
	strcpy(token,"STRING");
	//lexema=recognizedLexema(token,(Data)atoi("150"));
	//lexema=recognizedLexema(token,(Data)atof("11.7264"));
	lexema=recognizedLexema(token,(Data)"hola como estas");
//	printf("lexema->value.integer=%d\n",lexema->value.integer);
	//printf("lexema->value.decimal=%f\n",lexema->value.decimal);
	printf("lexema->value.string=%s\n",lexema->value.string);
	printf("lexema->token=%s\n",lexema->token);
	strcpy(token,"STRING");
	printf("lexema->token=%s\n",lexema->token);
	
//	printf("lexema.floating=%f\n",lexema.decimal);
//	printf("lexema.string=%s\n",lexema.string);
	return 0;
}
