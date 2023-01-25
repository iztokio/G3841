string? inputNum = Console.ReadLine();
if(inputNum!=null)
{
    int number = int.Parse(inputNum);
    int count = 1;
    while(count < number + 1)
    {
        if(count % 2 == 0)
        {
            Console.Write(count + ", ");
        }
        count = count + 1;
    }
    
}