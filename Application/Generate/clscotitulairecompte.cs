using System;
using System.Collections.Generic;

 namespace  GestionPaie 
{
  public class   clscotitulairecompte 
{
  //***Les variables globales***
 private int   id ;
 private int?  id_profession ;
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
 private string   prenomconjoin ;
 private string   adressepostale ;
 private string   email ;
 private string   tel ;
 private string   fax ;
  //***Listes***
  public List<clscotitulairecompte> listes(){
 return clsMetier.GetInstance().getAllClscotitulairecompte();
}
 public  List<clscotitulairecompte>   listes(string criteria){
 return clsMetier.GetInstance().getAllClscotitulairecompte(criteria);
 }
 public  int  inserts(){
 return clsMetier.GetInstance().insertClscotitulairecompte(this);
 }
 public  int  update(clscotitulairecompte varscls){
 return clsMetier.GetInstance().updateClscotitulairecompte(varscls);
 }
 public  int  delete(clscotitulairecompte varscls){
 return clsMetier.GetInstance().deleteClscotitulairecompte(varscls);
 }
  //***Le constructeur par defaut***
  public    clscotitulairecompte() 
{
}

  //***Accesseur de id***
 public  int   Id {

get { return id; } 
set { id = value; }
}
  //***Accesseur de id_profession***
 public  int ?   Id_profession {

get { return id_profession; } 
set { id_profession = value; }
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
  //***Accesseur de prenomconjoin***
 public  string   Prenomconjoin {

get { return prenomconjoin; } 
set { prenomconjoin = value; }
}
  //***Accesseur de adressepostale***
 public  string   Adressepostale {

get { return adressepostale; } 
set { adressepostale = value; }
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
