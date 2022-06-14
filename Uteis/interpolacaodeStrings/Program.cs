namespace interpolacaodeStrings
{
  public class Pogram
  {
    public static void Main(String[] args)
    {

      float price = 10.2f;

      Console.WriteLine($"O preço do produto é: {price} ");
      Console.WriteLine("O preço do produto é: {0} ", price);
      Console.WriteLine($@"O preço do produto 
                        é: {price} ");
      Console.WriteLine($"O preço do produto \n é: {price} ");


    }
  }

}
