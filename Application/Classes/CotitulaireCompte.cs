/***********************************************************************
 * Module:  CotitulaireCompte.cs
 * Author:  CPG SOFT
 * Purpose: Definition of the Class CotitulaireCompte
 ***********************************************************************/

using System;

public abstract class CotitulaireCompte : TitulaireCompte
{
   public new abstract void Enregistrer();
   
   public new abstract void Modifier();
   
   public abstract void Supprimer();

   private int Id;

}