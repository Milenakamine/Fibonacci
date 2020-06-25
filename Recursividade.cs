namespace Fibonacci
{
    public class Recursividade
    {
        //mapeando oq precisa para sequencia, no num1 passa 0, num2 passa o 1, e o vezes quantas vezes quiser
        public void SequenciaFibo(int num1, int num2, int vezes){
           //essencial condicao de para q é com IF
        if(vezes > 0){
            System.Console.WriteLine(num1);
        //condicional feita
        SequenciaFibo(num2, num1+num2, vezes-1 );
        }
    
        }
    //fatorial -- 5*4, 5*3, 5*2, 5*1, para quando chega no 1

    public int Fatorial(int numero){
        if(numero == 1){
            return 1;
        }else{
            return numero * Fatorial(numero -1);
        }
    }
    
    
    
    }
}