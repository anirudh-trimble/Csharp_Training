internal class Program
{
    private static void Main(string[] args)
    {
        string strNum = "123";
        // using parse method
        int intNum = int.Parse(strNum);
        Console.WriteLine($"Using parse method: String \'{intNum}\' to int {intNum}");

        double doubleNum = 123.456;
        // explicit type cast
        intNum = (int)doubleNum;
        Console.WriteLine($"Using explicit cast: Double {doubleNum} to int {intNum}");

        strNum = "456";
        // using Convert class
        intNum = Convert.ToInt32(strNum);
        Console.WriteLine($"Using Convert.ToInt32: String \'{strNum}\' to int {intNum}");

        // using TryParse method
        strNum = "789";
        bool success = int.TryParse(strNum, out intNum);
        if (success)
        {
            Console.WriteLine($"Using TryParse: String \'{strNum}\' to int {intNum}");
        }
        else
        {
            Console.WriteLine($"Failed to convert string \'{strNum}\' to int.");
        }
    }
}