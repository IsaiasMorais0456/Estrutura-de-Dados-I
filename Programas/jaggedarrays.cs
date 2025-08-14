using System;

public class JaggedArrays{
    public static void Main(){
        int[][] numbers = {
            new int[] { 9, 5, -9 },
            new int[] { 0, -3, 12, 51, -3 },
            new int[] { 54 }
    };
    int number = numbers[1][2];
    numbers[1][3] = 50;

    Console.WriteLine(number);
    Console.WriteLine(numbers[1][3]);
    }
}