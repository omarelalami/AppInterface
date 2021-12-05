using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace AppOperation
{
    class DataApp
    {    public DataApp()
        { }

        public void AjouteData(string txtprnm,string txtnom,string txtmet)
        {   
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = "Data Source=localhost; User Id=system; Password=omare;";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into person values(person_seq.nextval,'"+ txtprnm + "','" + txtnom + "','" +txtmet+"')";
            
            conn.Open();
           
            
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void ModifierData(string prnm ,string nom,string met,int id)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = "Data Source=localhost; User Id=system; Password=omare;";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update person set prenom = ' "+prnm+ "' , nom =' "+nom+" ' ,metier = ' "+met+" ' where idlist=' "+id+"'";
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void SupprimerData(int id)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = "Data Source=localhost; User Id=system; Password=omare;";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from person where idlist=' "+id+" ' ";
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }
        public int SelectID()
        {
            int id = 0;
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = "Data Source=localhost; User Id=system; Password=omare;";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select max(idlist) as mid from person";
         
            conn.Open();
             
            id = Convert.ToInt32(cmd.ExecuteScalar());
        
                conn.Close();
            return id;
            

        }
    }
}
