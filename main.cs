using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string [] args) {
    string NomeCliente, EndereçoCliente, Nome_rua;
    int IdadeCliente, Numero_casa;
    double CepCliente, TelefoneCliente;
    Random randNum = new Random();
    
    Console.WriteLine ("Seja bem vindo!");
    Console.WriteLine ("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
    Console.WriteLine ("Mercearia GEEK");
    Console.WriteLine ("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
    Console.WriteLine ("AQUI ENTENDEMOS SEU LADO GEEK");
    Console.WriteLine ("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
    
    /*   Lista Cadastro Cliente*/
    CadastroCliente Cad = new CadastroCliente("Nome",21,"Endereço",29172009, 999999,"rua",1);
    List<CadastroCliente> ListaCliente = new List<CadastroCliente>();

    /* Lista carrinho de Compra */
    CarrinhoDeCompras car_comp = new  CarrinhoDeCompras ("Produto",2,3,4);
    List<CarrinhoDeCompras> Lista_carrinho = new List<CarrinhoDeCompras> ();
    
    /*   Cadastro     */
    Console.WriteLine("Digite seu Nome: ");
    NomeCliente = Console.ReadLine();
    Console.WriteLine("Digite Sua Idade: ");
    IdadeCliente = int.Parse(Console.ReadLine());        
    Console.WriteLine("Digite Seu Cep: ");
    CepCliente = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o Nome do Seu Bairro: ");
    EndereçoCliente = Console.ReadLine();
    Console.WriteLine("Digite o nome da sua rua: ");
    Nome_rua = Console.ReadLine();
    Console.WriteLine("Digite o Numero da sua casa: ");
    Numero_casa = int.Parse(Console.ReadLine());        
    Console.WriteLine("Digite Telefone para Contado: (Sem o DD).");
    TelefoneCliente = double.Parse(Console.ReadLine());
   

    Cad = new CadastroCliente (NomeCliente,IdadeCliente, EndereçoCliente, CepCliente, TelefoneCliente,Nome_rua,Numero_casa);
    ListaCliente.Add(Cad);

    Produtos pro = new Produtos ();

    for (int x = 0; x < pro.getDescricao ().Count ; x++)
    {     
     Console.WriteLine($@"
    Produto >> {pro.getDescricao ()[x]}
    Codigo do Produto >> {pro.getcod ()[x] }   
    Preço >> {pro.getPreco ()[x]} R$
    Quantidade >> {pro.getQuantidade ()[x]} UND.
    ");
    }//Termina o for    

    int pedido = 0;
    int codproduto,quantidade,ret_produto;
    double total = 0;
    double total1 = 0;
    
    Console.WriteLine($@" 
    >>  SEGUE MENU DE FÁCIL ACESSO PARA TORNAR SUA EXPERIENCIA AINDA MELHOR  << 
    ");

    while( pedido != 04 ){
      Console.WriteLine($@" 

      
       Digite A Opção Desejada:  
      
      ");
      Console.Write("\n01 - Compra \n02 - Retirada \n03 - Mostra carrinho de Compras \n04 - Finaliza carrinho \n>>");
      pedido = int.Parse(Console.ReadLine());
      //Adiciona Itens na Lista Carrinho
      if ( pedido == 01){
         Console.Write("Digite o Codigo do Produto >> ");
         codproduto = int.Parse(Console.ReadLine());
         
         
         Console.Write("Digite a Quantidade do Produto>> ");
         quantidade = int.Parse(Console.ReadLine());
         
        for (int x = 0; x < pro.getDescricao ().Count ; x++) {
          if(codproduto == pro.getcod()[x] ){
            if (quantidade <= pro.getQuantidade()[x] ) {
              car_comp = new  CarrinhoDeCompras (pro.getDescricao()[x],pro.getPreco()[x],pro.getcod()[x],quantidade);
              Lista_carrinho.Add(car_comp);
            }
            else{
              Console.WriteLine("Estoque Acima do Pedido");
            }
             
          }//Termina o if

        } // Termina o for
      }
      if ( pedido == 02 ) {
        Console.Write("Digite o Codigo do Produto a ser Retirado >> ");
        ret_produto = int.Parse(Console.ReadLine());

        for (int x = 0; x < Lista_carrinho.Count; x++){
          if (ret_produto == Lista_carrinho[x].getCodigo()){
            Lista_carrinho.RemoveAt(x);
            Console.WriteLine("Item removido com sucesso");
          }
        }
      }
      if(pedido == 03) {
        Console.WriteLine("Carrinho de Compras >> ");        
        for(int x = 0; x < Lista_carrinho.Count ; x++) {
         Console.WriteLine($@"
Codigo     >> {Lista_carrinho[x].getCodigo()}
Produto    >> {Lista_carrinho[x].getProduto()}
Quantidade >> {Lista_carrinho[x].getQuantidade()}
Preço      >> {Lista_carrinho[x].getValor()}");
         total = total + (Lista_carrinho[x].getValor() * Lista_carrinho[x].getQuantidade());
        }
         
         Console.WriteLine($"Valor Total da Compra >> R$ {total} ");
      }//Termina o if
      if( pedido == 04 ) {
        for(int x = 0; x < Lista_carrinho.Count ; x++){
          pro.getQuantidade()[x] = pro.getQuantidade()[x] - Lista_carrinho[x].getQuantidade();
          total1 = total1 + (Lista_carrinho[x].getValor() * Lista_carrinho[x].getQuantidade());
        }

        int cod_Pagamento1 = randNum.Next(0, 9);
        int cod_Pagamento2 = randNum.Next(100000, 999999);
        int cod_Pagamento3 = randNum.Next(100000, 999999);
        int cod_Pagamento4 = randNum.Next(10, 99);          

        Console.WriteLine($@"
        Obrigado {NomeCliente}. Esperamos vê-lo aqui mais uma vez, em breve!

        Valor Total da Compra >> R$ {total1} <<
        Realize o Pagamento através do Codigo de Barra abaixo!
        Código de barra >> {cod_Pagamento1} || {cod_Pagamento2} || {cod_Pagamento3} || {cod_Pagamento4} <<

        Após confirmação de pagamento o Produto será enviado para o Endereço >> CEP: {CepCliente}, RUA: {Nome_rua}, Nº: {Numero_casa}, BAIRRO: {EndereçoCliente}  
        
                                                   \\ Obrigado por Comprar na GEEK! //

        ");
        break;
      }
    }
  }
}

