using System;

class Superpoder{

  //variaveis
  private string nome;
  private int categoria;

  //get/set
  public string Name{
    get{return nome;}
    set{nome = value;}
  }
  public int Cat{
    get{return categoria}
    set{categoria = value;}
  }
  public Superpoder(string nome, int categoria){
    Name = nome;
    categoria = Cat;
  }

}