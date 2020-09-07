using System;
class Carro 
{
  public string modelo;
  public string cor;
  public string ano;
  public void Lista(string modelo, string cor, string ano)
  {
    Console.WriteLine("\n Carro cadastrado: {0} {1} {2}\n", modelo,cor,ano);
  }
}