/*An isogram is a word that has no repeating letters, consecutive or non-consecutive.
Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.
Example: (Input --> Output)
"Dermatoglyphics" --> true "aba" --> false "moOse" --> false (ignore letter case)
*/

#include <stdio.h>
#include <stdbool.h>
#include <string.h>
#include <ctype.h>

bool IsIsogram (const char *string) 
{
  int i, j;
  int size = strlen(string);
  
  for(i = 0; i < size; i++){
    for(j = i+1; j < size; j++){
      if(toupper(string[i]) == toupper(string[j])) return false;
    }
  }
  return true;
}

int main(){

    char string[] = "a";
    printf("%d", IsIsogram(string));
    
    return 0;
}