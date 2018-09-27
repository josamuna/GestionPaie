using System;
using System.Collections.Generic;

 namespace  GestionPaie 
{
  public class   clsperiode 
{
  //***Les variables globales***
 private int   id ;
 private string   moisperiode ;
 private int?  anneeperiode ;
  //***Listes***
  public List<clsperiode> listes(){
 return clsMetier.GetInstance().getAllClsperiode();
}
 public  List<clsperiode>   listes(string criteria){
 return clsMetier.GetInstance().getAllClsperiode(criteria);
 }
 public  int  inserts(){
 return clsMetier.GetInstance().insertClsperiode(this);
 }
 public  int  update(clsperiode varscls){
 return clsMetier.GetInstance().updateClsperiode(varscls);
 }
 public  int  delete(clsperiode varscls){
 return clsMetier.GetInstance().deleteClsperiode(varscls);
 }
  //***Le constructeur par defaut***
  public    clsperiode() 
{
}

  //***Accesseur de id***
 public  int   Id {

get { return id; } 
set { id = value; }
}
  //***Accesseur de moisperiode***
 public  string   Moisperiode {

get { return moisperiode; } 
set { moisperiode = value; }
}
  //***Accesseur de anneeperiode***
 public  int ?   Anneeperiode {

get { return anneeperiode; } 
set { anneeperiode = value; }
}

} //***fin class

} //***fin namespace
