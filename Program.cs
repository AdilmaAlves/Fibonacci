int a = 1, b = 1, c = 1;  
    Console.Write("{0} {1}", a,b);  
    for (int i = 2; i < 20; i++)  
    {  
        c= a + b;  
        Console.Write(" {0}", c);  
        a= b;  
        b= c;  
    }  