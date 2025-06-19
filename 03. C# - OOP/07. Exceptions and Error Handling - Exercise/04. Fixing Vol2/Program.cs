try
{
    int firstNumber, secondNumber;
    int result = 2;
    
    firstNumber = 30;
    secondNumber = 60;
    result = Convert.ToInt32(firstNumber * secondNumber);
    Console.WriteLine($"{firstNumber} x {secondNumber} = {result}");
    Console.ReadLine();
}
catch (OverflowException e)
{
    Console.WriteLine(e.Message);
}