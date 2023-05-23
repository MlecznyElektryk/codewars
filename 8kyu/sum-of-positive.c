#include <stdio.h>
/*You get an array of numbers, return the sum of all of the positives ones.
Example [1,-4,7,12] => 1 + 7 + 12 = 20
Note: if there is nothing to sum, the sum is default to 0.*/
int positive_sum(const int *values, size_t count){

    int i;
    
    if(count == 0) return 0;
    else{

        int sum = 0;
        
        for(i=0; i<count; i++){
            if(values[i] > 0) sum += values[i];
        }
        return sum;
    }
}

int main(){
    
    int values[5] = {1, 1, 1, 1, 1,};
    int count = sizeof(values) / sizeof(values[0]);
    
    printf("The sum of given positives is equal to %d", positive_sum(values, count));

    return 0;
}