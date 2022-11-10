using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;


public class SQLiteScript : MonoBehaviour
{
    // The name of the DB
    private string dbName = "URI=file:UsersApp.db";

    void Start()
    {
        CreateDB();
    }

    public void CreateDB()
    {
        Debug.Log("Getting inside!");

        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using(var command = connection.CreateCommand())
            {
                //command.CommandText = "CREATE TABLE IF NOT EXISTS users (userid int NOT NULL AUTO_INCREMENT, username VARCHAR(15), avatarid int, experience int, pretestscore int, posttestscore int, PRIMARY KEY (userid))";
                command.CommandText = "CREATE TABLE IF NOT EXISTS users (userid INTEGER PRIMARY KEY, username VARCHAR(15), avatarid INT, experience INT, pretestscore INT, posttestscore INT)";
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    public void LoadUsersFromDB()
    {

        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM users";

                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        Debug.Log(reader["userid"] + ")- " + reader["username"] + " / " + reader["avatarid"]);

                    reader.Close();
                }
            }

            connection.Close();
        }
    }

    public void CreateNewUserApp(string username, int avatar) 
    {
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using(var command = connection.CreateCommand())
            {
                Debug.Log("Inside Success!");
                command.CommandText = "INSERT INTO users (username, avatarid, experience, pretestscore, posttestscore) VALUES ('" + username + "', " + avatar + ", 0, 0, 0)";
                command.ExecuteNonQuery();
            }

            connection.Close();
            Debug.Log("Create User Success!");
        }
    }

    public void Try(string name)
    {
        Debug.Log(name);
    }
    
}
