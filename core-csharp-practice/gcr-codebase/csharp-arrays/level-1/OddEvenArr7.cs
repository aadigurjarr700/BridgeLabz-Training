using System;

class OddEvenArr7{
    static void Main() {
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if(number < 1) {
            Console.WriteLine("Error: Not a natural number");
            return;
        }

        int[] odd = new int[number/2+1];
        int[] even = new int[number/2+1];
        int oddIndex=0,evenIndex=0;

        for(int i=1;i<=number;i++){
            if(i%2 == 0){
                even[evenIndex++]=i;//stre even
            } else {
                odd[oddIndex++]=i;//stre odd
            }
        }

        Console.WriteLine("Odd numbers:");
        for(int i=0;i<oddIndex;i++){
            Console.Write(odd[i]+" ");
        }
        Console.WriteLine("\nEven numbers:");
        for(int i=0;i<evenIndex;i++){
            Console.Write(even[i]+" ");
        }
    }
}
