using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
/*
using MySql.Data.MySqlClient;
string mySqlConn = "server=localhost;user=root;database=mozi;password=";
MySqlConnection mySqlConnection = new MySqlConnection(mySqlConn);
mySqlConnection.Open();
MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
MySqlDataReader reader = cmd.ExecuteReader();
reader.Read();
*/

namespace premozi.Models
{
    public class Terem
    {
        [Key, NotNull, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get { return Id; } set { Id = value; } }
        [Required, NotNull]
        public int Ferohely { get { return Ferohely; } set { Ferohely = value; } }
        [Required, NotNull]
        public string Tipus { get { return Tipus; } set { Tipus = value; } }
        [Required, NotNull]
        public int Sorok { get { return Sorok; } set { Sorok = value; } }
        [Required, NotNull]
        public int Oszlopok { get { return Oszlopok; } set { Oszlopok = value; } }
        [Required, NotNull]
        public string Allapot { get { return Allapot; } set { Allapot = value; } }
        public string Megjegyzes { get { return Megjegyzes; } set { Megjegyzes = value; } }

        //public int[,] ulesek = new int[20, 20] { { 0 , 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
        /*public Terem()
        {

        }*/
        /*private void sort_seats_into_array(int[] x, int[] y, int[] value)
        {
            try
            {
                if (x.Length == 20 && y.Length == 20 && value.Length == 400)
                {
                    for(int ix = 0; ix < 20; ix++){
                        for(int iy = 0; iy< 20; iy++)
                        {
                            ulesek[x[ix], y[iy]] = value[ix * 20 + iy];
                        }
                    }
                }
                else
                {
                    throw new Exception("Failed to read and sort seats into array.");
                }
            }
            catch (Exception e)
            { 
                //Write something here later when you have a way to display error messages
            }
        }*/
    }

}
