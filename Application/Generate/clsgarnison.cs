using System;
using System.Collections.Generic;

 namespace  GestionPaie 
{
  public class   clsgarnison 
{
  //***Les variables globales***
 private int   id ;
 private string   designation ;
  //***Listes***
  public List<clsgarnison> listes(){
 return clsMetier.GetInstance().getAllClsgarnison();
}
 public  List<clsgarnison>   listes(string criteria){
 return clsMetier.GetInstance().getAllClsgarnison(criteria);
 }
 public  int  inserts(){
 return clsMetier.GetInstance().insertClsgarnison(this);
 }
 public  int  update(clsgarnison varscls){
 return clsMetier.GetInstance().updateClsgarnison(varscls);
 }
 public  int  delete(clsgarnison varscls){
 return clsMetier.GetInstance().deleteClsgarnison(varscls);
 }
  //***Le constructeur par defaut***
  public    clsgarnison() 
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
