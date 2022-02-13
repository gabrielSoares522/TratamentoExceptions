int a = 100,b = 0;
double resultado = 0;

try{
    resultado = Dividir(a,b);
    Console.WriteLine("{0} / {1} = {2}",a,b,resultado);
}
catch(DivideByZeroException ex){
    Console.WriteLine(ex.Message);
}
catch (Exception ex){
    Console.WriteLine(ex.Message);
    throw;
}
finally{
    Console.WriteLine("Divisão finalizada.");
}

static double Dividir(int x,int y){
    if(y == 0) {
        throw new DivideByZeroException();
    }
    return (x/y);
}