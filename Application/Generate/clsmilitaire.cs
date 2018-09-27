using System;
using System.Collections.Generic;

 namespace  GestionPaie 
{
  public class   clsmilitaire 
{
  //***Les variables globales***
 private int   id ;
 private int?  id_cotitulairecompte ;
 private int?  id_province ;
 private int?  id_unite ;
 private int?  id_garnison ;
 private int?  id_implatation ;
 private int?  id_grade ;
 private int?  numeroidentifiantunique ;
 private int?  matricule ;
 private string   nom ;
 private string   postnom ;
 private string   prenom ;
 private string   sexe ;
 private string   etatcivil ;
 private DateTime?  datenaissance ;
 private string   lieunaissance ;
 private string   nomprenompere ;
 private string   nomprenommere ;
 private string   modeidentification ;
 private string   numeropieceidentite ;
 private DateTime?  detelivresonpieceidentite ;
 private string   nomemploiyer ;
 private string   addresseemploiyer ;
 private string   telbureau ;
 private string   adressepostal ;
 private string   ville ;
 private string   pays ;
 private string   nationalite ;
 private string   nomconjoin ;
 private string   email ;
 private string   tel ;
 private string   fax ;
  //***Listes***
  public List<clsmilitaire> listes(){
 return clsMetier.GetInstance().getAllClsmilitaire();
}
 public  List<clsmilitaire>   listes(string criteria){
 return clsMetier.GetInstance().getAllClsmilitaire(criteria);
 }
 public  int  inserts(){
 return clsMetier.GetInstance().insertClsmilitaire(this);
 }
 public  int  update(clsmilitaire varscls){
 return clsMetier.GetInstance().updateClsmilitaire(varscls);
 }
 public  int  delete(clsmilitaire varscls){
 return clsMetier.GetInstance().deleteClsmilitaire(varscls);
 }
  //***Le constructeur par defaut***
  public    clsmilitaire() 
{
}

  //***Accesseur de id***
 public  int   Id {

get { return id; } 
set { id = value; }
}
  //***Accesseur de id_cotitulairecompte***
 public  int ?   Id_cotitulairecompte {

get { return id_cotitulairecompte; } 
set { id_cotitulairecompte = value; }
}
  //***Accesseur de id_province***
 public  int ?   Id_province {

get { return id_province; } 
set { id_province = value; }
}
  //***Accesseur de id_unite***
 public  int ?   Id_unite {

get { return id_unite; } 
set { id_unite = value; }
}
  //***Accesseur de id_garnison***
 public  int ?   Id_garnison {

get { return id_garnison; } 
set { id_garnison = value; }
}
  //***Accesseur de id_implatation***
 public  int ?   Id_implatation {

get { return id_implatation; } 
set { id_implatation = value; }
}
  //***Accesseur de id_grade***
 public  int ?   Id_grade {

get { return id_grade; } 
set { id_grade = value; }
}
  //***Accesseur de numeroidentifiantunique***
 public  int ?   Numeroidentifiantunique {

get { return numeroidentifiantunique; } 
set { numeroidentifiantunique = value; }
}
  //***Accesseur de matricule***
 public  int ?   Matricule {

get { return matricule; } 
set { matricule = value; }
}
  //***Accesseur de nom***
 public  string   Nom {

get { return nom; } 
set { nom = value; }
}
  //***Accesseur de postnom***
 public  string   Postnom {

get { return postnom; } 
set { postnom = value; }
}
  //***Accesseur de prenom***
 public  string   Prenom {

get { return prenom; } 
set { prenom = value; }
}
  //***Accesseur de sexe***
 public  string   Sexe {

get { return sexe; } 
set { sexe = value; }
}
  //***Accesseur de etatcivil***
 public  string   Etatcivil {

get { return etatcivil; } 
set { etatcivil = value; }
}
  //***Accesseur de datenaissance***
 public  DateTime ?   Datenaissance {

get { return datenaissance; } 
set { datenaissance = value; }
}
  //***Accesseur de lieunaissance***
 public  string   Lieunaissance {

get { return lieunaissance; } 
set { lieunaissance = value; }
}
  //***Accesseur de nomprenompere***
 public  string   Nomprenompere {

get { return nomprenompere; } 
set { nomprenompere = value; }
}
  //***Accesseur de nomprenommere***
 public  string   Nomprenommere {

get { return nomprenommere; } 
set { nomprenommere = value; }
}
  //***Accesseur de modeidentification***
 public  string   Modeidentification {

get { return modeidentification; } 
set { modeidentification = value; }
}
  //***Accesseur de numeropieceidentite***
 public  string   Numeropieceidentite {

get { return numeropieceidentite; } 
set { numeropieceidentite = value; }
}
  //***Accesseur de detelivresonpieceidentite***
 public  DateTime ?   Detelivresonpieceidentite {

get { return detelivresonpieceidentite; } 
set { detelivresonpieceidentite = value; }
}
  //***Accesseur de nomemploiyer***
 public  string   Nomemploiyer {

get { return nomemploiyer; } 
set { nomemploiyer = value; }
}
  //***Accesseur de addresseemploiyer***
 public  string   Addresseemploiyer {

get { return addresseemploiyer; } 
set { addresseemploiyer = value; }
}
  //***Accesseur de telbureau***
 public  string   Telbureau {

get { return telbureau; } 
set { telbureau = value; }
}
  //***Accesseur de adressepostal***
 public  string   Adressepostal {

get { return adressepostal; } 
set { adressepostal = value; }
}
  //***Accesseur de ville***
 public  string   Ville {

get { return ville; } 
set { ville = value; }
}
  //***Accesseur de pays***
 public  string   Pays {

get { return pays; } 
set { pays = value; }
}
  //***Accesseur de nationalite***
 public  string   Nationalite {

get { return nationalite; } 
set { nationalite = value; }
}
  //***Accesseur de nomconjoin***
 public  string   Nomconjoin {

get { return nomconjoin; } 
set { nomconjoin = value; }
}
  //***Accesseur de email***
 public  string   Email {

get { return email; } 
set { email = value; }
}
  //***Accesseur de tel***
 public  string   Tel {

get { return tel; } 
set { tel = value; }
}
  //***Accesseur de fax***
 public  string   Fax {

get { return fax; } 
set { fax = value; }
}

} //***fin class

} //***fin namespace
