using System;
class Program {
  public static void Main (string[] args) {
    int num;
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());
    
    if(num%2 == 0){
    Console.WriteLine("o número é par");
    }    
    else {
    Console.WriteLine("o número é ímpar");
    }
  }
}