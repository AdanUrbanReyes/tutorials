D	[0-9]
%{
	#include "sintactico.tab.h"
%}
%%
{D}*"."{D}+	{return FLOAT;}
%%

