/*
5 / 5 - Pedro Bento e o Mundo de OZ
Desafio
No jogo, O Mundo de Oz, Pedro Bento é o líder do Tribunal, por causa disso ele é uma das pessoas mais importantes do mundo, no jogo. Além disso, Pedro Bento possui um grande tesouro, o qual possui diversos tipos de jóias.

Pedro Bento está muito curioso para saber quantos tipos de jóias diferentes seu tesouro possui.

Sabendo que você é o melhor programador do mundo, Pedro Bento te contratou para verificar quantos tipos de jóias distintas ele tem em seu tesouro.

Entrada
A entrada consiste de várias linhas e cada uma contém uma string que descreve uma das jóias de Pedro Bento. Essa string é composta apenas dos caracteres '(' e ')', a soma do tamanho de todas as string não excede 106.

Saída
Imprima quantos tipos de jóias distintas Pedro Bento possui.

 
Exemplo de Entrada	Exemplo de Saída
((
))
((
))
(
3
*/

using System;
using System.Collections.Generic;

class Program {
  
  static void Main(string[] args) {
    // Utilize Console.ReadLine para leitura do input de cada linha
    int totalLength = 0;
    var dic = new Dictionary<string, int>();
    string joia = "a";
    //while (totalLength < 50)
    for (var i = 0; i <= 4;i++)
    {
      joia = Console.ReadLine(); 
      totalLength += joia.Length;
      try
      {
        dic[joia] += 1;
      }
      catch
      {
        dic[joia] = 1;
      }
      
    }
    Console.WriteLine(dic.Count);
    // Utilize Console.WriteLine para fazer o output de cada linha
  }
}