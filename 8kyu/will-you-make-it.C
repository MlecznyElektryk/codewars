/*You were camping with your friends far away from home, but when it's time to go back,
you realize that your fuel is running out and the nearest pump is 50 miles away! 
You know that on average, your car runs on about 25 miles per gallon. There are 2 gallons left.
Considering these factors, write a function that tells you if it is possible to get to the pump or not.
Function should return true if it is possible and false if not.*/

#include <stdio.h>
#include <stdbool.h>

bool zero_fuel(double distance_to_pump, double mpg, double fuel_left)
{
    if((distance_to_pump / mpg) <= fuel_left) return true;
    else return false;
}

int main(){

    double distance_to_pump = 60.0;
    double mpg = 30.0;
    double fuel_left = 1;

    bool result = zero_fuel(distance_to_pump, mpg, fuel_left);

    if(result == true) printf("It is possible");
    else printf ("It is not possible");
    
    return 0;
}