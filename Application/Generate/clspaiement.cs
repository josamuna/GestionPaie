using System;
using System.Collections.Generic;

 namespace  GestionPaie 
{
  public class   clspaiement 
{
  //***Les variables globales***
 private int   id ;
 private int?  id_militaire ;
 private int?  id_periode ;
 private string   typepaiement ;
 private double?  montant ;
 private int?  nombrejour ;
 private DateTime?  datetimepaiement ;
  //***Listes***
  public List<clspaiement> listes(){
 return clsMetier.GetInstance().getAllClspaiement();
}
 public  List<clspaiement>   listes(string criteria){
 return clsMetier.GetInstance().getAllClspaiement(criteria);
 }
 public  int  inserts(){
 return clsMetier.GetInstance().insertClspaiement(this);
 }
 public  int  update(clspaiement varscls){
 return clsMetier.GetInstance().updateClspaiement(varscls);
 }
 public  int  delete(clspaiement varscls){
 return clsMetier.GetInstance().deleteClspaiement(varscls);
 }
  //***Le constructeur par defaut***
  public    clspaiement() 
{
}

  //***Accesseur de id***
 public  int   Id {

get { return id; } 
set { id = value; }
}
  //***Accesseur de id_militaire***
 public  int ?   Id_militaire {

get { return id_militaire; } 
set { id_militaire = value; }
}
  //***Accesseur de id_periode***
 public  int ?   Id_periode {

get { return id_periode; } 
set { id_periode = value; }
}
  //***Accesseur de typepaiement***
 public  string   Typepaiement {

get { return typepaiement; } 
set { typepaiement = value; }
}
  //***Accesseur de montant***
 public  double ?   Montant {

get { return montant; } 
set { montant = value; }
}
  //***Accesseur de nombrejour***
 public  int ?   Nombrejour {

get { return nombrejour; } 
set { nombrejour = value; }
}
  //***Accesseur de datetimepaiement***
 public  DateTime ?   Datetimepaiement {

get { return datetimepaiement; } 
set { datetimepaiement = value; }
}

} //***fin class

} //***fin namespace
