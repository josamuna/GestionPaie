using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
 namespace  GestionPaie 
{
  public class   clsMetier 
{
 //***Les variables globales***
 private static string _ConnectionString, _host, _db, _user, _pwd;
 private static clsMetier Fact;
 private SqlConnection conn;
 #region prerecquis
public static clsMetier GetInstance()
{
    if (Fact == null)
        Fact = new clsMetier();
    return Fact;
 }
 private object getParameter(IDbCommand cmd, string name, DbType type, int size, object value) {
    IDbDataParameter param = cmd.CreateParameter();
   param.Size = size;
   param.DbType = type;
   param.ParameterName = name;
  param.Value = value;
   return param; 
 }
public void Initialize(string ConnectionString)
{
   _ConnectionString = ConnectionString;
   conn = new SqlConnection(ConnectionString);
}
 public void Initialize(clsConnexion con) {
    _host = con.Serveur;// host;
   _db = con.DB; ;
   _user = con.User;
   _pwd = con.Pwd;
   string sch = string.Format("server={0}; database={1}; user={2}; pwd={3}", _host, _db, _user, _pwd);
  conn = new SqlConnection(sch);
 }
public void Initialize(clsConnexion con, int type){
  _host = con.Serveur;// host;
  _db = con.DB; ;
  _user = con.User;
   _pwd = con.Pwd;
  string sch = string.Format("server={0}; database={1}; user={2}; pwd={3}", _host, _db, _user, _pwd);
 switch (type) {
    //sql server 2005
  case 1: sch = string.Format("Data Source={0};Persist Security Info=True; Initial Catalog={1};User ID={2}; Password={3}", _host, _db, _user, _pwd); break;
  //sql server 2008 Data Source=WIN7-PC\SQLEXPRESS;Initial Catalog=bihito;Persist Security Info=True;User ID=sa;Password=sa
  case 2: sch = string.Format("Data Source={0};Persist Security Info=True; Initial Catalog={1};User ID={2}; Password={3}", _host, _db, _user, _pwd); break;
  case 3: break;
}
 conn = new SqlConnection(sch);
}
public void Initialize(string host, string db, string user, string pwd){
   _host = host;
   _db = db;
   _user = user;
   _pwd = pwd;
   string sch = string.Format("server={0}; database={1}; user={2}; pwd={3}", _host, _db, _user, _pwd);
    conn = new SqlConnection(sch);
}
public void setDB(string db)
{
    _db = db;
}
public bool isConnect()
{
    bool bl = true;
    try
 {
if (conn.State != ConnectionState.Open) conn.Open();
conn.Close();
    }
catch (Exception exc)
{
bl = false;
      conn.Close();
   throw new Exception(exc.Message);
}
 return bl;
}
  public bool isConnect(clsConnexion con) {
   bool bl = true;
    _host = con.Serveur;// host;
    _db = con.DB;
    _user = con.User;
    _pwd = con.Pwd;
    string sch = string.Format("server={0}; database=Master; user={1}; pwd={2}", con.Serveur, con.User, con.Pwd);
    conn = new SqlConnection(sch);
    try
    {
        if (conn.State != ConnectionState.Open) conn.Open();
        conn.Close();
    }
    catch (Exception exc)
{
        sch = string.Format("server={0}; database={1};id user={2}; pwd={3}", _host, _db, _user, _pwd);
        bl = false;
        conn.Close();
        throw new Exception(exc.Message);
}
    return bl;
 }
public List<string> getAllDB()
{
   List<string> lst=new List<string>();
   try
{
      if (conn.State != ConnectionState.Open) conn.Open();
      using (IDbCommand cmd = conn.CreateCommand())  {
 cmd.CommandText = string.Format("SELECT name FROM sysdatabases where name!='master' order by name");
 using (IDataReader dr = cmd.ExecuteReader())
 {
  while (dr.Read())
    lst.Add(dr["name"].ToString());
         }
        conn.Close();
}
}
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
 }
  return lst;
 }
 #endregion prerecquis


#region  CLSPROVINCE
 public clsprovince getClsprovince(object intid){
 clsprovince  varclsprovince=new clsprovince();
try  {
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM province WHERE id={0}",intid);
  using (IDataReader dr = cmd.ExecuteReader())  {
 if (dr.Read()){ 

 if(!dr["id"].ToString().Trim().Equals("")) varclsprovince.Id=int.Parse(dr["id"].ToString());
varclsprovince.Designation= dr["designation"].ToString();  }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return varclsprovince;
}

 public  List<clsprovince> getAllClsprovince(string criteria){
 List<clsprovince>  lstclsprovince=new List<clsprovince>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
 string sql="SELECT *  FROM province  WHERE 1=1";
sql+="  OR   designation LIKE '%"+criteria+"%'";
  cmd.CommandText = string.Format(sql);
  using (IDataReader dr = cmd.ExecuteReader()){

 clsprovince  varclsprovince=null;
 while (dr.Read()){ 

  varclsprovince=new clsprovince();
 if(!dr["id"].ToString().Trim().Equals("")) varclsprovince.Id=int.Parse(dr["id"].ToString());
varclsprovince.Designation= dr["designation"].ToString();
lstclsprovince.Add(varclsprovince);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsprovince;
}

 public  List<clsprovince> getAllClsprovince(){
 List<clsprovince>  lstclsprovince=new List<clsprovince>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM province ");
  using (IDataReader dr = cmd.ExecuteReader()){

 clsprovince  varclsprovince=null;
 while (dr.Read()){ 

  varclsprovince=new clsprovince();
 if(!dr["id"].ToString().Trim().Equals("")) varclsprovince.Id=int.Parse(dr["id"].ToString());
varclsprovince.Designation= dr["designation"].ToString();
lstclsprovince.Add(varclsprovince);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsprovince;
}

 public int insertClsprovince(clsprovince varclsprovince){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("INSERT INTO province ( designation ) VALUES (@designation  )" );
if(varclsprovince.Designation!=null )  cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,30, varclsprovince.Designation));
else cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,30, DBNull.Value));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int updateClsprovince (clsprovince varclsprovince){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("UPDATE province  SET designation=@designation  WHERE 1=1  AND id=@id ");
if(varclsprovince.Designation!=null )  cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,30, varclsprovince.Designation));
else cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,30, DBNull.Value));
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsprovince.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int deleteClsprovince (clsprovince varclsprovince){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("DELETE FROM province  WHERE  1=1  AND id=@id ");
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsprovince.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}
 
  #endregion CLSPROVINCE 
#region  CLSUNITE
 public clsunite getClsunite(object intid){
 clsunite  varclsunite=new clsunite();
try  {
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM unite WHERE id={0}",intid);
  using (IDataReader dr = cmd.ExecuteReader())  {
 if (dr.Read()){ 

 if(!dr["id"].ToString().Trim().Equals("")) varclsunite.Id=int.Parse(dr["id"].ToString());
varclsunite.Designation= dr["designation"].ToString();  }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return varclsunite;
}

 public  List<clsunite> getAllClsunite(string criteria){
 List<clsunite>  lstclsunite=new List<clsunite>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
 string sql="SELECT *  FROM unite  WHERE 1=1";
sql+="  OR   designation LIKE '%"+criteria+"%'";
  cmd.CommandText = string.Format(sql);
  using (IDataReader dr = cmd.ExecuteReader()){

 clsunite  varclsunite=null;
 while (dr.Read()){ 

  varclsunite=new clsunite();
 if(!dr["id"].ToString().Trim().Equals("")) varclsunite.Id=int.Parse(dr["id"].ToString());
varclsunite.Designation= dr["designation"].ToString();
lstclsunite.Add(varclsunite);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsunite;
}

 public  List<clsunite> getAllClsunite(){
 List<clsunite>  lstclsunite=new List<clsunite>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM unite ");
  using (IDataReader dr = cmd.ExecuteReader()){

 clsunite  varclsunite=null;
 while (dr.Read()){ 

  varclsunite=new clsunite();
 if(!dr["id"].ToString().Trim().Equals("")) varclsunite.Id=int.Parse(dr["id"].ToString());
varclsunite.Designation= dr["designation"].ToString();
lstclsunite.Add(varclsunite);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsunite;
}

 public int insertClsunite(clsunite varclsunite){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("INSERT INTO unite ( designation ) VALUES (@designation  )" );
if(varclsunite.Designation!=null )  cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, varclsunite.Designation));
else cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, DBNull.Value));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int updateClsunite (clsunite varclsunite){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("UPDATE unite  SET designation=@designation  WHERE 1=1  AND id=@id ");
if(varclsunite.Designation!=null )  cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, varclsunite.Designation));
else cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, DBNull.Value));
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsunite.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int deleteClsunite (clsunite varclsunite){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("DELETE FROM unite  WHERE  1=1  AND id=@id ");
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsunite.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}
 
  #endregion CLSUNITE 
#region  CLSIMPLATATION
 public clsimplatation getClsimplatation(object intid){
 clsimplatation  varclsimplatation=new clsimplatation();
try  {
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM implatation WHERE id={0}",intid);
  using (IDataReader dr = cmd.ExecuteReader())  {
 if (dr.Read()){ 

 if(!dr["id"].ToString().Trim().Equals("")) varclsimplatation.Id=int.Parse(dr["id"].ToString());
varclsimplatation.Designation= dr["designation"].ToString();  }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return varclsimplatation;
}

 public  List<clsimplatation> getAllClsimplatation(string criteria){
 List<clsimplatation>  lstclsimplatation=new List<clsimplatation>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
 string sql="SELECT *  FROM implatation  WHERE 1=1";
sql+="  OR   designation LIKE '%"+criteria+"%'";
  cmd.CommandText = string.Format(sql);
  using (IDataReader dr = cmd.ExecuteReader()){

 clsimplatation  varclsimplatation=null;
 while (dr.Read()){ 

  varclsimplatation=new clsimplatation();
 if(!dr["id"].ToString().Trim().Equals("")) varclsimplatation.Id=int.Parse(dr["id"].ToString());
varclsimplatation.Designation= dr["designation"].ToString();
lstclsimplatation.Add(varclsimplatation);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsimplatation;
}

 public  List<clsimplatation> getAllClsimplatation(){
 List<clsimplatation>  lstclsimplatation=new List<clsimplatation>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM implatation ");
  using (IDataReader dr = cmd.ExecuteReader()){

 clsimplatation  varclsimplatation=null;
 while (dr.Read()){ 

  varclsimplatation=new clsimplatation();
 if(!dr["id"].ToString().Trim().Equals("")) varclsimplatation.Id=int.Parse(dr["id"].ToString());
varclsimplatation.Designation= dr["designation"].ToString();
lstclsimplatation.Add(varclsimplatation);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsimplatation;
}

 public int insertClsimplatation(clsimplatation varclsimplatation){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("INSERT INTO implatation ( designation ) VALUES (@designation  )" );
if(varclsimplatation.Designation!=null )  cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, varclsimplatation.Designation));
else cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, DBNull.Value));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int updateClsimplatation (clsimplatation varclsimplatation){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("UPDATE implatation  SET designation=@designation  WHERE 1=1  AND id=@id ");
if(varclsimplatation.Designation!=null )  cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, varclsimplatation.Designation));
else cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, DBNull.Value));
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsimplatation.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int deleteClsimplatation (clsimplatation varclsimplatation){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("DELETE FROM implatation  WHERE  1=1  AND id=@id ");
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsimplatation.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}
 
  #endregion CLSIMPLATATION 
#region  CLSGARNISON
 public clsgarnison getClsgarnison(object intid){
 clsgarnison  varclsgarnison=new clsgarnison();
try  {
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM garnison WHERE id={0}",intid);
  using (IDataReader dr = cmd.ExecuteReader())  {
 if (dr.Read()){ 

 if(!dr["id"].ToString().Trim().Equals("")) varclsgarnison.Id=int.Parse(dr["id"].ToString());
varclsgarnison.Designation= dr["designation"].ToString();  }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return varclsgarnison;
}

 public  List<clsgarnison> getAllClsgarnison(string criteria){
 List<clsgarnison>  lstclsgarnison=new List<clsgarnison>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
 string sql="SELECT *  FROM garnison  WHERE 1=1";
sql+="  OR   designation LIKE '%"+criteria+"%'";
  cmd.CommandText = string.Format(sql);
  using (IDataReader dr = cmd.ExecuteReader()){

 clsgarnison  varclsgarnison=null;
 while (dr.Read()){ 

  varclsgarnison=new clsgarnison();
 if(!dr["id"].ToString().Trim().Equals("")) varclsgarnison.Id=int.Parse(dr["id"].ToString());
varclsgarnison.Designation= dr["designation"].ToString();
lstclsgarnison.Add(varclsgarnison);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsgarnison;
}

 public  List<clsgarnison> getAllClsgarnison(){
 List<clsgarnison>  lstclsgarnison=new List<clsgarnison>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM garnison ");
  using (IDataReader dr = cmd.ExecuteReader()){

 clsgarnison  varclsgarnison=null;
 while (dr.Read()){ 

  varclsgarnison=new clsgarnison();
 if(!dr["id"].ToString().Trim().Equals("")) varclsgarnison.Id=int.Parse(dr["id"].ToString());
varclsgarnison.Designation= dr["designation"].ToString();
lstclsgarnison.Add(varclsgarnison);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsgarnison;
}

 public int insertClsgarnison(clsgarnison varclsgarnison){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("INSERT INTO garnison ( designation ) VALUES (@designation  )" );
if(varclsgarnison.Designation!=null )  cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, varclsgarnison.Designation));
else cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, DBNull.Value));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int updateClsgarnison (clsgarnison varclsgarnison){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("UPDATE garnison  SET designation=@designation  WHERE 1=1  AND id=@id ");
if(varclsgarnison.Designation!=null )  cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, varclsgarnison.Designation));
else cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, DBNull.Value));
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsgarnison.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int deleteClsgarnison (clsgarnison varclsgarnison){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("DELETE FROM garnison  WHERE  1=1  AND id=@id ");
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsgarnison.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}
 
  #endregion CLSGARNISON 
#region  CLSGRADE
 public clsgrade getClsgrade(object intid){
 clsgrade  varclsgrade=new clsgrade();
try  {
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM grade WHERE id={0}",intid);
  using (IDataReader dr = cmd.ExecuteReader())  {
 if (dr.Read()){ 

 if(!dr["id"].ToString().Trim().Equals("")) varclsgrade.Id=int.Parse(dr["id"].ToString());
varclsgrade.Codegradepaie= dr["codegradepaie"].ToString();
varclsgrade.Designation= dr["designation"].ToString();
 if(!dr["montant"].ToString().Trim().Equals("")) varclsgrade.Montant=double.Parse(dr["montant"].ToString());  }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return varclsgrade;
}

 public  List<clsgrade> getAllClsgrade(string criteria){
 List<clsgrade>  lstclsgrade=new List<clsgrade>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
 string sql="SELECT *  FROM grade  WHERE 1=1";
sql+="  OR   codegradepaie LIKE '%"+criteria+"%'";
sql+="  OR   designation LIKE '%"+criteria+"%'";
  cmd.CommandText = string.Format(sql);
  using (IDataReader dr = cmd.ExecuteReader()){

 clsgrade  varclsgrade=null;
 while (dr.Read()){ 

  varclsgrade=new clsgrade();
 if(!dr["id"].ToString().Trim().Equals("")) varclsgrade.Id=int.Parse(dr["id"].ToString());
varclsgrade.Codegradepaie= dr["codegradepaie"].ToString();
varclsgrade.Designation= dr["designation"].ToString();
 if(!dr["montant"].ToString().Trim().Equals("")) varclsgrade.Montant=double.Parse(dr["montant"].ToString());
lstclsgrade.Add(varclsgrade);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsgrade;
}

 public  List<clsgrade> getAllClsgrade(){
 List<clsgrade>  lstclsgrade=new List<clsgrade>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM grade ");
  using (IDataReader dr = cmd.ExecuteReader()){

 clsgrade  varclsgrade=null;
 while (dr.Read()){ 

  varclsgrade=new clsgrade();
 if(!dr["id"].ToString().Trim().Equals("")) varclsgrade.Id=int.Parse(dr["id"].ToString());
varclsgrade.Codegradepaie= dr["codegradepaie"].ToString();
varclsgrade.Designation= dr["designation"].ToString();
 if(!dr["montant"].ToString().Trim().Equals("")) varclsgrade.Montant=double.Parse(dr["montant"].ToString());
lstclsgrade.Add(varclsgrade);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsgrade;
}

 public int insertClsgrade(clsgrade varclsgrade){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("INSERT INTO grade ( codegradepaie,designation,montant ) VALUES (@codegradepaie,@designation,@montant  )" );
if(varclsgrade.Codegradepaie!=null )  cmd.Parameters.Add(getParameter(cmd, "@codegradepaie", DbType.String,100, varclsgrade.Codegradepaie));
else cmd.Parameters.Add(getParameter(cmd, "@codegradepaie", DbType.String,100, DBNull.Value));
if(varclsgrade.Designation!=null )  cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, varclsgrade.Designation));
else cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, DBNull.Value));
if(varclsgrade.Montant.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@montant", DbType.Single,4, varclsgrade.Montant));
else cmd.Parameters.Add(getParameter(cmd, "@montant", DbType.Single,4, DBNull.Value));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int updateClsgrade (clsgrade varclsgrade){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("UPDATE grade  SET codegradepaie=@codegradepaie,designation=@designation,montant=@montant  WHERE 1=1  AND id=@id ");
if(varclsgrade.Codegradepaie!=null )  cmd.Parameters.Add(getParameter(cmd, "@codegradepaie", DbType.String,100, varclsgrade.Codegradepaie));
else cmd.Parameters.Add(getParameter(cmd, "@codegradepaie", DbType.String,100, DBNull.Value));
if(varclsgrade.Designation!=null )  cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, varclsgrade.Designation));
else cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, DBNull.Value));
if(varclsgrade.Montant.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@montant", DbType.Single,4, varclsgrade.Montant));
else cmd.Parameters.Add(getParameter(cmd, "@montant", DbType.Single,4, DBNull.Value));
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsgrade.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int deleteClsgrade (clsgrade varclsgrade){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("DELETE FROM grade  WHERE  1=1  AND id=@id ");
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsgrade.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}
 
  #endregion CLSGRADE 
#region  CLSCOTITULAIRECOMPTE
 public clscotitulairecompte getClscotitulairecompte(object intid){
 clscotitulairecompte  varclscotitulairecompte=new clscotitulairecompte();
try  {
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM cotitulairecompte WHERE id={0}",intid);
  using (IDataReader dr = cmd.ExecuteReader())  {
 if (dr.Read()){ 

 if(!dr["id"].ToString().Trim().Equals("")) varclscotitulairecompte.Id=int.Parse(dr["id"].ToString());
 if(!dr["id_profession"].ToString().Trim().Equals("")) varclscotitulairecompte.Id_profession=int.Parse(dr["id_profession"].ToString());
varclscotitulairecompte.Nom= dr["nom"].ToString();
varclscotitulairecompte.Postnom= dr["postnom"].ToString();
varclscotitulairecompte.Prenom= dr["prenom"].ToString();
varclscotitulairecompte.Sexe= dr["sexe"].ToString();
varclscotitulairecompte.Etatcivil= dr["etatcivil"].ToString();
 if(!dr["datenaissance"].ToString().Trim().Equals("")) varclscotitulairecompte.Datenaissance=DateTime.Parse(dr["datenaissance"].ToString());
varclscotitulairecompte.Lieunaissance= dr["lieunaissance"].ToString();
varclscotitulairecompte.Nomprenompere= dr["nomPrenomPere"].ToString();
varclscotitulairecompte.Nomprenommere= dr["nomprenomMere"].ToString();
varclscotitulairecompte.Modeidentification= dr["modeidentification"].ToString();
varclscotitulairecompte.Numeropieceidentite= dr["numeropieceIdentite"].ToString();
 if(!dr["detelivresonpieceidentite"].ToString().Trim().Equals("")) varclscotitulairecompte.Detelivresonpieceidentite=DateTime.Parse(dr["detelivresonpieceidentite"].ToString());
varclscotitulairecompte.Nomemploiyer= dr["nomemploiyer"].ToString();
varclscotitulairecompte.Addresseemploiyer= dr["addresseemploiyer"].ToString();
varclscotitulairecompte.Telbureau= dr["telbureau"].ToString();
varclscotitulairecompte.Adressepostal= dr["adressepostal"].ToString();
varclscotitulairecompte.Ville= dr["ville"].ToString();
varclscotitulairecompte.Pays= dr["pays"].ToString();
varclscotitulairecompte.Nationalite= dr["nationalite"].ToString();
varclscotitulairecompte.Nomconjoin= dr["nomconjoin"].ToString();
varclscotitulairecompte.Prenomconjoin= dr["prenomconjoin"].ToString();
varclscotitulairecompte.Adressepostale= dr["adressepostale"].ToString();
varclscotitulairecompte.Email= dr["email"].ToString();
varclscotitulairecompte.Tel= dr["tel"].ToString();
varclscotitulairecompte.Fax= dr["fax"].ToString();  }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return varclscotitulairecompte;
}

 public  List<clscotitulairecompte> getAllClscotitulairecompte(string criteria){
 List<clscotitulairecompte>  lstclscotitulairecompte=new List<clscotitulairecompte>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
 string sql="SELECT *  FROM cotitulairecompte  WHERE 1=1";
sql+="  OR   nom LIKE '%"+criteria+"%'";
sql+="  OR   postnom LIKE '%"+criteria+"%'";
sql+="  OR   prenom LIKE '%"+criteria+"%'";
sql+="  OR   sexe LIKE '%"+criteria+"%'";
sql+="  OR   etatcivil LIKE '%"+criteria+"%'";
sql+="  OR   lieunaissance LIKE '%"+criteria+"%'";
sql+="  OR   nomPrenomPere LIKE '%"+criteria+"%'";
sql+="  OR   nomprenomMere LIKE '%"+criteria+"%'";
sql+="  OR   modeidentification LIKE '%"+criteria+"%'";
sql+="  OR   numeropieceIdentite LIKE '%"+criteria+"%'";
sql+="  OR   nomemploiyer LIKE '%"+criteria+"%'";
sql+="  OR   addresseemploiyer LIKE '%"+criteria+"%'";
sql+="  OR   telbureau LIKE '%"+criteria+"%'";
sql+="  OR   adressepostal LIKE '%"+criteria+"%'";
sql+="  OR   ville LIKE '%"+criteria+"%'";
sql+="  OR   pays LIKE '%"+criteria+"%'";
sql+="  OR   nationalite LIKE '%"+criteria+"%'";
sql+="  OR   nomconjoin LIKE '%"+criteria+"%'";
sql+="  OR   prenomconjoin LIKE '%"+criteria+"%'";
sql+="  OR   adressepostale LIKE '%"+criteria+"%'";
sql+="  OR   email LIKE '%"+criteria+"%'";
sql+="  OR   tel LIKE '%"+criteria+"%'";
sql+="  OR   fax LIKE '%"+criteria+"%'";
  cmd.CommandText = string.Format(sql);
  using (IDataReader dr = cmd.ExecuteReader()){

 clscotitulairecompte  varclscotitulairecompte=null;
 while (dr.Read()){ 

  varclscotitulairecompte=new clscotitulairecompte();
 if(!dr["id"].ToString().Trim().Equals("")) varclscotitulairecompte.Id=int.Parse(dr["id"].ToString());
 if(!dr["id_profession"].ToString().Trim().Equals("")) varclscotitulairecompte.Id_profession=int.Parse(dr["id_profession"].ToString());
varclscotitulairecompte.Nom= dr["nom"].ToString();
varclscotitulairecompte.Postnom= dr["postnom"].ToString();
varclscotitulairecompte.Prenom= dr["prenom"].ToString();
varclscotitulairecompte.Sexe= dr["sexe"].ToString();
varclscotitulairecompte.Etatcivil= dr["etatcivil"].ToString();
 if(!dr["datenaissance"].ToString().Trim().Equals("")) varclscotitulairecompte.Datenaissance=DateTime.Parse(dr["datenaissance"].ToString());
varclscotitulairecompte.Lieunaissance= dr["lieunaissance"].ToString();
varclscotitulairecompte.Nomprenompere= dr["nomPrenomPere"].ToString();
varclscotitulairecompte.Nomprenommere= dr["nomprenomMere"].ToString();
varclscotitulairecompte.Modeidentification= dr["modeidentification"].ToString();
varclscotitulairecompte.Numeropieceidentite= dr["numeropieceIdentite"].ToString();
 if(!dr["detelivresonpieceidentite"].ToString().Trim().Equals("")) varclscotitulairecompte.Detelivresonpieceidentite=DateTime.Parse(dr["detelivresonpieceidentite"].ToString());
varclscotitulairecompte.Nomemploiyer= dr["nomemploiyer"].ToString();
varclscotitulairecompte.Addresseemploiyer= dr["addresseemploiyer"].ToString();
varclscotitulairecompte.Telbureau= dr["telbureau"].ToString();
varclscotitulairecompte.Adressepostal= dr["adressepostal"].ToString();
varclscotitulairecompte.Ville= dr["ville"].ToString();
varclscotitulairecompte.Pays= dr["pays"].ToString();
varclscotitulairecompte.Nationalite= dr["nationalite"].ToString();
varclscotitulairecompte.Nomconjoin= dr["nomconjoin"].ToString();
varclscotitulairecompte.Prenomconjoin= dr["prenomconjoin"].ToString();
varclscotitulairecompte.Adressepostale= dr["adressepostale"].ToString();
varclscotitulairecompte.Email= dr["email"].ToString();
varclscotitulairecompte.Tel= dr["tel"].ToString();
varclscotitulairecompte.Fax= dr["fax"].ToString();
lstclscotitulairecompte.Add(varclscotitulairecompte);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclscotitulairecompte;
}

 public  List<clscotitulairecompte> getAllClscotitulairecompte(){
 List<clscotitulairecompte>  lstclscotitulairecompte=new List<clscotitulairecompte>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM cotitulairecompte ");
  using (IDataReader dr = cmd.ExecuteReader()){

 clscotitulairecompte  varclscotitulairecompte=null;
 while (dr.Read()){ 

  varclscotitulairecompte=new clscotitulairecompte();
 if(!dr["id"].ToString().Trim().Equals("")) varclscotitulairecompte.Id=int.Parse(dr["id"].ToString());
 if(!dr["id_profession"].ToString().Trim().Equals("")) varclscotitulairecompte.Id_profession=int.Parse(dr["id_profession"].ToString());
varclscotitulairecompte.Nom= dr["nom"].ToString();
varclscotitulairecompte.Postnom= dr["postnom"].ToString();
varclscotitulairecompte.Prenom= dr["prenom"].ToString();
varclscotitulairecompte.Sexe= dr["sexe"].ToString();
varclscotitulairecompte.Etatcivil= dr["etatcivil"].ToString();
 if(!dr["datenaissance"].ToString().Trim().Equals("")) varclscotitulairecompte.Datenaissance=DateTime.Parse(dr["datenaissance"].ToString());
varclscotitulairecompte.Lieunaissance= dr["lieunaissance"].ToString();
varclscotitulairecompte.Nomprenompere= dr["nomPrenomPere"].ToString();
varclscotitulairecompte.Nomprenommere= dr["nomprenomMere"].ToString();
varclscotitulairecompte.Modeidentification= dr["modeidentification"].ToString();
varclscotitulairecompte.Numeropieceidentite= dr["numeropieceIdentite"].ToString();
 if(!dr["detelivresonpieceidentite"].ToString().Trim().Equals("")) varclscotitulairecompte.Detelivresonpieceidentite=DateTime.Parse(dr["detelivresonpieceidentite"].ToString());
varclscotitulairecompte.Nomemploiyer= dr["nomemploiyer"].ToString();
varclscotitulairecompte.Addresseemploiyer= dr["addresseemploiyer"].ToString();
varclscotitulairecompte.Telbureau= dr["telbureau"].ToString();
varclscotitulairecompte.Adressepostal= dr["adressepostal"].ToString();
varclscotitulairecompte.Ville= dr["ville"].ToString();
varclscotitulairecompte.Pays= dr["pays"].ToString();
varclscotitulairecompte.Nationalite= dr["nationalite"].ToString();
varclscotitulairecompte.Nomconjoin= dr["nomconjoin"].ToString();
varclscotitulairecompte.Prenomconjoin= dr["prenomconjoin"].ToString();
varclscotitulairecompte.Adressepostale= dr["adressepostale"].ToString();
varclscotitulairecompte.Email= dr["email"].ToString();
varclscotitulairecompte.Tel= dr["tel"].ToString();
varclscotitulairecompte.Fax= dr["fax"].ToString();
lstclscotitulairecompte.Add(varclscotitulairecompte);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclscotitulairecompte;
}

 public int insertClscotitulairecompte(clscotitulairecompte varclscotitulairecompte){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("INSERT INTO cotitulairecompte ( id_profession,nom,postnom,prenom,sexe,etatcivil,datenaissance,lieunaissance,nomPrenomPere,nomprenomMere,modeidentification,numeropieceIdentite,detelivresonpieceidentite,nomemploiyer,addresseemploiyer,telbureau,adressepostal,ville,pays,nationalite,nomconjoin,prenomconjoin,adressepostale,email,tel,fax ) VALUES (@id_profession,@nom,@postnom,@prenom,@sexe,@etatcivil,@datenaissance,@lieunaissance,@nomPrenomPere,@nomprenomMere,@modeidentification,@numeropieceIdentite,@detelivresonpieceidentite,@nomemploiyer,@addresseemploiyer,@telbureau,@adressepostal,@ville,@pays,@nationalite,@nomconjoin,@prenomconjoin,@adressepostale,@email,@tel,@fax  )" );
if(varclscotitulairecompte.Id_profession.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_profession", DbType.Int32,4, varclscotitulairecompte.Id_profession));
else cmd.Parameters.Add(getParameter(cmd, "@id_profession", DbType.Int32,4, DBNull.Value));
if(varclscotitulairecompte.Nom!=null )  cmd.Parameters.Add(getParameter(cmd, "@nom", DbType.String,30, varclscotitulairecompte.Nom));
else cmd.Parameters.Add(getParameter(cmd, "@nom", DbType.String,30, DBNull.Value));
if(varclscotitulairecompte.Postnom!=null )  cmd.Parameters.Add(getParameter(cmd, "@postnom", DbType.String,40, varclscotitulairecompte.Postnom));
else cmd.Parameters.Add(getParameter(cmd, "@postnom", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Prenom!=null )  cmd.Parameters.Add(getParameter(cmd, "@prenom", DbType.String,30, varclscotitulairecompte.Prenom));
else cmd.Parameters.Add(getParameter(cmd, "@prenom", DbType.String,30, DBNull.Value));
if(varclscotitulairecompte.Sexe!=null )  cmd.Parameters.Add(getParameter(cmd, "@sexe", DbType.String,1, varclscotitulairecompte.Sexe));
else cmd.Parameters.Add(getParameter(cmd, "@sexe", DbType.String,1, DBNull.Value));
if(varclscotitulairecompte.Etatcivil!=null )  cmd.Parameters.Add(getParameter(cmd, "@etatcivil", DbType.String,15, varclscotitulairecompte.Etatcivil));
else cmd.Parameters.Add(getParameter(cmd, "@etatcivil", DbType.String,15, DBNull.Value));
if(varclscotitulairecompte.Datenaissance.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@datenaissance", DbType.DateTime,8, varclscotitulairecompte.Datenaissance));
else cmd.Parameters.Add(getParameter(cmd, "@datenaissance", DbType.DateTime,8, DBNull.Value));
if(varclscotitulairecompte.Lieunaissance!=null )  cmd.Parameters.Add(getParameter(cmd, "@lieunaissance", DbType.String,100, varclscotitulairecompte.Lieunaissance));
else cmd.Parameters.Add(getParameter(cmd, "@lieunaissance", DbType.String,100, DBNull.Value));
if(varclscotitulairecompte.Nomprenompere!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomPrenomPere", DbType.String,100, varclscotitulairecompte.Nomprenompere));
else cmd.Parameters.Add(getParameter(cmd, "@nomPrenomPere", DbType.String,100, DBNull.Value));
if(varclscotitulairecompte.Nomprenommere!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomprenomMere", DbType.String,100, varclscotitulairecompte.Nomprenommere));
else cmd.Parameters.Add(getParameter(cmd, "@nomprenomMere", DbType.String,100, DBNull.Value));
if(varclscotitulairecompte.Modeidentification!=null )  cmd.Parameters.Add(getParameter(cmd, "@modeidentification", DbType.String,40, varclscotitulairecompte.Modeidentification));
else cmd.Parameters.Add(getParameter(cmd, "@modeidentification", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Numeropieceidentite!=null )  cmd.Parameters.Add(getParameter(cmd, "@numeropieceIdentite", DbType.String,40, varclscotitulairecompte.Numeropieceidentite));
else cmd.Parameters.Add(getParameter(cmd, "@numeropieceIdentite", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Detelivresonpieceidentite.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@detelivresonpieceidentite", DbType.DateTime,8, varclscotitulairecompte.Detelivresonpieceidentite));
else cmd.Parameters.Add(getParameter(cmd, "@detelivresonpieceidentite", DbType.DateTime,8, DBNull.Value));
if(varclscotitulairecompte.Nomemploiyer!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomemploiyer", DbType.String,100, varclscotitulairecompte.Nomemploiyer));
else cmd.Parameters.Add(getParameter(cmd, "@nomemploiyer", DbType.String,100, DBNull.Value));
if(varclscotitulairecompte.Addresseemploiyer!=null )  cmd.Parameters.Add(getParameter(cmd, "@addresseemploiyer", DbType.String,220, varclscotitulairecompte.Addresseemploiyer));
else cmd.Parameters.Add(getParameter(cmd, "@addresseemploiyer", DbType.String,220, DBNull.Value));
if(varclscotitulairecompte.Telbureau!=null )  cmd.Parameters.Add(getParameter(cmd, "@telbureau", DbType.String,13, varclscotitulairecompte.Telbureau));
else cmd.Parameters.Add(getParameter(cmd, "@telbureau", DbType.String,13, DBNull.Value));
if(varclscotitulairecompte.Adressepostal!=null )  cmd.Parameters.Add(getParameter(cmd, "@adressepostal", DbType.String,30, varclscotitulairecompte.Adressepostal));
else cmd.Parameters.Add(getParameter(cmd, "@adressepostal", DbType.String,30, DBNull.Value));
if(varclscotitulairecompte.Ville!=null )  cmd.Parameters.Add(getParameter(cmd, "@ville", DbType.String,40, varclscotitulairecompte.Ville));
else cmd.Parameters.Add(getParameter(cmd, "@ville", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Pays!=null )  cmd.Parameters.Add(getParameter(cmd, "@pays", DbType.String,40, varclscotitulairecompte.Pays));
else cmd.Parameters.Add(getParameter(cmd, "@pays", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Nationalite!=null )  cmd.Parameters.Add(getParameter(cmd, "@nationalite", DbType.String,40, varclscotitulairecompte.Nationalite));
else cmd.Parameters.Add(getParameter(cmd, "@nationalite", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Nomconjoin!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomconjoin", DbType.String,40, varclscotitulairecompte.Nomconjoin));
else cmd.Parameters.Add(getParameter(cmd, "@nomconjoin", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Prenomconjoin!=null )  cmd.Parameters.Add(getParameter(cmd, "@prenomconjoin", DbType.String,40, varclscotitulairecompte.Prenomconjoin));
else cmd.Parameters.Add(getParameter(cmd, "@prenomconjoin", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Adressepostale!=null )  cmd.Parameters.Add(getParameter(cmd, "@adressepostale", DbType.String,40, varclscotitulairecompte.Adressepostale));
else cmd.Parameters.Add(getParameter(cmd, "@adressepostale", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Email!=null )  cmd.Parameters.Add(getParameter(cmd, "@email", DbType.String,40, varclscotitulairecompte.Email));
else cmd.Parameters.Add(getParameter(cmd, "@email", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Tel!=null )  cmd.Parameters.Add(getParameter(cmd, "@tel", DbType.String,13, varclscotitulairecompte.Tel));
else cmd.Parameters.Add(getParameter(cmd, "@tel", DbType.String,13, DBNull.Value));
if(varclscotitulairecompte.Fax!=null )  cmd.Parameters.Add(getParameter(cmd, "@fax", DbType.String,40, varclscotitulairecompte.Fax));
else cmd.Parameters.Add(getParameter(cmd, "@fax", DbType.String,40, DBNull.Value));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int updateClscotitulairecompte (clscotitulairecompte varclscotitulairecompte){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("UPDATE cotitulairecompte  SET id_profession=@id_profession,nom=@nom,postnom=@postnom,prenom=@prenom,sexe=@sexe,etatcivil=@etatcivil,datenaissance=@datenaissance,lieunaissance=@lieunaissance,nomPrenomPere=@nomPrenomPere,nomprenomMere=@nomprenomMere,modeidentification=@modeidentification,numeropieceIdentite=@numeropieceIdentite,detelivresonpieceidentite=@detelivresonpieceidentite,nomemploiyer=@nomemploiyer,addresseemploiyer=@addresseemploiyer,telbureau=@telbureau,adressepostal=@adressepostal,ville=@ville,pays=@pays,nationalite=@nationalite,nomconjoin=@nomconjoin,prenomconjoin=@prenomconjoin,adressepostale=@adressepostale,email=@email,tel=@tel,fax=@fax  WHERE 1=1  AND id=@id ");
if(varclscotitulairecompte.Id_profession.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_profession", DbType.Int32,4, varclscotitulairecompte.Id_profession));
else cmd.Parameters.Add(getParameter(cmd, "@id_profession", DbType.Int32,4, DBNull.Value));
if(varclscotitulairecompte.Nom!=null )  cmd.Parameters.Add(getParameter(cmd, "@nom", DbType.String,30, varclscotitulairecompte.Nom));
else cmd.Parameters.Add(getParameter(cmd, "@nom", DbType.String,30, DBNull.Value));
if(varclscotitulairecompte.Postnom!=null )  cmd.Parameters.Add(getParameter(cmd, "@postnom", DbType.String,40, varclscotitulairecompte.Postnom));
else cmd.Parameters.Add(getParameter(cmd, "@postnom", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Prenom!=null )  cmd.Parameters.Add(getParameter(cmd, "@prenom", DbType.String,30, varclscotitulairecompte.Prenom));
else cmd.Parameters.Add(getParameter(cmd, "@prenom", DbType.String,30, DBNull.Value));
if(varclscotitulairecompte.Sexe!=null )  cmd.Parameters.Add(getParameter(cmd, "@sexe", DbType.String,1, varclscotitulairecompte.Sexe));
else cmd.Parameters.Add(getParameter(cmd, "@sexe", DbType.String,1, DBNull.Value));
if(varclscotitulairecompte.Etatcivil!=null )  cmd.Parameters.Add(getParameter(cmd, "@etatcivil", DbType.String,15, varclscotitulairecompte.Etatcivil));
else cmd.Parameters.Add(getParameter(cmd, "@etatcivil", DbType.String,15, DBNull.Value));
if(varclscotitulairecompte.Datenaissance.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@datenaissance", DbType.DateTime,8, varclscotitulairecompte.Datenaissance));
else cmd.Parameters.Add(getParameter(cmd, "@datenaissance", DbType.DateTime,8, DBNull.Value));
if(varclscotitulairecompte.Lieunaissance!=null )  cmd.Parameters.Add(getParameter(cmd, "@lieunaissance", DbType.String,100, varclscotitulairecompte.Lieunaissance));
else cmd.Parameters.Add(getParameter(cmd, "@lieunaissance", DbType.String,100, DBNull.Value));
if(varclscotitulairecompte.Nomprenompere!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomPrenomPere", DbType.String,100, varclscotitulairecompte.Nomprenompere));
else cmd.Parameters.Add(getParameter(cmd, "@nomPrenomPere", DbType.String,100, DBNull.Value));
if(varclscotitulairecompte.Nomprenommere!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomprenomMere", DbType.String,100, varclscotitulairecompte.Nomprenommere));
else cmd.Parameters.Add(getParameter(cmd, "@nomprenomMere", DbType.String,100, DBNull.Value));
if(varclscotitulairecompte.Modeidentification!=null )  cmd.Parameters.Add(getParameter(cmd, "@modeidentification", DbType.String,40, varclscotitulairecompte.Modeidentification));
else cmd.Parameters.Add(getParameter(cmd, "@modeidentification", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Numeropieceidentite!=null )  cmd.Parameters.Add(getParameter(cmd, "@numeropieceIdentite", DbType.String,40, varclscotitulairecompte.Numeropieceidentite));
else cmd.Parameters.Add(getParameter(cmd, "@numeropieceIdentite", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Detelivresonpieceidentite.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@detelivresonpieceidentite", DbType.DateTime,8, varclscotitulairecompte.Detelivresonpieceidentite));
else cmd.Parameters.Add(getParameter(cmd, "@detelivresonpieceidentite", DbType.DateTime,8, DBNull.Value));
if(varclscotitulairecompte.Nomemploiyer!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomemploiyer", DbType.String,100, varclscotitulairecompte.Nomemploiyer));
else cmd.Parameters.Add(getParameter(cmd, "@nomemploiyer", DbType.String,100, DBNull.Value));
if(varclscotitulairecompte.Addresseemploiyer!=null )  cmd.Parameters.Add(getParameter(cmd, "@addresseemploiyer", DbType.String,220, varclscotitulairecompte.Addresseemploiyer));
else cmd.Parameters.Add(getParameter(cmd, "@addresseemploiyer", DbType.String,220, DBNull.Value));
if(varclscotitulairecompte.Telbureau!=null )  cmd.Parameters.Add(getParameter(cmd, "@telbureau", DbType.String,13, varclscotitulairecompte.Telbureau));
else cmd.Parameters.Add(getParameter(cmd, "@telbureau", DbType.String,13, DBNull.Value));
if(varclscotitulairecompte.Adressepostal!=null )  cmd.Parameters.Add(getParameter(cmd, "@adressepostal", DbType.String,30, varclscotitulairecompte.Adressepostal));
else cmd.Parameters.Add(getParameter(cmd, "@adressepostal", DbType.String,30, DBNull.Value));
if(varclscotitulairecompte.Ville!=null )  cmd.Parameters.Add(getParameter(cmd, "@ville", DbType.String,40, varclscotitulairecompte.Ville));
else cmd.Parameters.Add(getParameter(cmd, "@ville", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Pays!=null )  cmd.Parameters.Add(getParameter(cmd, "@pays", DbType.String,40, varclscotitulairecompte.Pays));
else cmd.Parameters.Add(getParameter(cmd, "@pays", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Nationalite!=null )  cmd.Parameters.Add(getParameter(cmd, "@nationalite", DbType.String,40, varclscotitulairecompte.Nationalite));
else cmd.Parameters.Add(getParameter(cmd, "@nationalite", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Nomconjoin!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomconjoin", DbType.String,40, varclscotitulairecompte.Nomconjoin));
else cmd.Parameters.Add(getParameter(cmd, "@nomconjoin", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Prenomconjoin!=null )  cmd.Parameters.Add(getParameter(cmd, "@prenomconjoin", DbType.String,40, varclscotitulairecompte.Prenomconjoin));
else cmd.Parameters.Add(getParameter(cmd, "@prenomconjoin", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Adressepostale!=null )  cmd.Parameters.Add(getParameter(cmd, "@adressepostale", DbType.String,40, varclscotitulairecompte.Adressepostale));
else cmd.Parameters.Add(getParameter(cmd, "@adressepostale", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Email!=null )  cmd.Parameters.Add(getParameter(cmd, "@email", DbType.String,40, varclscotitulairecompte.Email));
else cmd.Parameters.Add(getParameter(cmd, "@email", DbType.String,40, DBNull.Value));
if(varclscotitulairecompte.Tel!=null )  cmd.Parameters.Add(getParameter(cmd, "@tel", DbType.String,13, varclscotitulairecompte.Tel));
else cmd.Parameters.Add(getParameter(cmd, "@tel", DbType.String,13, DBNull.Value));
if(varclscotitulairecompte.Fax!=null )  cmd.Parameters.Add(getParameter(cmd, "@fax", DbType.String,40, varclscotitulairecompte.Fax));
else cmd.Parameters.Add(getParameter(cmd, "@fax", DbType.String,40, DBNull.Value));
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclscotitulairecompte.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int deleteClscotitulairecompte (clscotitulairecompte varclscotitulairecompte){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("DELETE FROM cotitulairecompte  WHERE  1=1  AND id=@id ");
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclscotitulairecompte.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}
 
  #endregion CLSCOTITULAIRECOMPTE 
#region  CLSMILITAIRE
 public clsmilitaire getClsmilitaire(object intid){
 clsmilitaire  varclsmilitaire=new clsmilitaire();
try  {
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM militaire WHERE id={0}",intid);
  using (IDataReader dr = cmd.ExecuteReader())  {
 if (dr.Read()){ 

 if(!dr["id"].ToString().Trim().Equals("")) varclsmilitaire.Id=int.Parse(dr["id"].ToString());
 if(!dr["id_cotitulairecompte"].ToString().Trim().Equals("")) varclsmilitaire.Id_cotitulairecompte=int.Parse(dr["id_cotitulairecompte"].ToString());
 if(!dr["id_province"].ToString().Trim().Equals("")) varclsmilitaire.Id_province=int.Parse(dr["id_province"].ToString());
 if(!dr["id_unite"].ToString().Trim().Equals("")) varclsmilitaire.Id_unite=int.Parse(dr["id_unite"].ToString());
 if(!dr["id_garnison"].ToString().Trim().Equals("")) varclsmilitaire.Id_garnison=int.Parse(dr["id_garnison"].ToString());
 if(!dr["id_implatation"].ToString().Trim().Equals("")) varclsmilitaire.Id_implatation=int.Parse(dr["id_implatation"].ToString());
 if(!dr["id_grade"].ToString().Trim().Equals("")) varclsmilitaire.Id_grade=int.Parse(dr["id_grade"].ToString());
 if(!dr["numeroidentifiantUnique"].ToString().Trim().Equals("")) varclsmilitaire.Numeroidentifiantunique=int.Parse(dr["numeroidentifiantUnique"].ToString());
 if(!dr["matricule"].ToString().Trim().Equals("")) varclsmilitaire.Matricule=int.Parse(dr["matricule"].ToString());
varclsmilitaire.Nom= dr["nom"].ToString();
varclsmilitaire.Postnom= dr["postnom"].ToString();
varclsmilitaire.Prenom= dr["prenom"].ToString();
varclsmilitaire.Sexe= dr["sexe"].ToString();
varclsmilitaire.Etatcivil= dr["etatcivil"].ToString();
 if(!dr["datenaissance"].ToString().Trim().Equals("")) varclsmilitaire.Datenaissance=DateTime.Parse(dr["datenaissance"].ToString());
varclsmilitaire.Lieunaissance= dr["lieunaissance"].ToString();
varclsmilitaire.Nomprenompere= dr["nomPrenomPere"].ToString();
varclsmilitaire.Nomprenommere= dr["nomprenomMere"].ToString();
varclsmilitaire.Modeidentification= dr["modeidentification"].ToString();
varclsmilitaire.Numeropieceidentite= dr["numeropieceIdentite"].ToString();
 if(!dr["detelivresonpieceidentite"].ToString().Trim().Equals("")) varclsmilitaire.Detelivresonpieceidentite=DateTime.Parse(dr["detelivresonpieceidentite"].ToString());
varclsmilitaire.Nomemploiyer= dr["nomemploiyer"].ToString();
varclsmilitaire.Addresseemploiyer= dr["addresseemploiyer"].ToString();
varclsmilitaire.Telbureau= dr["telbureau"].ToString();
varclsmilitaire.Adressepostal= dr["adressepostal"].ToString();
varclsmilitaire.Ville= dr["ville"].ToString();
varclsmilitaire.Pays= dr["pays"].ToString();
varclsmilitaire.Nationalite= dr["nationalite"].ToString();
varclsmilitaire.Nomconjoin= dr["nomconjoin"].ToString();
varclsmilitaire.Email= dr["email"].ToString();
varclsmilitaire.Tel= dr["tel"].ToString();
varclsmilitaire.Fax= dr["fax"].ToString();  }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return varclsmilitaire;
}

 public  List<clsmilitaire> getAllClsmilitaire(string criteria){
 List<clsmilitaire>  lstclsmilitaire=new List<clsmilitaire>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
 string sql="SELECT *  FROM militaire  WHERE 1=1";
sql+="  OR   nom LIKE '%"+criteria+"%'";
sql+="  OR   postnom LIKE '%"+criteria+"%'";
sql+="  OR   prenom LIKE '%"+criteria+"%'";
sql+="  OR   sexe LIKE '%"+criteria+"%'";
sql+="  OR   etatcivil LIKE '%"+criteria+"%'";
sql+="  OR   lieunaissance LIKE '%"+criteria+"%'";
sql+="  OR   nomPrenomPere LIKE '%"+criteria+"%'";
sql+="  OR   nomprenomMere LIKE '%"+criteria+"%'";
sql+="  OR   modeidentification LIKE '%"+criteria+"%'";
sql+="  OR   numeropieceIdentite LIKE '%"+criteria+"%'";
sql+="  OR   nomemploiyer LIKE '%"+criteria+"%'";
sql+="  OR   addresseemploiyer LIKE '%"+criteria+"%'";
sql+="  OR   telbureau LIKE '%"+criteria+"%'";
sql+="  OR   adressepostal LIKE '%"+criteria+"%'";
sql+="  OR   ville LIKE '%"+criteria+"%'";
sql+="  OR   pays LIKE '%"+criteria+"%'";
sql+="  OR   nationalite LIKE '%"+criteria+"%'";
sql+="  OR   nomconjoin LIKE '%"+criteria+"%'";
sql+="  OR   email LIKE '%"+criteria+"%'";
sql+="  OR   tel LIKE '%"+criteria+"%'";
sql+="  OR   fax LIKE '%"+criteria+"%'";
  cmd.CommandText = string.Format(sql);
  using (IDataReader dr = cmd.ExecuteReader()){

 clsmilitaire  varclsmilitaire=null;
 while (dr.Read()){ 

  varclsmilitaire=new clsmilitaire();
 if(!dr["id"].ToString().Trim().Equals("")) varclsmilitaire.Id=int.Parse(dr["id"].ToString());
 if(!dr["id_cotitulairecompte"].ToString().Trim().Equals("")) varclsmilitaire.Id_cotitulairecompte=int.Parse(dr["id_cotitulairecompte"].ToString());
 if(!dr["id_province"].ToString().Trim().Equals("")) varclsmilitaire.Id_province=int.Parse(dr["id_province"].ToString());
 if(!dr["id_unite"].ToString().Trim().Equals("")) varclsmilitaire.Id_unite=int.Parse(dr["id_unite"].ToString());
 if(!dr["id_garnison"].ToString().Trim().Equals("")) varclsmilitaire.Id_garnison=int.Parse(dr["id_garnison"].ToString());
 if(!dr["id_implatation"].ToString().Trim().Equals("")) varclsmilitaire.Id_implatation=int.Parse(dr["id_implatation"].ToString());
 if(!dr["id_grade"].ToString().Trim().Equals("")) varclsmilitaire.Id_grade=int.Parse(dr["id_grade"].ToString());
 if(!dr["numeroidentifiantUnique"].ToString().Trim().Equals("")) varclsmilitaire.Numeroidentifiantunique=int.Parse(dr["numeroidentifiantUnique"].ToString());
 if(!dr["matricule"].ToString().Trim().Equals("")) varclsmilitaire.Matricule=int.Parse(dr["matricule"].ToString());
varclsmilitaire.Nom= dr["nom"].ToString();
varclsmilitaire.Postnom= dr["postnom"].ToString();
varclsmilitaire.Prenom= dr["prenom"].ToString();
varclsmilitaire.Sexe= dr["sexe"].ToString();
varclsmilitaire.Etatcivil= dr["etatcivil"].ToString();
 if(!dr["datenaissance"].ToString().Trim().Equals("")) varclsmilitaire.Datenaissance=DateTime.Parse(dr["datenaissance"].ToString());
varclsmilitaire.Lieunaissance= dr["lieunaissance"].ToString();
varclsmilitaire.Nomprenompere= dr["nomPrenomPere"].ToString();
varclsmilitaire.Nomprenommere= dr["nomprenomMere"].ToString();
varclsmilitaire.Modeidentification= dr["modeidentification"].ToString();
varclsmilitaire.Numeropieceidentite= dr["numeropieceIdentite"].ToString();
 if(!dr["detelivresonpieceidentite"].ToString().Trim().Equals("")) varclsmilitaire.Detelivresonpieceidentite=DateTime.Parse(dr["detelivresonpieceidentite"].ToString());
varclsmilitaire.Nomemploiyer= dr["nomemploiyer"].ToString();
varclsmilitaire.Addresseemploiyer= dr["addresseemploiyer"].ToString();
varclsmilitaire.Telbureau= dr["telbureau"].ToString();
varclsmilitaire.Adressepostal= dr["adressepostal"].ToString();
varclsmilitaire.Ville= dr["ville"].ToString();
varclsmilitaire.Pays= dr["pays"].ToString();
varclsmilitaire.Nationalite= dr["nationalite"].ToString();
varclsmilitaire.Nomconjoin= dr["nomconjoin"].ToString();
varclsmilitaire.Email= dr["email"].ToString();
varclsmilitaire.Tel= dr["tel"].ToString();
varclsmilitaire.Fax= dr["fax"].ToString();
lstclsmilitaire.Add(varclsmilitaire);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsmilitaire;
}

 public  List<clsmilitaire> getAllClsmilitaire(){
 List<clsmilitaire>  lstclsmilitaire=new List<clsmilitaire>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM militaire ");
  using (IDataReader dr = cmd.ExecuteReader()){

 clsmilitaire  varclsmilitaire=null;
 while (dr.Read()){ 

  varclsmilitaire=new clsmilitaire();
 if(!dr["id"].ToString().Trim().Equals("")) varclsmilitaire.Id=int.Parse(dr["id"].ToString());
 if(!dr["id_cotitulairecompte"].ToString().Trim().Equals("")) varclsmilitaire.Id_cotitulairecompte=int.Parse(dr["id_cotitulairecompte"].ToString());
 if(!dr["id_province"].ToString().Trim().Equals("")) varclsmilitaire.Id_province=int.Parse(dr["id_province"].ToString());
 if(!dr["id_unite"].ToString().Trim().Equals("")) varclsmilitaire.Id_unite=int.Parse(dr["id_unite"].ToString());
 if(!dr["id_garnison"].ToString().Trim().Equals("")) varclsmilitaire.Id_garnison=int.Parse(dr["id_garnison"].ToString());
 if(!dr["id_implatation"].ToString().Trim().Equals("")) varclsmilitaire.Id_implatation=int.Parse(dr["id_implatation"].ToString());
 if(!dr["id_grade"].ToString().Trim().Equals("")) varclsmilitaire.Id_grade=int.Parse(dr["id_grade"].ToString());
 if(!dr["numeroidentifiantUnique"].ToString().Trim().Equals("")) varclsmilitaire.Numeroidentifiantunique=int.Parse(dr["numeroidentifiantUnique"].ToString());
 if(!dr["matricule"].ToString().Trim().Equals("")) varclsmilitaire.Matricule=int.Parse(dr["matricule"].ToString());
varclsmilitaire.Nom= dr["nom"].ToString();
varclsmilitaire.Postnom= dr["postnom"].ToString();
varclsmilitaire.Prenom= dr["prenom"].ToString();
varclsmilitaire.Sexe= dr["sexe"].ToString();
varclsmilitaire.Etatcivil= dr["etatcivil"].ToString();
 if(!dr["datenaissance"].ToString().Trim().Equals("")) varclsmilitaire.Datenaissance=DateTime.Parse(dr["datenaissance"].ToString());
varclsmilitaire.Lieunaissance= dr["lieunaissance"].ToString();
varclsmilitaire.Nomprenompere= dr["nomPrenomPere"].ToString();
varclsmilitaire.Nomprenommere= dr["nomprenomMere"].ToString();
varclsmilitaire.Modeidentification= dr["modeidentification"].ToString();
varclsmilitaire.Numeropieceidentite= dr["numeropieceIdentite"].ToString();
 if(!dr["detelivresonpieceidentite"].ToString().Trim().Equals("")) varclsmilitaire.Detelivresonpieceidentite=DateTime.Parse(dr["detelivresonpieceidentite"].ToString());
varclsmilitaire.Nomemploiyer= dr["nomemploiyer"].ToString();
varclsmilitaire.Addresseemploiyer= dr["addresseemploiyer"].ToString();
varclsmilitaire.Telbureau= dr["telbureau"].ToString();
varclsmilitaire.Adressepostal= dr["adressepostal"].ToString();
varclsmilitaire.Ville= dr["ville"].ToString();
varclsmilitaire.Pays= dr["pays"].ToString();
varclsmilitaire.Nationalite= dr["nationalite"].ToString();
varclsmilitaire.Nomconjoin= dr["nomconjoin"].ToString();
varclsmilitaire.Email= dr["email"].ToString();
varclsmilitaire.Tel= dr["tel"].ToString();
varclsmilitaire.Fax= dr["fax"].ToString();
lstclsmilitaire.Add(varclsmilitaire);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsmilitaire;
}

 public int insertClsmilitaire(clsmilitaire varclsmilitaire){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("INSERT INTO militaire ( id_cotitulairecompte,id_province,id_unite,id_garnison,id_implatation,id_grade,numeroidentifiantUnique,matricule,nom,postnom,prenom,sexe,etatcivil,datenaissance,lieunaissance,nomPrenomPere,nomprenomMere,modeidentification,numeropieceIdentite,detelivresonpieceidentite,nomemploiyer,addresseemploiyer,telbureau,adressepostal,ville,pays,nationalite,nomconjoin,email,tel,fax ) VALUES (@id_cotitulairecompte,@id_province,@id_unite,@id_garnison,@id_implatation,@id_grade,@numeroidentifiantUnique,@matricule,@nom,@postnom,@prenom,@sexe,@etatcivil,@datenaissance,@lieunaissance,@nomPrenomPere,@nomprenomMere,@modeidentification,@numeropieceIdentite,@detelivresonpieceidentite,@nomemploiyer,@addresseemploiyer,@telbureau,@adressepostal,@ville,@pays,@nationalite,@nomconjoin,@email,@tel,@fax  )" );
if(varclsmilitaire.Id_cotitulairecompte.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_cotitulairecompte", DbType.Int32,4, varclsmilitaire.Id_cotitulairecompte));
else cmd.Parameters.Add(getParameter(cmd, "@id_cotitulairecompte", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Id_province.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_province", DbType.Int32,4, varclsmilitaire.Id_province));
else cmd.Parameters.Add(getParameter(cmd, "@id_province", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Id_unite.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_unite", DbType.Int32,4, varclsmilitaire.Id_unite));
else cmd.Parameters.Add(getParameter(cmd, "@id_unite", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Id_garnison.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_garnison", DbType.Int32,4, varclsmilitaire.Id_garnison));
else cmd.Parameters.Add(getParameter(cmd, "@id_garnison", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Id_implatation.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_implatation", DbType.Int32,4, varclsmilitaire.Id_implatation));
else cmd.Parameters.Add(getParameter(cmd, "@id_implatation", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Id_grade.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_grade", DbType.Int32,4, varclsmilitaire.Id_grade));
else cmd.Parameters.Add(getParameter(cmd, "@id_grade", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Numeroidentifiantunique.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@numeroidentifiantUnique", DbType.Int32,4, varclsmilitaire.Numeroidentifiantunique));
else cmd.Parameters.Add(getParameter(cmd, "@numeroidentifiantUnique", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Matricule.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@matricule", DbType.Int32,4, varclsmilitaire.Matricule));
else cmd.Parameters.Add(getParameter(cmd, "@matricule", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Nom!=null )  cmd.Parameters.Add(getParameter(cmd, "@nom", DbType.String,30, varclsmilitaire.Nom));
else cmd.Parameters.Add(getParameter(cmd, "@nom", DbType.String,30, DBNull.Value));
if(varclsmilitaire.Postnom!=null )  cmd.Parameters.Add(getParameter(cmd, "@postnom", DbType.String,40, varclsmilitaire.Postnom));
else cmd.Parameters.Add(getParameter(cmd, "@postnom", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Prenom!=null )  cmd.Parameters.Add(getParameter(cmd, "@prenom", DbType.String,30, varclsmilitaire.Prenom));
else cmd.Parameters.Add(getParameter(cmd, "@prenom", DbType.String,30, DBNull.Value));
if(varclsmilitaire.Sexe!=null )  cmd.Parameters.Add(getParameter(cmd, "@sexe", DbType.String,1, varclsmilitaire.Sexe));
else cmd.Parameters.Add(getParameter(cmd, "@sexe", DbType.String,1, DBNull.Value));
if(varclsmilitaire.Etatcivil!=null )  cmd.Parameters.Add(getParameter(cmd, "@etatcivil", DbType.String,15, varclsmilitaire.Etatcivil));
else cmd.Parameters.Add(getParameter(cmd, "@etatcivil", DbType.String,15, DBNull.Value));
if(varclsmilitaire.Datenaissance.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@datenaissance", DbType.DateTime,8, varclsmilitaire.Datenaissance));
else cmd.Parameters.Add(getParameter(cmd, "@datenaissance", DbType.DateTime,8, DBNull.Value));
if(varclsmilitaire.Lieunaissance!=null )  cmd.Parameters.Add(getParameter(cmd, "@lieunaissance", DbType.String,100, varclsmilitaire.Lieunaissance));
else cmd.Parameters.Add(getParameter(cmd, "@lieunaissance", DbType.String,100, DBNull.Value));
if(varclsmilitaire.Nomprenompere!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomPrenomPere", DbType.String,100, varclsmilitaire.Nomprenompere));
else cmd.Parameters.Add(getParameter(cmd, "@nomPrenomPere", DbType.String,100, DBNull.Value));
if(varclsmilitaire.Nomprenommere!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomprenomMere", DbType.String,100, varclsmilitaire.Nomprenommere));
else cmd.Parameters.Add(getParameter(cmd, "@nomprenomMere", DbType.String,100, DBNull.Value));
if(varclsmilitaire.Modeidentification!=null )  cmd.Parameters.Add(getParameter(cmd, "@modeidentification", DbType.String,40, varclsmilitaire.Modeidentification));
else cmd.Parameters.Add(getParameter(cmd, "@modeidentification", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Numeropieceidentite!=null )  cmd.Parameters.Add(getParameter(cmd, "@numeropieceIdentite", DbType.String,40, varclsmilitaire.Numeropieceidentite));
else cmd.Parameters.Add(getParameter(cmd, "@numeropieceIdentite", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Detelivresonpieceidentite.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@detelivresonpieceidentite", DbType.DateTime,8, varclsmilitaire.Detelivresonpieceidentite));
else cmd.Parameters.Add(getParameter(cmd, "@detelivresonpieceidentite", DbType.DateTime,8, DBNull.Value));
if(varclsmilitaire.Nomemploiyer!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomemploiyer", DbType.String,100, varclsmilitaire.Nomemploiyer));
else cmd.Parameters.Add(getParameter(cmd, "@nomemploiyer", DbType.String,100, DBNull.Value));
if(varclsmilitaire.Addresseemploiyer!=null )  cmd.Parameters.Add(getParameter(cmd, "@addresseemploiyer", DbType.String,220, varclsmilitaire.Addresseemploiyer));
else cmd.Parameters.Add(getParameter(cmd, "@addresseemploiyer", DbType.String,220, DBNull.Value));
if(varclsmilitaire.Telbureau!=null )  cmd.Parameters.Add(getParameter(cmd, "@telbureau", DbType.String,13, varclsmilitaire.Telbureau));
else cmd.Parameters.Add(getParameter(cmd, "@telbureau", DbType.String,13, DBNull.Value));
if(varclsmilitaire.Adressepostal!=null )  cmd.Parameters.Add(getParameter(cmd, "@adressepostal", DbType.String,30, varclsmilitaire.Adressepostal));
else cmd.Parameters.Add(getParameter(cmd, "@adressepostal", DbType.String,30, DBNull.Value));
if(varclsmilitaire.Ville!=null )  cmd.Parameters.Add(getParameter(cmd, "@ville", DbType.String,40, varclsmilitaire.Ville));
else cmd.Parameters.Add(getParameter(cmd, "@ville", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Pays!=null )  cmd.Parameters.Add(getParameter(cmd, "@pays", DbType.String,40, varclsmilitaire.Pays));
else cmd.Parameters.Add(getParameter(cmd, "@pays", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Nationalite!=null )  cmd.Parameters.Add(getParameter(cmd, "@nationalite", DbType.String,40, varclsmilitaire.Nationalite));
else cmd.Parameters.Add(getParameter(cmd, "@nationalite", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Nomconjoin!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomconjoin", DbType.String,40, varclsmilitaire.Nomconjoin));
else cmd.Parameters.Add(getParameter(cmd, "@nomconjoin", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Email!=null )  cmd.Parameters.Add(getParameter(cmd, "@email", DbType.String,40, varclsmilitaire.Email));
else cmd.Parameters.Add(getParameter(cmd, "@email", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Tel!=null )  cmd.Parameters.Add(getParameter(cmd, "@tel", DbType.String,13, varclsmilitaire.Tel));
else cmd.Parameters.Add(getParameter(cmd, "@tel", DbType.String,13, DBNull.Value));
if(varclsmilitaire.Fax!=null )  cmd.Parameters.Add(getParameter(cmd, "@fax", DbType.String,40, varclsmilitaire.Fax));
else cmd.Parameters.Add(getParameter(cmd, "@fax", DbType.String,40, DBNull.Value));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int updateClsmilitaire (clsmilitaire varclsmilitaire){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("UPDATE militaire  SET id_cotitulairecompte=@id_cotitulairecompte,id_province=@id_province,id_unite=@id_unite,id_garnison=@id_garnison,id_implatation=@id_implatation,id_grade=@id_grade,numeroidentifiantUnique=@numeroidentifiantUnique,matricule=@matricule,nom=@nom,postnom=@postnom,prenom=@prenom,sexe=@sexe,etatcivil=@etatcivil,datenaissance=@datenaissance,lieunaissance=@lieunaissance,nomPrenomPere=@nomPrenomPere,nomprenomMere=@nomprenomMere,modeidentification=@modeidentification,numeropieceIdentite=@numeropieceIdentite,detelivresonpieceidentite=@detelivresonpieceidentite,nomemploiyer=@nomemploiyer,addresseemploiyer=@addresseemploiyer,telbureau=@telbureau,adressepostal=@adressepostal,ville=@ville,pays=@pays,nationalite=@nationalite,nomconjoin=@nomconjoin,email=@email,tel=@tel,fax=@fax  WHERE 1=1  AND id=@id ");
if(varclsmilitaire.Id_cotitulairecompte.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_cotitulairecompte", DbType.Int32,4, varclsmilitaire.Id_cotitulairecompte));
else cmd.Parameters.Add(getParameter(cmd, "@id_cotitulairecompte", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Id_province.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_province", DbType.Int32,4, varclsmilitaire.Id_province));
else cmd.Parameters.Add(getParameter(cmd, "@id_province", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Id_unite.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_unite", DbType.Int32,4, varclsmilitaire.Id_unite));
else cmd.Parameters.Add(getParameter(cmd, "@id_unite", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Id_garnison.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_garnison", DbType.Int32,4, varclsmilitaire.Id_garnison));
else cmd.Parameters.Add(getParameter(cmd, "@id_garnison", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Id_implatation.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_implatation", DbType.Int32,4, varclsmilitaire.Id_implatation));
else cmd.Parameters.Add(getParameter(cmd, "@id_implatation", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Id_grade.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_grade", DbType.Int32,4, varclsmilitaire.Id_grade));
else cmd.Parameters.Add(getParameter(cmd, "@id_grade", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Numeroidentifiantunique.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@numeroidentifiantUnique", DbType.Int32,4, varclsmilitaire.Numeroidentifiantunique));
else cmd.Parameters.Add(getParameter(cmd, "@numeroidentifiantUnique", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Matricule.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@matricule", DbType.Int32,4, varclsmilitaire.Matricule));
else cmd.Parameters.Add(getParameter(cmd, "@matricule", DbType.Int32,4, DBNull.Value));
if(varclsmilitaire.Nom!=null )  cmd.Parameters.Add(getParameter(cmd, "@nom", DbType.String,30, varclsmilitaire.Nom));
else cmd.Parameters.Add(getParameter(cmd, "@nom", DbType.String,30, DBNull.Value));
if(varclsmilitaire.Postnom!=null )  cmd.Parameters.Add(getParameter(cmd, "@postnom", DbType.String,40, varclsmilitaire.Postnom));
else cmd.Parameters.Add(getParameter(cmd, "@postnom", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Prenom!=null )  cmd.Parameters.Add(getParameter(cmd, "@prenom", DbType.String,30, varclsmilitaire.Prenom));
else cmd.Parameters.Add(getParameter(cmd, "@prenom", DbType.String,30, DBNull.Value));
if(varclsmilitaire.Sexe!=null )  cmd.Parameters.Add(getParameter(cmd, "@sexe", DbType.String,1, varclsmilitaire.Sexe));
else cmd.Parameters.Add(getParameter(cmd, "@sexe", DbType.String,1, DBNull.Value));
if(varclsmilitaire.Etatcivil!=null )  cmd.Parameters.Add(getParameter(cmd, "@etatcivil", DbType.String,15, varclsmilitaire.Etatcivil));
else cmd.Parameters.Add(getParameter(cmd, "@etatcivil", DbType.String,15, DBNull.Value));
if(varclsmilitaire.Datenaissance.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@datenaissance", DbType.DateTime,8, varclsmilitaire.Datenaissance));
else cmd.Parameters.Add(getParameter(cmd, "@datenaissance", DbType.DateTime,8, DBNull.Value));
if(varclsmilitaire.Lieunaissance!=null )  cmd.Parameters.Add(getParameter(cmd, "@lieunaissance", DbType.String,100, varclsmilitaire.Lieunaissance));
else cmd.Parameters.Add(getParameter(cmd, "@lieunaissance", DbType.String,100, DBNull.Value));
if(varclsmilitaire.Nomprenompere!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomPrenomPere", DbType.String,100, varclsmilitaire.Nomprenompere));
else cmd.Parameters.Add(getParameter(cmd, "@nomPrenomPere", DbType.String,100, DBNull.Value));
if(varclsmilitaire.Nomprenommere!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomprenomMere", DbType.String,100, varclsmilitaire.Nomprenommere));
else cmd.Parameters.Add(getParameter(cmd, "@nomprenomMere", DbType.String,100, DBNull.Value));
if(varclsmilitaire.Modeidentification!=null )  cmd.Parameters.Add(getParameter(cmd, "@modeidentification", DbType.String,40, varclsmilitaire.Modeidentification));
else cmd.Parameters.Add(getParameter(cmd, "@modeidentification", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Numeropieceidentite!=null )  cmd.Parameters.Add(getParameter(cmd, "@numeropieceIdentite", DbType.String,40, varclsmilitaire.Numeropieceidentite));
else cmd.Parameters.Add(getParameter(cmd, "@numeropieceIdentite", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Detelivresonpieceidentite.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@detelivresonpieceidentite", DbType.DateTime,8, varclsmilitaire.Detelivresonpieceidentite));
else cmd.Parameters.Add(getParameter(cmd, "@detelivresonpieceidentite", DbType.DateTime,8, DBNull.Value));
if(varclsmilitaire.Nomemploiyer!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomemploiyer", DbType.String,100, varclsmilitaire.Nomemploiyer));
else cmd.Parameters.Add(getParameter(cmd, "@nomemploiyer", DbType.String,100, DBNull.Value));
if(varclsmilitaire.Addresseemploiyer!=null )  cmd.Parameters.Add(getParameter(cmd, "@addresseemploiyer", DbType.String,220, varclsmilitaire.Addresseemploiyer));
else cmd.Parameters.Add(getParameter(cmd, "@addresseemploiyer", DbType.String,220, DBNull.Value));
if(varclsmilitaire.Telbureau!=null )  cmd.Parameters.Add(getParameter(cmd, "@telbureau", DbType.String,13, varclsmilitaire.Telbureau));
else cmd.Parameters.Add(getParameter(cmd, "@telbureau", DbType.String,13, DBNull.Value));
if(varclsmilitaire.Adressepostal!=null )  cmd.Parameters.Add(getParameter(cmd, "@adressepostal", DbType.String,30, varclsmilitaire.Adressepostal));
else cmd.Parameters.Add(getParameter(cmd, "@adressepostal", DbType.String,30, DBNull.Value));
if(varclsmilitaire.Ville!=null )  cmd.Parameters.Add(getParameter(cmd, "@ville", DbType.String,40, varclsmilitaire.Ville));
else cmd.Parameters.Add(getParameter(cmd, "@ville", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Pays!=null )  cmd.Parameters.Add(getParameter(cmd, "@pays", DbType.String,40, varclsmilitaire.Pays));
else cmd.Parameters.Add(getParameter(cmd, "@pays", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Nationalite!=null )  cmd.Parameters.Add(getParameter(cmd, "@nationalite", DbType.String,40, varclsmilitaire.Nationalite));
else cmd.Parameters.Add(getParameter(cmd, "@nationalite", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Nomconjoin!=null )  cmd.Parameters.Add(getParameter(cmd, "@nomconjoin", DbType.String,40, varclsmilitaire.Nomconjoin));
else cmd.Parameters.Add(getParameter(cmd, "@nomconjoin", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Email!=null )  cmd.Parameters.Add(getParameter(cmd, "@email", DbType.String,40, varclsmilitaire.Email));
else cmd.Parameters.Add(getParameter(cmd, "@email", DbType.String,40, DBNull.Value));
if(varclsmilitaire.Tel!=null )  cmd.Parameters.Add(getParameter(cmd, "@tel", DbType.String,13, varclsmilitaire.Tel));
else cmd.Parameters.Add(getParameter(cmd, "@tel", DbType.String,13, DBNull.Value));
if(varclsmilitaire.Fax!=null )  cmd.Parameters.Add(getParameter(cmd, "@fax", DbType.String,40, varclsmilitaire.Fax));
else cmd.Parameters.Add(getParameter(cmd, "@fax", DbType.String,40, DBNull.Value));
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsmilitaire.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int deleteClsmilitaire (clsmilitaire varclsmilitaire){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("DELETE FROM militaire  WHERE  1=1  AND id=@id ");
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsmilitaire.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}
 
  #endregion CLSMILITAIRE 
#region  CLSPERIODE
 public clsperiode getClsperiode(object intid){
 clsperiode  varclsperiode=new clsperiode();
try  {
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM periode WHERE id={0}",intid);
  using (IDataReader dr = cmd.ExecuteReader())  {
 if (dr.Read()){ 

 if(!dr["id"].ToString().Trim().Equals("")) varclsperiode.Id=int.Parse(dr["id"].ToString());
varclsperiode.Moisperiode= dr["moisperiode"].ToString();
 if(!dr["anneeperiode"].ToString().Trim().Equals("")) varclsperiode.Anneeperiode=int.Parse(dr["anneeperiode"].ToString());  }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return varclsperiode;
}

 public  List<clsperiode> getAllClsperiode(string criteria){
 List<clsperiode>  lstclsperiode=new List<clsperiode>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
 string sql="SELECT *  FROM periode  WHERE 1=1";
sql+="  OR   moisperiode LIKE '%"+criteria+"%'";
  cmd.CommandText = string.Format(sql);
  using (IDataReader dr = cmd.ExecuteReader()){

 clsperiode  varclsperiode=null;
 while (dr.Read()){ 

  varclsperiode=new clsperiode();
 if(!dr["id"].ToString().Trim().Equals("")) varclsperiode.Id=int.Parse(dr["id"].ToString());
varclsperiode.Moisperiode= dr["moisperiode"].ToString();
 if(!dr["anneeperiode"].ToString().Trim().Equals("")) varclsperiode.Anneeperiode=int.Parse(dr["anneeperiode"].ToString());
lstclsperiode.Add(varclsperiode);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsperiode;
}

 public  List<clsperiode> getAllClsperiode(){
 List<clsperiode>  lstclsperiode=new List<clsperiode>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM periode ");
  using (IDataReader dr = cmd.ExecuteReader()){

 clsperiode  varclsperiode=null;
 while (dr.Read()){ 

  varclsperiode=new clsperiode();
 if(!dr["id"].ToString().Trim().Equals("")) varclsperiode.Id=int.Parse(dr["id"].ToString());
varclsperiode.Moisperiode= dr["moisperiode"].ToString();
 if(!dr["anneeperiode"].ToString().Trim().Equals("")) varclsperiode.Anneeperiode=int.Parse(dr["anneeperiode"].ToString());
lstclsperiode.Add(varclsperiode);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsperiode;
}

 public int insertClsperiode(clsperiode varclsperiode){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("INSERT INTO periode ( moisperiode,anneeperiode ) VALUES (@moisperiode,@anneeperiode  )" );
if(varclsperiode.Moisperiode!=null )  cmd.Parameters.Add(getParameter(cmd, "@moisperiode", DbType.String,30, varclsperiode.Moisperiode));
else cmd.Parameters.Add(getParameter(cmd, "@moisperiode", DbType.String,30, DBNull.Value));
if(varclsperiode.Anneeperiode.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@anneeperiode", DbType.Int32,4, varclsperiode.Anneeperiode));
else cmd.Parameters.Add(getParameter(cmd, "@anneeperiode", DbType.Int32,4, DBNull.Value));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int updateClsperiode (clsperiode varclsperiode){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("UPDATE periode  SET moisperiode=@moisperiode,anneeperiode=@anneeperiode  WHERE 1=1  AND id=@id ");
if(varclsperiode.Moisperiode!=null )  cmd.Parameters.Add(getParameter(cmd, "@moisperiode", DbType.String,30, varclsperiode.Moisperiode));
else cmd.Parameters.Add(getParameter(cmd, "@moisperiode", DbType.String,30, DBNull.Value));
if(varclsperiode.Anneeperiode.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@anneeperiode", DbType.Int32,4, varclsperiode.Anneeperiode));
else cmd.Parameters.Add(getParameter(cmd, "@anneeperiode", DbType.Int32,4, DBNull.Value));
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsperiode.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int deleteClsperiode (clsperiode varclsperiode){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("DELETE FROM periode  WHERE  1=1  AND id=@id ");
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsperiode.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}
 
  #endregion CLSPERIODE 
#region  CLSPAIEMENT
 public clspaiement getClspaiement(object intid){
 clspaiement  varclspaiement=new clspaiement();
try  {
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM paiement WHERE id={0}",intid);
  using (IDataReader dr = cmd.ExecuteReader())  {
 if (dr.Read()){ 

 if(!dr["id"].ToString().Trim().Equals("")) varclspaiement.Id=int.Parse(dr["id"].ToString());
 if(!dr["id_militaire"].ToString().Trim().Equals("")) varclspaiement.Id_militaire=int.Parse(dr["id_militaire"].ToString());
 if(!dr["id_periode"].ToString().Trim().Equals("")) varclspaiement.Id_periode=int.Parse(dr["id_periode"].ToString());
varclspaiement.Typepaiement= dr["typePaiement"].ToString();
 if(!dr["montant"].ToString().Trim().Equals("")) varclspaiement.Montant=double.Parse(dr["montant"].ToString());
 if(!dr["nombreJour"].ToString().Trim().Equals("")) varclspaiement.Nombrejour=int.Parse(dr["nombreJour"].ToString());
 if(!dr["datetimePaiement"].ToString().Trim().Equals("")) varclspaiement.Datetimepaiement=DateTime.Parse(dr["datetimePaiement"].ToString());  }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return varclspaiement;
}

 public  List<clspaiement> getAllClspaiement(string criteria){
 List<clspaiement>  lstclspaiement=new List<clspaiement>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
 string sql="SELECT *  FROM paiement  WHERE 1=1";
sql+="  OR   typePaiement LIKE '%"+criteria+"%'";
  cmd.CommandText = string.Format(sql);
  using (IDataReader dr = cmd.ExecuteReader()){

 clspaiement  varclspaiement=null;
 while (dr.Read()){ 

  varclspaiement=new clspaiement();
 if(!dr["id"].ToString().Trim().Equals("")) varclspaiement.Id=int.Parse(dr["id"].ToString());
 if(!dr["id_militaire"].ToString().Trim().Equals("")) varclspaiement.Id_militaire=int.Parse(dr["id_militaire"].ToString());
 if(!dr["id_periode"].ToString().Trim().Equals("")) varclspaiement.Id_periode=int.Parse(dr["id_periode"].ToString());
varclspaiement.Typepaiement= dr["typePaiement"].ToString();
 if(!dr["montant"].ToString().Trim().Equals("")) varclspaiement.Montant=double.Parse(dr["montant"].ToString());
 if(!dr["nombreJour"].ToString().Trim().Equals("")) varclspaiement.Nombrejour=int.Parse(dr["nombreJour"].ToString());
 if(!dr["datetimePaiement"].ToString().Trim().Equals("")) varclspaiement.Datetimepaiement=DateTime.Parse(dr["datetimePaiement"].ToString());
lstclspaiement.Add(varclspaiement);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclspaiement;
}

 public  List<clspaiement> getAllClspaiement(){
 List<clspaiement>  lstclspaiement=new List<clspaiement>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM paiement ");
  using (IDataReader dr = cmd.ExecuteReader()){

 clspaiement  varclspaiement=null;
 while (dr.Read()){ 

  varclspaiement=new clspaiement();
 if(!dr["id"].ToString().Trim().Equals("")) varclspaiement.Id=int.Parse(dr["id"].ToString());
 if(!dr["id_militaire"].ToString().Trim().Equals("")) varclspaiement.Id_militaire=int.Parse(dr["id_militaire"].ToString());
 if(!dr["id_periode"].ToString().Trim().Equals("")) varclspaiement.Id_periode=int.Parse(dr["id_periode"].ToString());
varclspaiement.Typepaiement= dr["typePaiement"].ToString();
 if(!dr["montant"].ToString().Trim().Equals("")) varclspaiement.Montant=double.Parse(dr["montant"].ToString());
 if(!dr["nombreJour"].ToString().Trim().Equals("")) varclspaiement.Nombrejour=int.Parse(dr["nombreJour"].ToString());
 if(!dr["datetimePaiement"].ToString().Trim().Equals("")) varclspaiement.Datetimepaiement=DateTime.Parse(dr["datetimePaiement"].ToString());
lstclspaiement.Add(varclspaiement);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclspaiement;
}

 public int insertClspaiement(clspaiement varclspaiement){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("INSERT INTO paiement ( id_militaire,id_periode,typePaiement,montant,nombreJour,datetimePaiement ) VALUES (@id_militaire,@id_periode,@typePaiement,@montant,@nombreJour,@datetimePaiement  )" );
if(varclspaiement.Id_militaire.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_militaire", DbType.Int32,4, varclspaiement.Id_militaire));
else cmd.Parameters.Add(getParameter(cmd, "@id_militaire", DbType.Int32,4, DBNull.Value));
if(varclspaiement.Id_periode.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_periode", DbType.Int32,4, varclspaiement.Id_periode));
else cmd.Parameters.Add(getParameter(cmd, "@id_periode", DbType.Int32,4, DBNull.Value));
if(varclspaiement.Typepaiement!=null )  cmd.Parameters.Add(getParameter(cmd, "@typePaiement", DbType.String,30, varclspaiement.Typepaiement));
else cmd.Parameters.Add(getParameter(cmd, "@typePaiement", DbType.String,30, DBNull.Value));
if(varclspaiement.Montant.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@montant", DbType.Single,4, varclspaiement.Montant));
else cmd.Parameters.Add(getParameter(cmd, "@montant", DbType.Single,4, DBNull.Value));
if(varclspaiement.Nombrejour.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@nombreJour", DbType.Int32,4, varclspaiement.Nombrejour));
else cmd.Parameters.Add(getParameter(cmd, "@nombreJour", DbType.Int32,4, DBNull.Value));
if(varclspaiement.Datetimepaiement.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@datetimePaiement", DbType.DateTime,8, varclspaiement.Datetimepaiement));
else cmd.Parameters.Add(getParameter(cmd, "@datetimePaiement", DbType.DateTime,8, DBNull.Value));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int updateClspaiement (clspaiement varclspaiement){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("UPDATE paiement  SET id_militaire=@id_militaire,id_periode=@id_periode,typePaiement=@typePaiement,montant=@montant,nombreJour=@nombreJour,datetimePaiement=@datetimePaiement  WHERE 1=1  AND id=@id ");
if(varclspaiement.Id_militaire.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_militaire", DbType.Int32,4, varclspaiement.Id_militaire));
else cmd.Parameters.Add(getParameter(cmd, "@id_militaire", DbType.Int32,4, DBNull.Value));
if(varclspaiement.Id_periode.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@id_periode", DbType.Int32,4, varclspaiement.Id_periode));
else cmd.Parameters.Add(getParameter(cmd, "@id_periode", DbType.Int32,4, DBNull.Value));
if(varclspaiement.Typepaiement!=null )  cmd.Parameters.Add(getParameter(cmd, "@typePaiement", DbType.String,30, varclspaiement.Typepaiement));
else cmd.Parameters.Add(getParameter(cmd, "@typePaiement", DbType.String,30, DBNull.Value));
if(varclspaiement.Montant.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@montant", DbType.Single,4, varclspaiement.Montant));
else cmd.Parameters.Add(getParameter(cmd, "@montant", DbType.Single,4, DBNull.Value));
if(varclspaiement.Nombrejour.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@nombreJour", DbType.Int32,4, varclspaiement.Nombrejour));
else cmd.Parameters.Add(getParameter(cmd, "@nombreJour", DbType.Int32,4, DBNull.Value));
if(varclspaiement.Datetimepaiement.HasValue)  cmd.Parameters.Add(getParameter(cmd, "@datetimePaiement", DbType.DateTime,8, varclspaiement.Datetimepaiement));
else cmd.Parameters.Add(getParameter(cmd, "@datetimePaiement", DbType.DateTime,8, DBNull.Value));
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclspaiement.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int deleteClspaiement (clspaiement varclspaiement){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("DELETE FROM paiement  WHERE  1=1  AND id=@id ");
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclspaiement.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}
 
  #endregion CLSPAIEMENT 
#region  CLSPROFESSION
 public clsprofession getClsprofession(object intid){
 clsprofession  varclsprofession=new clsprofession();
try  {
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM profession WHERE id={0}",intid);
  using (IDataReader dr = cmd.ExecuteReader())  {
 if (dr.Read()){ 

 if(!dr["id"].ToString().Trim().Equals("")) varclsprofession.Id=int.Parse(dr["id"].ToString());
varclsprofession.Designation= dr["designation"].ToString();  }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return varclsprofession;
}

 public  List<clsprofession> getAllClsprofession(string criteria){
 List<clsprofession>  lstclsprofession=new List<clsprofession>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
 string sql="SELECT *  FROM profession  WHERE 1=1";
sql+="  OR   designation LIKE '%"+criteria+"%'";
  cmd.CommandText = string.Format(sql);
  using (IDataReader dr = cmd.ExecuteReader()){

 clsprofession  varclsprofession=null;
 while (dr.Read()){ 

  varclsprofession=new clsprofession();
 if(!dr["id"].ToString().Trim().Equals("")) varclsprofession.Id=int.Parse(dr["id"].ToString());
varclsprofession.Designation= dr["designation"].ToString();
lstclsprofession.Add(varclsprofession);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsprofession;
}

 public  List<clsprofession> getAllClsprofession(){
 List<clsprofession>  lstclsprofession=new List<clsprofession>();
try{
  if (conn.State != ConnectionState.Open) conn.Open();
  using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("SELECT *  FROM profession ");
  using (IDataReader dr = cmd.ExecuteReader()){

 clsprofession  varclsprofession=null;
 while (dr.Read()){ 

  varclsprofession=new clsprofession();
 if(!dr["id"].ToString().Trim().Equals("")) varclsprofession.Id=int.Parse(dr["id"].ToString());
varclsprofession.Designation= dr["designation"].ToString();
lstclsprofession.Add(varclsprofession);
 }
  }
  }
conn.Close();
  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return lstclsprofession;
}

 public int insertClsprofession(clsprofession varclsprofession){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("INSERT INTO profession ( designation ) VALUES (@designation  )" );
if(varclsprofession.Designation!=null )  cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, varclsprofession.Designation));
else cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, DBNull.Value));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int updateClsprofession (clsprofession varclsprofession){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("UPDATE profession  SET designation=@designation  WHERE 1=1  AND id=@id ");
if(varclsprofession.Designation!=null )  cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, varclsprofession.Designation));
else cmd.Parameters.Add(getParameter(cmd, "@designation", DbType.String,100, DBNull.Value));
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsprofession.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}

 public int deleteClsprofession (clsprofession varclsprofession){
int i=0;
try{
  if (conn.State != ConnectionState.Open) conn.Open();
 using (IDbCommand cmd = conn.CreateCommand())
{
  cmd.CommandText = string.Format("DELETE FROM profession  WHERE  1=1  AND id=@id ");
cmd.Parameters.Add(getParameter(cmd, "@id", DbType.Int32,4, varclsprofession.Id));
  i = cmd.ExecuteNonQuery();
  conn.Close();
}  }
 catch (Exception exc)
 {
     conn.Close();
     throw new Exception(exc.Message);
  }
 return i;
}
 
  #endregion CLSPROFESSION 



} //***fin class 

} //***fin namespace 
