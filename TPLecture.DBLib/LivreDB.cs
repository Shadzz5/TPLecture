using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace TPLecture.DBLib
{
    public class LivreDB
    {
        private static String ConnectionString = "Server=localhost;Database=Lectures;Uid=root;";

        public static List<Livre> All()
        {


            MySqlConnection connection = new MySqlConnection(ConnectionString);

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = @"SELECT Identifiant, NombrePages, Titre, Edition, ISBN, DateEdition, DateLecture, Note, Resume, Commentaire
                FROM Livre;";


            MySqlDataReader reader = command.ExecuteReader();
            List<Livre> livres = new List<Livre>();
            Livre l = null;
            while (reader.Read())
            {
                l = new Livre();
                l.Identifiant = reader.GetInt32("Identifiant");
                l.ISBN = reader.GetString("ISBN");
                l.NombresPages = reader.GetInt32("NombrePages");
                l.Commentaire = reader.GetString("Commentaire");
                l.Titre = reader.GetString("Titre");
                l.Resume = reader.GetString("Resume");
                l.Edition = reader.GetString("Edition");
                l.DateLecture = reader.GetDateTime("DateLecture");
                l.DateEdition = reader.GetInt32("DateEdition");
                l.Note = reader.GetInt32("Note");
                livres.Add(l);

            }

            connection.Close();
            return livres;
        }

        public static Livre Find(int id)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = @"SELECT Identifiant, NombrePages, Titre, Edition, ISBN, DateEdition, DateLecture, Note, Resume, Commentaire
                FROM Livre
                WHERE Livre.Identifiant = @Identifiant;";

            command.Parameters.AddWithValue("@Identifiant", id);
            MySqlDataReader reader = command.ExecuteReader();
            Livre l = null;
            if (reader.Read())
            {
                l = new Livre();
                l.Identifiant = reader.GetInt32("Identifiant");
                l.ISBN = reader.GetString("ISBN");
                l.NombresPages = reader.GetInt32("NombrePages");
                l.Commentaire = reader.GetString("Commentaire");
                l.Titre = reader.GetString("Titre");
                l.Resume = reader.GetString("Resume");
                l.Edition = reader.GetString("Edition");
                l.DateLecture = reader.GetDateTime("DateLecture");
                l.DateEdition = reader.GetInt32("DateEdition");
                l.Note = reader.GetInt32("Note");


            }

            connection.Close();
            return l;

        }

        public static int Delete(int id)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = @"DELETE FROM Livre
                                  WHERE Livre.Identifiant = @Identifiant;";

            command.Parameters.AddWithValue("@Identifiant", id);
            int lecture = command.ExecuteNonQuery();
            connection.Close();
            return lecture;
        }
        public static int Update(Livre livre)
        {

            MySqlConnection connection = new MySqlConnection(ConnectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;


            command.CommandText = @"UPDATE Livre SET Identifiant = @Identifiant, NombrePages = @nbpages, 
                                  Titre = @titre, Edition = @edition, ISBN = @isbn, DateEdition = @dateedition, 
                                  DateLecture = @datelecture, Note = @note, Resume = @resume, Commentaire = @commentaire
                
                WHERE Livre.Identifiant = @Identifiant;";
            
            command.Parameters.AddWithValue("@Identifiant", livre.Identifiant);
            command.Parameters.AddWithValue("@nbpages", livre.NombresPages);
            command.Parameters.AddWithValue("@titre", livre.Titre);
            command.Parameters.AddWithValue("@edition", livre.Edition);
            command.Parameters.AddWithValue("@isbn", livre.ISBN);
            command.Parameters.AddWithValue("@dateedition", livre.DateEdition);
            command.Parameters.AddWithValue("@datelecture", livre.DateLecture);
            command.Parameters.AddWithValue("@note", livre.Note);
            command.Parameters.AddWithValue("@resume", livre.Resume);
            command.Parameters.AddWithValue("@commentaire", livre.Commentaire);
            int ajout = command.ExecuteNonQuery();
            connection.Close();
            return ajout;

        }
    }
}