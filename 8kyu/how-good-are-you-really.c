/*There was a test in your class and you passed it. Congratulations!
But you're an ambitious person. You want to know if you're better than the average student in your class.
You receive an array with your peers' test scores. Now calculate the average and compare your score!
Return True if you're better, else False!*/

#include <stdio.h>
#include <stdbool.h>

bool better_than_average(int class_points[], int class_size, int your_points) {

    int i;
    double average;

    for(i = 0; i < class_size; i++ ){
        average += class_points[i];
    }
    
    if ((average / class_size) < your_points) return 1;
    else return 0;
}

int main(){

    int class_points[] = {2, 2, 2, 3, 2, 2};
    int class_size = sizeof(class_points)/sizeof(class_points[0]);
    int your_points = 2;

    if (better_than_average(class_points, class_size, your_points) == 1){
        printf("Your are better than average");
    } 
    else printf("Your are not better than average ");

    return 0;
}