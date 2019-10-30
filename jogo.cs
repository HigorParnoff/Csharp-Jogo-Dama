using System;
using System.Collections.Generic;

class Jogo{
  private int tempo;
  private bool turnoDeQuem; // false se Jog1 e True se Jog2
  private Jogador jog1;
  private Jogador jog2;
  private Tabuleiro tabJogo = new Tabuleiro();
  private List<Pecas> pecJog1 = new List<Pecas>();
  private List<Pecas> pecJog2 = new List<Pecas>();

  public Jogo(string j1="Aluno", string j2="Robô", bool tDQ=false){
    jog1 = new Jogador(j1);
    jog2 = new Jogador(j2);
    turnoDeQuem = tDQ;
    tabJogo.Init();
  }


  public void init(){ // Jogo vai rolar aqui até o fim

  }


  // SETS
  public bool setTabJogo(){ // Retorna se foi alterado
    if(true){
      return true;
    }
    return false;
  }
  //GETS
  public Tabuleiro getTabJogo(){
    return tabJogo;
  }
}

