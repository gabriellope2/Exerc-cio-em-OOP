using System;

class MainClass {
  public static void Main (string[] args) {
   Pessoa myperson = new Pessoa();
   
   myperson.Usuario("Jonas",20,69,1.70);
   myperson.dados();
   

   myperson.Envelhecer(20); 
   myperson.Engordar(70);
   myperson.dados();
   

   myperson.Emagrecer(65);
   myperson.Crescer(1.70);
   myperson.dados();
   


  }
}