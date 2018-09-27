using System;
using System.Collections.Generic;

 namespace  GestionPaie 
{
  public class   clsgrade 
{
  //***Les variables globales***
 private int   id ;
 private string   codegradepaie ;
 private string   designation ;
 private double?  montant ;
  //***Listes***
  public List<clsgrade> listes(){
 return clsMetier.GetInstance().getAllClsgrade();
}
 public  List<clsgrade>   listes(string criteria){
 return clsMetier.GetInstance().getAllClsgrade(criteria);
 }
 public  int  inserts(){
 return clsMetier.GetInstance().insertClsgrade(this);
 }
 public  int  update(clsgrade varscls){
 return clsMetier.GetInstance().updateClsgrade(varscls);
 }
 public  int  delete(clsgrade varscls){
 return clsMetier.GetInstance().deleteClsgrade(varscls);
 }
  //***Le constructeur par defaut***
  public    clsgrade() 
{
}

  //***Accesseur de id***
 public  int   Id {

get { return id; } 
set { id = value; }
}
  //***Accesseur de codegradepaie***
 public  string   Codegradepaie {

get { return codegradepaie; } 
set { codegradepaie = value; }
}
  //***Accesseur de designation***
 public  string   Designation {

get { return designation; } 
set { designation = value; }
}
  //***Accesseur de montant***
 public  double ?   Montant {

get { return montant; } 
set { montant = value; }
}

} //***fin class

} //***fin namespace
