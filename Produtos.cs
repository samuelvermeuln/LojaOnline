using System;
using System.Collections.Generic;

class Produtos {
    List<string> descricao = new List<string>{"10 COLOUR SPACEBOY PEN","SET/10 BLUE POLKADOT PARTY CANDLES","POTTING SHED SOW \'N\' GROW SET","PAPERWEIGHT KINGS CHOICE ","WOVEN BERRIES CUSHION COVER ","WHITE/PINK MINI CRYSTALS NECKLACE","SET/3 RED GINGHAM ROSE STORAGE BOX","MAGNETS PACK OF 4 VINTAGE LABELS ","WHITE CHRYSANTHEMUMS ART FLOWER","WHITE FRANGIPANI NECKLACE","SILVER FABRIC MIRROR","PINK  HONEYCOMB PAPER FAN","PINK BOUDOIR T-LIGHT HOLDER","BLACK CHERRY LIGHTS","GLASS CAKE COVER AND PLATE","DECORATION SITTING BUNNY","ANTIQUE MID BLUE FLOWER EARRINGS","VINTAGE LEAF CHOPPING BOARD  ","SNACK TRAY I LOVE LONDON","DECROTIVEVINTAGE COFFEE GRINDER BOX","IVORY ENCHANTED FOREST PLACEMAT","ANTIQUE SILVER TEA GLASS ETCHED","BLUE FELT HANGING HEART W FLOWER","PACK OF 12 COLOURED PENCILS","CLAM SHELL SMALL ","TWO DOOR CURIO CABINET","GREEN GOOSE FEATHER CHRISTMAS TREE ","MULTICOLOUR HONEYCOMB FAN","GREEN DROP EARRINGS W BEAD CLUSTER","BOTANICAL LILY GREETING CARD","SILVER DROP EARRINGS WITH FLOWER","CANDY SPOT BUNNY","WHITE WITH BLACK CATS PLATE","VEGETABLE MAGNETIC  SHOPPING LIST","FLOWER PURPLE CLOCK WITH SUCKER","VINTAGE CHRISTMAS GIFT SACK","found box","SET 10 CARDS SNOWY SNOWDROPS  17100","JUMBO SHOPPER VINTAGE RED PAISLEY","SET OF 4 ENGLISH ROSE PLACEMATS","FELTCRAFT HAIRBAND RED AND BLUE","BLUE GIANT GARDEN THERMOMETER","VINTAGE PAISLEY STATIONERY SET","SET OF 4 NAPKIN CHARMS CUTLERY","CARAVAN SQUARE TISSUE BOX","FRENCH PAISLEY CUSHION COVER ","GOLD FISHING GNOME","PINK BABY BUNTING","DROP DIAMANTE EARRINGS CRYSTAL","RED FLOCK LOVE HEART PHOTO FRAME"};
    /*
    public void setDescricao (string d){
      Descricao = d;
    }*/
    public List<string> getDescricao (){
      return descricao;
    }
    
    List<double> preco = new List<double>{10.65,9.13,0.66,175.69,15.5,206.4,194.7,3.26,2019.05,109.19,404.49,157.08,183.2,124.87,888.42,736.38,0.84,0.07,2.4,24.96,9.72,160.0,18.62,14.75,2.82,10.2,29.74,19.96,80.46,183.09,152.19,49.13,8.0,138.46,135.08,2.41,10.82,425.14,2028.25,5.13,20.38,5.76,199.33,192.44,2.62,201.84,170.92,0.0,0.87,537.83};

    public List<double> getPreco (){
      return preco;
    }

    List<int> quantidade = new List<int>{
      29,62,75,93,73,50,72,12,73,74,75,31,98,35,17,52,44,12,13,52,31,49,41,12,60,49,37,40,100,91,46,39,41,40,64,90,48,10,48,35,65,37,27,92,70,20,65,28,50,76};

      public List<int> getQuantidade (){
        return quantidade;
      }

    List<int> codigo = new List<int>{
      1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50  
    };

    public List<int> getcod (){
        return codigo;
      }

}