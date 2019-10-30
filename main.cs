using System;
using System.Collections.Generic;


class MainClass {
  public static void Main (string[] args) {
    char[] tabuleiro = new char[64];
    for(int i=0; i<64; i++){
      if(i%2 == 0){
        tabuleiro[i] = 'B';
      }else{
        tabuleiro[i] = 'P';
      }
    }
    for(int i=0; i<64; i++){
      if(i%8 == 0){
        Console.WriteLine("");
      }
      Console.Write("{0}", tabuleiro[i]);
    }
  }
}