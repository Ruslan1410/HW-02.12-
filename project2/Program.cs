// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int [] Array (int [,] Array ){
double [] Average2dArray(int [,] array){
    int [] Array = new int [array.GetLength(0)];
    for(int i = 0; i<array.GetLength(0); i++){
        int count = 0;
        for(int j = 0; j<array.GetLength(1); j++){
            count+=array[i,j];
        }
        Array[i] = count/array.GetLength(0);
    }
    return Array;
}
}
