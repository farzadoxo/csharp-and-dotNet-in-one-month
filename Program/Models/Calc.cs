public class Calc
{
    public int Divide(int num1,int num2)
    {
        try
        {
            return num1 / num2;
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
            return 0;
        }
        
    }

    public void Multiple(int num1,int num2 , out int tavan, out int zarb)
    {
        tavan = num1 ^ num2;
        zarb = num1 * num2;
    }

    public int BaghiMande(ref int number)
    {
        return number= number % 2;
    }

}