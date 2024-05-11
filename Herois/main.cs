using System;

class Jogo : Personagem
{
    public Jogo(string nomeSuper, string nomeReal, int[] poderes) : base(nomeSuper, nomeReal, poderes)
    {
        // Constructor body goes here if needed
    }
    public static void Main(string[] args)
    {
        Superheroi superheroi = new Superheroi("Superman", "Clark Kent", new int[] { 0, 0, 0, 0 });

        Vilao vilao = new Vilao("Joker", "Arthur Fleck", new int[] { 0, 0, 0, 0 });

        Confronto confronto = new Confronto();
        superheroi.adicionarPoder();
        vilao.adicionarPoder();
        superheroi.getPoderTotal();
        vilao.getPoderTotal();
        confronto.confronto();
    }
}