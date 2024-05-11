using System;

class Vilao:Personagem{
  private int tempoPrisao;
  public int prisonTime{
    get{return tempoPrisao;}
    set{tempoPrisao=value;}
  }
  public Vilao(string nomeSuper, string nomeReal, int[] poderes) : base(nomeSuper, nomeReal, poderes)
    {
        // Constructor body goes here if needed
    }
  }
