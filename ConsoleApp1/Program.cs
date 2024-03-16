public class Average {

    public static double CalculateAverage(int[] numbers) {
        
        if(numbers == null || numbers.Length == 0)
            throw new ArgumentException("Array is empty. Provide array with numbers");

        int sum = 0;
        foreach(int num in numbers){
            sum += num;
        }    
        
        return sum/numbers.Length;
    }

    public static int FindMax(int[] numbers) {

        if(numbers == null || numbers.Length == 0)
            throw new ArgumentException("Array is empty. Provide array with numbers");

        int max = numbers[0];
        foreach(int num in numbers){
            if(num > max)
                max = num;
        }

        return max;
    }

}

class Program {
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5};
       
        double average = Average.CalculateAverage(numbers);
        int max = Average.FindMax(numbers);

        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max number is: {max}");
    }
}