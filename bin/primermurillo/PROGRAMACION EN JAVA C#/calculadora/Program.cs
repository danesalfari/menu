//OPERACIONES DE DOS NUMEROS SUMA, RESTA, MULTIPLICACION Y DIVISION 
//EL MAIN NO PIDE DATOS, CREAR FUNCION QUE SOLICITE VALORES
public class calculadora
{
    static void Main(string[] args)
    {
        double res=0;
        string[] info=capturar();
        res=operar(int.Parse(info[0]),int.Parse(info[1]),info[2])
        Console.WriteLine(" {0} {1} {2} = {3} ", n1,op,n2,res);
    }
    static string[] capturar()
    {
        string[] datos= new string[3]
        Console.WriteLine("Ingrese el primer valor: ");
        n1=int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo valor: ");
        n2=int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la operacion(+,-,*,/): ");
        op= Console.ReadLine();
        return datos;
    }         
    static double operar(int n1, int n2, string op)
    {
        double res=0;
        switch(op)
        {
            case "+":
            {
                res=n1+n2;
                break;
            }
            case "-":
            {
                res=n1+n2;
                break;
            }
            case "*":
            {
                res=n1+n2;
                break;
            }
            case "/":
            {
                res=(double)n1/(double)n2;
                break;
            }
            default:
            {
                Console.WriteLine("Error, ingrese una operacion correcta (+,-,*,/)");
                break;
            }
        }
        return res;
    }
}

