using System;
using AbstraindoJogoRPG.scr.Entities;

namespace AbstraindoJogoRPG
{
  class Program
  {
    static void Main(string[] args)
    {
      BobEsponja bobEsponja = new BobEsponja("Bob Esponja", "média" , "rede", "alta");
      Patrick patrick = new Patrick("Patrick", "baixa" , "rede", "média");
      Plankton plankton = new Plankton("Plankton", "alta" , "pistola lança rede", "baixa");
      Sandy sandy = new Sandy("Sandy", "alta" , "rede", "alta");

      System.Console.WriteLine(bobEsponja.Attack(4));
      System.Console.WriteLine(patrick.Attack(5));
      System.Console.WriteLine(bobEsponja.Attack(1));
      System.Console.WriteLine(patrick.Attack(2));
      System.Console.WriteLine(plankton.Attack(6));
      System.Console.WriteLine(plankton.Attack(3));
      System.Console.WriteLine(sandy.Attack(3));
      System.Console.WriteLine(sandy.Attack(1));
    }
  }
}

