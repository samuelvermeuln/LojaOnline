using System;
using System.Collections.Generic;

class CadastroCliente {
  string Nome;
  int Idade;
  string Endereço;
  double Cep;
  double Telefone;
  string Nome_rua;
  int Numero_casa;

    /*   NOME */
  public void setNome (string n){
    Nome = n;
    }
  public string getNome (){
    return Nome;
  }
    /*   Endereço */
  public void setEndereço (string e){
    Endereço = e;
    }  
  public string getEndereço (){
    return Endereço;
  }

    /*   Idade */
  public void setIdade(int i){
    Idade = i;
  }
  public int getIdade (){
    return Idade;
  }
    /*   Telefone */  
  public void setTelefone(double t){
    Telefone = t;
  }
  public double getTelefone () {
    return Telefone;
  }
    /*   Cep */
  public void setCep (double c){
    Cep = c;
  }
  public double getCep () {
    return Cep;
  }
    /*   rua */
  public string getNome_rua (){
    return Nome_rua;
  }
    /*   numero casa */
  public int getNumero_casa (){
    return Numero_casa;
  }

    /*   Construtor */
  public CadastroCliente(string n, int i, string e, double c, double t, string nr,int nc){
    Nome = n;    
    Idade = i;
    Endereço = e;
    Cep = c;
    Telefone = t;
    Nome_rua = nr;
    Numero_casa = nc;
    
  }

}

