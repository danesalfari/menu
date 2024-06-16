public class funcion
{
    //variables globales
    static int res=0;
    static void Main(string[] args)
    {
        int n1=0, n2=0, res=0;
        Console.WriteLine("Ingrese el primer numero: ");
        n1= int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        n2= int.Parse(Console.ReadLine());
        res=sumar1(n1,n2);
        Console.WriteLine("El total es: " + res);
    }
    static int sumar(int n1, int n2)
    {
        int total=0;
        total= n1+n2;
        return total;
    }
    
    static int sumar1(int n1, int n2)
    {
        return n1+n2;
    }

}