using System;
using System.Collections.Generic;

class Pecas{
  private string tipo;
  private bool cor;
  private int[] localizacao = new int[2];

  public Pecas(int v, int h){
    tipo = "peão";
    localizacao[0] = v;
    localizacao[1] = h;
  }

  public void Inicializar(){

  }

  public void movimentar(){
    
  }
} 

  /*
  public Pecas(string c){
    tipo =c;
    switch(classe){
      default:
        tipo = "peão";
        break;
    }
  }
*/