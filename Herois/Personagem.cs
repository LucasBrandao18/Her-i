using System;

class Personagem : Superpoder
{
  //varieveis
  private string nomeSuper, nomeReal;
  private int[] poderes = new int[4];

  //getset
  public string NS
  {
      get { return nomeSuper; }
      set { nomeSuper = value; }
  }
  public string NIRL
  {
    get { return nomeReal; }
    set { nomeReal = value; }
  }
  public int[] Powers
  {
    get { return poderes; }
    set { poderes = value; }
  }

  //construtor
  public Personagem(string nomeSuper, string nomeReal, int[] poderes) : base(nomeSuper, 0)
  {
    NS = nomeSuper;
    NIRL = nomeReal;
    Powers = poderes;
  }

  //metodos
  public void adicionarPoder(int poderes)
    {
      int a, b = 0;
      Console.WriteLine("Adicione ate 4 poderes./n digite '1' = adicionar poder./n '2' = finalizar processo");
      for (a = 0; a < 4; a++)
      {
      if (a < 4 || b == 1)
      {
        Powers[a] = 10;
        Console.WriteLine("{0} adicionado", this.Powers[a]);
      }else if (b==2)
      {
        Console.WriteLine("poderes adicionados");
        break;
      }else{
        Console.WriteLine("Limite de poderes atingido");
      }
      }
    }

  public virtual int getPoderTotal(int poderes){
    int PT = Powers[1]+Powers[2]+Powers[3]+Powers[4];
    return PT;
  }

}
