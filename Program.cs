namespace MyApp;
class Program
{
    static void Main(string[] args)
    {
        Review review1 = new Review(4,"Buen producto");
        Review review2 = new Review(5,"Excelente");
        Review review3 = new Review(1,"Es muy grande");

        Producto Producto1= new Producto("A S Z brecker", 173);
        Producto1.Agrev(review1);
        Producto1.Agrev(review3);

        Console.WriteLine(Producto1.getInfo());
    }
}