using System;
using System.Collections.Generic;

class Jogador{
  private bool isBot;
  private string nome;
  private Tabuleiro tabJog = new Tabuleiro();
  private List<Pecas> pecasJogador = new List<Pecas>();

  public Jogador(string n, bool bot=false){
    isBot = bot;
    nome = n;
  }
  
  private int calcularJogada(){
    int jogada = 0;
    return jogada;
  }

  public bool Jogar(){
    calcularJogada();
    //tabJog.atualizar();
    return true;
  }


}
