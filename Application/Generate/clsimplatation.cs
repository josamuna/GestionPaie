using System;
using System.Collections.Generic;

 namespace  GestionPaie 
{
  public class   clsimplatation 
{
  //***Les variables globales***
 private int   id ;
 private string   designation ;
  //***Listes***
  public List<clsimplatation> listes(){
 return clsMetier.GetInstance().getAllClsimplatation();
}
 public  List<clsimplatation>   listes(string criteria){
 return clsMetier.GetInstance().getAllClsimplatation(criteria);
 }
 public  int  inserts(){
 return clsMetier.GetInstance().insertClsimplatation(this);
 }
 public  int  update(clsimplatation varscls){
 return clsMetier.GetInstance().updateClsimplatation(varscls);
 }
 public  int  delete(clsimplatation varscls){
 return clsMetier.GetInstance().deleteClsimplatation(varscls);
 }
  //***Le constructeur par defaut***
  public    clsimplatation() 
{
}

  //***Accesseur de id***
 public  int   Id {

get { return id; } 
set { id = value; }
}
  //***Accesseur de designation***
 public  string   Designation {

get { return designation; } 
set { designation = value; }
}

} //***fin class

} //***fin namespace
