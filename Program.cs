using System;
using System.Collections.Generic;

class minhaClasse {
    static void Main(string[] args) {
      int qtdTeste = int.Parse(Console.ReadLine());
      var result = new Dictionary<int, string> {{0, "De novo!"},{1, "Bazinga!"}, {2, "Raj trapaceou!"}};
      var tipos = new Dictionary<string, int> {{"tesoura", 0},{"papel", 1}, {"pedra", 2}, {"lagarto", 3}, {"Spock",4}};
      int[,] escolhas =  new int[5,5] {{0,1,2,1,2}, {2,0,1,2,1}, {1,2,0,1,2}, {2,1,2,0,1}, {1,2,1,2,0}};

      for (int i = 1; i <= qtdTeste; i++)
      {

        string[] valores = Console.ReadLine().Split();
        Console.WriteLine("Caso #{0}: {1}", i, result[escolhas[tipos[valores[0]],tipos[valores[1]]]]);
      }
    }
}