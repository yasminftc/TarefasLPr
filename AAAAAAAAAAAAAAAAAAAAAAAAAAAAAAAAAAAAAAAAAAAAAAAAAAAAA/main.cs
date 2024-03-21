using System;
class Program {
  public static void Main (string[] args) {
    int classe;
    Console.WriteLine("Digite o número da classe desejada: ");
    Console.WriteLine(" 1 Guerreira");
    Console.WriteLine(" 2 Maga");
    Console.WriteLine(" 3 Arqueira");
    classe = int.Parse(Console.ReadLine());
    
    if(classe == 1 || classe == 2 || classe ==3){
    Console.WriteLine("suas habilidades de classe são:");
      switch (classe) 
      {
        case 1:
          Console.WriteLine("Ataque Pesado, Defesa Total");
          break;
        case 2:
          Console.WriteLine("Bola de Fogo, Escudo de Gelo");
          break;
        case 3:
          Console.WriteLine("Flecha Precisa, Disparo Triplo");
          break;
      }
    }    
    else {
    Console.WriteLine("Escolha uma classe!");
    }
  }
}