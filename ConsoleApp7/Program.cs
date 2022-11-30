
using ConsoleApp7;

internal class Program
{
    static void Main(string[] args)
    {

        var info = new
        {
            authorName = "Antoine de Saint-Exupéry",
            pageCount = 87,
            discountPercent = 20,

        };
        var discount = new
        {
            saledPrice = 7,
            discountPercent = 20,

        };

       
        Console.WriteLine("Muellifi:"+info.authorName+"."+info.pageCount+"sehifeden ibaretdir.Black Friday heftesinde  "+info.discountPercent+"% endirimle elde ede bilersiz");

        Console.WriteLine(discount.saledPrice-discount.saledPrice*discount.discountPercent/100+"azn olacaq endirimle");
    
    }

    
}
    

     
