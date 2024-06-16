public class Menu
{
    static void Main(string[] args)
    {
        menu();
    }

    static void menu()
    {
        Console.Clear();
        int op=0;
        Console.WriteLine("---MENU DE OPCIONES---");
        Console.WriteLine();
        Console.WriteLine("1. Programación Secuencial");
        Console.WriteLine("2. Condicionales");
        Console.WriteLine("3. Ciclos");
        Console.WriteLine("4. Arreglos");
        Console.WriteLine("5. Salir");
        Console.WriteLine();
        Console.WriteLine("Selecione una opcion (1..5)");
        op= int.Parse(Console.ReadLine());
        switch(op)
        {
            case 1:
            {
                Secuencial();
                break;
            }
            case 2:
            {
                Condicional();
                break;
            }
            case 3:
            {
                Ciclos();
                break;
            }
            case 4:
            {
                Arreglos();
                break;
            }
            case 5:
            {
                Salir();
                break;
            }
            default:
            {
                Console.WriteLine("Por favor seleccione una opción valida...");
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                menu();
                break;
            }
        }

    }

    static void Salir()
    {
        Console.WriteLine("Saliendo....");
    }

    static void Secuencial()
    {
        int op=0;
        Console.Clear();
        Console.WriteLine("---Programación secuencial---");
        Console.WriteLine();
        Console.WriteLine("1. Invertir numero de dos digitos");
        Console.WriteLine("2. Invertir numero de tres digitos");
        Console.WriteLine("3. Invertir numero de cuatro digitos");
        Console.WriteLine("4. Convertir dolares a pesos y euros");
        Console.WriteLine("5. Regresar");
        Console.WriteLine();
        Console.WriteLine("Selecione una opcion (1..5)");
        op= int.Parse(Console.ReadLine());
        switch(op)
        {
            case 1:
            {
                InvertirDosDigitos();
                break;
            }
            case 2:
            {
                InvertirTresDigitos();
                break;
            }
            case 3:
            {
                InvertirCuatroDigitos();
                break;
            }
            case 4:
            {
                DolarPesosEuro();
                break;
            }
            case 5:
            {
                regresar();
                break;
            }
            default:
            {
                Console.WriteLine("Por favor seleccione una opción valida...");
                Console.ReadKey();
                Secuencial();
                break;
            }
        }
    }

    static void InvertirDosDigitos()
    {
        int num=0, uni=0,dec=0;
        Console.WriteLine("Ingrese un numero de dos digitos: ");
        num= int.Parse(Console.ReadLine());
        if(num >9 && num<100)
        {
            uni= num%10;
            dec= num/10;
            num= uni*10+dec;
            Console.WriteLine("el numero invertido es: {0}", num);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Secuencial();
        }
        else
        {
            Console.WriteLine("El numero ingresado no cumple con loc criterios...");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Secuencial();
        }
    }
    static void InvertirTresDigitos()
    {
        int num=0, uni=0,dec=0,cent=0;
        Console.WriteLine("Ingrese un numero de tres digitos: ");
        num= int.Parse(Console.ReadLine());
        if(num >99 && num<1000)
        {
            cent= num/100;
            uni= num%10;
            dec= (num%100)/10;
            num= uni*100+dec*10+cent;
            Console.WriteLine("el numero invertido es: {0}", num);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Secuencial();
        }
        else
        {
            Console.WriteLine("El numero ingresado no cumple con loc criterios...");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Secuencial();
        }
    }

    static void InvertirCuatroDigitos()
    {
        int num=0, uni=0,dec=0,cent=0,mil=0,num1=0;
        Console.WriteLine("Ingrese un numero de cuatro digitos: ");
        num= int.Parse(Console.ReadLine());
        if(num >999 && num<10000)
        {
            num1=num;
            mil=num1/1000;
            num=num%1000;
            cent= num/100;
            uni= num%10;
            dec= (num%100)/10;

            num= uni*1000+dec*100+cent*10+mil;
            Console.WriteLine("el numero invertido es: {0}", num);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Secuencial();
        }
        else
        {
            Console.WriteLine("El numero ingresado no cumple con los criterios...");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Secuencial();
        }
    }
    static void DolarPesosEuro()
    {
        double d=0, p=0, e=0;
        Console.WriteLine(" Ingrese la cantidad de dolares que quiere convertir: ");
        d = double.Parse(Console.ReadLine());
        p = d * 4852;
        e = d * 094;
        Console.WriteLine(" La cantidad de dolares que ingreso convertidos a pesos son: {0} ", p);
        Console.WriteLine(" La cantidad de dolares que ingreso convertidos a euros son: {0} ", e);
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Secuencial();
    }

    static void Condicional()
    {
        int op=0;
        Console.Clear();
        Console.WriteLine("---Programación Condicional---");
        Console.WriteLine();
        Console.WriteLine("1. Hallar edad real");
        Console.WriteLine("2. Determinar numero primo");
        Console.WriteLine("3. Convertir mayusculas a minusculas");
        Console.WriteLine("4. Ordenar tres numeros");
        Console.WriteLine("5. Regresar");
        Console.WriteLine();
        Console.WriteLine("Selecione una opcion (1..5)");
        op= int.Parse(Console.ReadLine());
        switch(op)
        {
            case 1:
            {
                edad();
                break;
            }
            case 2:
            {
                primo();
                break;
            }
            case 3:
            {
                Mayaminu();
                break;
            }
            case 4:
            {
                Organizar();
                break;
            }
            case 5:
            {
                regresar();
                break;
            }
            default:
            {
                Console.WriteLine("Por favor seleccione una opción valida...");
                Console.ReadKey();
                Condicional();
                break;
            }
        }
    }

    static void primo()
    {
        int numero=0;
        Console.WriteLine("Ingrese un valor numerico: ");
        numero= int.Parse(Console.ReadLine());
        bool primo= determinar_primo(numero);
        if(primo)
        {
            Console.WriteLine("el numero {0}, es primo", numero);
        }
        else
        {
            Console.WriteLine("el numero {0}, NO es primo", numero);
        }
        
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Condicional();
    }
    static bool determinar_primo(int num)
    {
        bool primo= true;
        int cont =0;
        for(int i=1; i<=num;i++)
        {
            if(num%i== 0)
            {
                cont++;
            }
        }

        if(cont>2)
        {
            primo= false;
        }

        return primo;
        Console.WriteLine("Presione una tecla para continuar...");  
        Console.ReadKey();
        Condicional();
    }

    static void edad()
    {
        int aActual=0, mActual=0, dActual=0, aNac=0, mNac=0, dNac=0, a=0, m=0, d=0;
        DateTime hoy= DateTime.Now; // nos entrega fecha y hora del sistema
        aActual= hoy.Year;
        mActual= hoy.Month;
        dActual=hoy.Day;
        Console.WriteLine("Ingrese su año de nacimiento: ");
        aNac= int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su mes de nacimiento: ");
        mNac= int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su dia de nacimiento: ");
        dNac= int.Parse(Console.ReadLine());
        if(aNac> aActual)
        {
            Console.WriteLine("Ingree un año de nacimiento valido");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Condicional();
        }
        else if(aNac==aActual && mNac>mActual)
        {
            Console.WriteLine("Ingree un mes de nacimiento valido");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Condicional();
        }
        else if(aNac==aActual && mNac==mActual && dNac>dActual)
        {
            Console.WriteLine("Ingree un dia de nacimiento valido");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Condicional();
        }
        else
        {
            if(dActual < dNac)
            {
                dActual +=30;
                mActual -=1;
                d= dActual-dNac; 
            }
            else
            {
                d= dActual-dNac; 
            }

            if(mActual< mNac)
            {
                mActual+=12;
                aActual-=1;
                m= mActual-mNac;
            }
            else
            {
                m= mActual-mNac;
            }   
            a= aActual-aNac;

            Console.WriteLine("Su edad real es: {0} años, {1} meses y {2} dias", a,m,d);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Condicional();
        }
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Condicional();
    }
    
    static void Mayaminu()
    {
        string letr="";
        Console.WriteLine("Ingrese una cadena de letras en mayusculas.");
        letr=Console.ReadLine();
        Console.WriteLine("En minusculas es: {0}, en mayusculas es: {1}.",letr.ToLower(),letr.ToUpper());
        Console.ReadKey();
        Condicional();
    }
    static void Organizar()
    {
        double n0=0, n1=0, n2=0;
        Console.WriteLine("Ingrese el primer numero, por favor. ");
        n0=double.Parse(Console.ReadLine());
        Console.WriteLine("Ahora ingrese el segundo numero.");
        n1=double.Parse(Console.ReadLine());
        Console.WriteLine("Por ultimo el tercer numero. ");
        n2=double.Parse(Console.ReadLine());
        if( n0>n1 && n1>n2 )
        {
            Console.WriteLine("Los numeros ordenados de menor a mayor son: {0} {1} {2}",n2,n1,n0);
            Console.WriteLine("Los numeros ordenados de mayor a menor son: {0} {1} {3}",n0,n1,n2);
        }
        if( n0>n2 && n2>n1 )
        {
            Console.WriteLine("Los numeros ordenados de menoar a mayor son: {0} {1} {2}",n1,n2,n0);
            Console.WriteLine("Los numeros ordenados de mayor a menor son: {0} {1} {2}",n0,n2,n1);
        }
        if( n1>n0 && n0>n2 )
        {
            Console.WriteLine("Los numeros ordenados de menor a mayor son: {0} {1} {2}",n1,n0,n2);
            Console.WriteLine("Los numeros ordenados de mayor a menor son: {0} {1} {2}",n2,n0,n1);
        }
        if( n1>n2 && n2>n0 )
        {
            Console.WriteLine("Los numeros ordenados de nemor a mayor son: {0} {1} {2}",n0,n2,n1);
            Console.WriteLine("Los numeros ordenados de mayor a menor son: {0} {1} {2}",n1,n2,n0);
        }
        if( n2>n0 && n0>n1 )
        {
            Console.WriteLine("Los numeros ordenados de mayor a menor son: {0} {1} {2}",n2,n0,n1);
            Console.WriteLine("Los numeros ordenados de menor a mayor son: {0} {1} {2}",n1,n0,n2);
        }
        if( n2>n1 && n1>n0 )
        {
            Console.WriteLine("Los numeros ordenados de mayor a menor son: {0} {1} {2} ",n2,n1,n0);
            Console.WriteLine("Los numeros ordenados de menor a mayor son: {0} {1} {2} ",n0,n1,n2);
        }
        if( n0==n1 && n1>n2)
        {
            Console.WriteLine("Los numeros ordenados de mayor a menor son: {0} {1} {2} ",n0,n1,n2);
            Console.WriteLine("Los numeros ordenados de menor a mayor son: {0} {1} {2} ",n2,n1,n0);
        }
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Condicional();         
    }    
    static void Ciclos()
    {
        int op=0;
        Console.Clear();
        Console.WriteLine("---Programación con ciclos---");
        Console.WriteLine();
        Console.WriteLine("1. Convertir decimal a binario");
        Console.WriteLine("2. Convertir binario a decimal");
        Console.WriteLine("3. Convertir decimal a octal");
        Console.WriteLine("4. Segmentar en factores primos");
        Console.WriteLine("5. Regresar");
        Console.WriteLine();
        Console.WriteLine("Selecione una opcion (1..5)");
        op= int.Parse(Console.ReadLine());
        switch(op)
        {
            case 1:
            {
                Decabin();
                break;
            }
            case 2:
            {
                Binadec();
                break;
            }
            case 3:
            {
                Decaocta();
                break;
            }
            case 4:
            {
                Seprimo();
                break;
            }
            case 5:
            {
                regresar();
                break;
            }
        }
    }
    static void Decabin()
    {
        int dec=0;
        int res=0;
        string bin="";

        Console.Write("Ingrese un número decimal entero: ");
        dec= int.Parse(Console.ReadLine());

        while ( dec > 0 ) 
        {
            res = dec % 2;
            bin = res + bin;
            dec /= 2;
        }
        Console.WriteLine("El numero decimal que ingreso, en binario es = {0}.",bin);
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Ciclos();  
    }
    static void Binadec()
    {
        int dec=0;
        int bas=1;
        string bin="";

        Console.WriteLine("Ingrese un numero binario.");  
        bin=Console.ReadLine();

        for( int i = bin.Length - 1; i>=0; i--)
        {
            if(bin[i] == '1')
            {
                dec+=bas;
            }
        bas*=2;
        }
        Console.WriteLine("El numero en decimal es: {0} ",dec);
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Ciclos();
    }
    static void Decaocta()
    {
        int dec = 0;
        int coci = 0;
        int res = 0;
        string oct="";

        Console.WriteLine("Ingrese un numero decimal entero: ");
        dec=int.Parse(Console.ReadLine());
        coci=dec;
        while(coci>0)
        {
            res = coci % 8;
            oct = res.ToString() + oct;
            coci /= 8;
        }
        Console.WriteLine("El numero {0} decimal que ingreso, es {1} en el sistema de numeración Octal.",dec,oct);
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Ciclos();
    }
    static void Seprimo()
    {
        int num=0;
        int fact=2;

        Console.WriteLine("Ingrese un numero entero positivo: ");
        num=int.Parse(Console.ReadLine());
        Console.WriteLine("Los factores primos de: {0} son : ",num);
        while (num>1)
        {
            if(num % fact==0)
            {
                num /= fact;
                Console.Write("|{0}|",fact);   
            }
            else
            {
                fact ++;
            }
        }
        
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Ciclos();
    }
    static void Arreglos()
    {
        int op=0;
        Console.Clear();
        Console.WriteLine("---Programación con arreglos---");
        Console.WriteLine();
        Console.WriteLine("1. Buscar mayor elemento");
        Console.WriteLine("2. Buscar menor elemento");
        Console.WriteLine("3. Ordenar arreglo");
        Console.WriteLine("4. Invertir valores");
        Console.WriteLine("5. Regresar");
        Console.WriteLine();
        Console.WriteLine("Selecione una opcion (1..5)");
        op= int.Parse(Console.ReadLine());
        switch(op)
        {
            case 1:
            {
                Bumayel();
                break;
            }
            case 2:
            {
                Bumenel();
                break;
            }
            case 3:
            {
                Ordarre();
                break;
            }
            case 4:
            {
                Inverva();
                break;
            }
            case 5:
            {
                regresar();
                break;
            }
        }
    }
    static void Bumayel()
    {
        int n=0;
        Console.WriteLine("Ingrese cuantos valores desea evaluar");
        n = int.Parse(Console.ReadLine());

        int[] aruno=new int[n];
        int max = aruno[0];
        for( int i=0; i<aruno.Length; i++ )
        {
            Console.WriteLine("Ingrese un numero entero decimal: ");
            aruno[i]=int.Parse(Console.ReadLine());
            if(aruno[i]>max)
            {
                max = aruno[i];
            } 
        }
        Console.WriteLine(" El numero mayor es {0} ",max );
        Console.WriteLine(" Presione una tecla para continuar... ");
        Console.ReadKey();
        Arreglos();
    }
    static void Bumenel()
    {
        int n=0;
        Console.WriteLine(" Ingrese cuantos valores desea evaluar: ");
        n=int.Parse(Console.ReadLine());

        int[] ardos=new int[n];
        for( int i=0; i<n; i++ )
        {
            Console.WriteLine(" Ingrese un valor: ");
            ardos[i]=int.Parse(Console.ReadLine());
        }
        int men = ardos[0];
        for( int i=0; i<n; i++)
        {
            if( ardos[i]<men )
            {
                men = ardos[i];
            }
        }    
        Console.WriteLine(" El valor minimo es: {0}",men);
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Arreglos();
    }
    static void Ordarre()
    {
        int m=0;
        Console.WriteLine("Ingrese cuantos valores desea evaluar: ");
        m=int.Parse(Console.ReadLine());

        int[] artres=new int[m];
        for(int i=0; i<m; i++)
        {
            Console.WriteLine(" Ingrese el valor numero #"+(i+1));
            artres[i]=int.Parse(Console.ReadLine());
        }
        for( int i=0; i<m; i++)
        {
            int min=i;
            for( int j=i+1; j<m; j++ )
            {
                if(artres[j]<artres[min])
                {
                    min=j;
                }
            }
            int tempo = artres[i];
            artres[i] = artres[min];
            artres[min] = tempo;
        }
        Console.WriteLine("El vector ordenado es: ");
        for(int i = 0; i < m; i++)
        {
            Console.Write(" {0} ",artres[i]);
        }
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Arreglos();
    }
    static void Inverva()
    {
        int n=0;
        Console.WriteLine("Ingrese la cantidad de valores: ");
        n=int.Parse(Console.ReadLine());

        int[] arcua=new int[n];
        for(int i=0; i<n; i++ )
        {
            Console.WriteLine("Ingrese el valor numero #"+(i+1));
            arcua[i]=int.Parse(Console.ReadLine());
        }
        int[] arcuairve=new int[n];
        for(int i=0; i<n; i++)
        {
            arcuairve[i]=arcua[arcua.Length-1-i];
        }
        Console.Write("  Vector Original:  ");
        foreach (int val in arcua)
        {
            Console.Write(" {0} ",val);
        }
        Console.Write("  Vector Invertido:  ");
        foreach(int val in arcuairve)
        {
            Console.Write("  {0}  ",val);
        }
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Arreglos();
    }
    static void regresar()
    {
        Console.Clear();
        menu();
    }
}
