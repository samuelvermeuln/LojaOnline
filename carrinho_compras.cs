using System;
using System.Collections.Generic;

class CarrinhoDeCompras {
  string Produto;
  double Valor;
  int Codigo, Quantidade;
  
  public CarrinhoDeCompras (string Pro, double Val, int Cod, int Quan){
    Produto = Pro;
    Valor = Val;
    Codigo = Cod;
    Quantidade = Quan;
  }
  
  public string getProduto() {
    return Produto;
  }
  public double getValor() {
    return Valor;
  }
  public int getCodigo() {
    return Codigo;
  }
  public int getQuantidade() {
    return Quantidade;
  }
  

  
}