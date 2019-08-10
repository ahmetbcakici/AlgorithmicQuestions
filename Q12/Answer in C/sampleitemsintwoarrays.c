#include<stdio.h>
#include<conio.h>
int main(){
    char characters[8] = {'a','c','b','y','p','f','e','q'};
    char characters2[8] = {'a','o','c','z','t','y','g','l'};
    
    for (int i = 0; i < sizeof(characters); i++)
    {
        for (int j = 0; j < sizeof(characters2); j++)
        {
            if(characters[i] == characters2[j]) printf("%c\n",characters[i]);
        }
        
    }

    getch();
}