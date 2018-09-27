using System;
using System.Collections.Generic;

 namespace  GestionPaie 
{
  public class   clsunite 
{
  //***Les variables globales***
 private int   id ;
 private string   designation ;
  //***Listes***
  public List<clsunite> listes(){
 return clsMetier.GetInstance().getAllClsunite();
}
 public  List<clsunite>   listes(string criteria){
 return clsMetier.GetInstance().getAllClsunite(criteria);
 }
 public  int  inserts(){
 return clsMetier.GetInstance().insertClsunite(this);
 }
 public  int  update(clsunite varscls){
 return clsMetier.GetInstance().updateClsunite(varscls);
 }
 public  int  delete(clsunite varscls){
 return clsMetier.GetInstance().deleteClsunite(varscls);
 }
  //***Le constructeur par defaut***
  public    clsunite() 
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
