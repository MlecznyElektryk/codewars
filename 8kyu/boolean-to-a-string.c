
//The returned string should be statically allocated and it won't be freed

#include <stdio.h>
#include <stdbool.h>

const char *boolean_to_string(bool b)
{
    if (b == true) return "true";
    else return "false";
}

int main(){
    bool b = 0;
    printf("%s", boolean_to_string(b));
    return 0;
}