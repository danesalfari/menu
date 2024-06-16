public class Potenciar
{
    static void Main (string[] args)
    {
        int n1=0;
        for(int i=0;i<10;i++)
        {
            Console.WriteLine("Ingrese un numero positivo: ");
            n1=int.Parse(Console.ReadLine());
            if(n1>0)
            {
                Console.WriteLine("Los numeros son: " + n1);
            }        
            else
            {
                Console.WriteLine("Error, le dijimos que positivo, no sea terco... Ingrese un numero valido.");
            }
        } 
    }
}
