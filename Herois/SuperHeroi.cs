using System;

class Superheroi:Personagem{
  public Superheroi(string nomeSuper, string nomeReal, int[] poderes) : base(nomeSuper, nomeReal, poderes)
  {
      // Constructor body goes here if needed
  }
    public override int getPoderTotal(int poderes){
        int PT = (Powers[1]+Powers[2]+Powers[3]+Powers[4])*100/10;
        return PT;
      }
  }