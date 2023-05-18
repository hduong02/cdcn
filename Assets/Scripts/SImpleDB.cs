using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;

public class SimpleDB : MonoBehaviour
{

    private string dbName = "URI=file:Scoreboard.db";

    // Start is called before the first frame update
    void Start()
    {
        CreateDB();

    }

    public void CreateDB() {
        //Create the db connection
        using (var connection = new SqliteConnection(dbName)) {
            connection.Open();

            using (var command = connection.CreateCommand()){
                command.CommandText = "CREATE TABLE IF NOT EXISTS score (name VARCHAR(20), score INT);";
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    // [SerializeField]
    // void OnMouseDown()
    // {
    //      AddScore("player1",100);
    // }

    public void AddScore(string name, int score) {
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO score (name, score) VALUES ('"+name+"', '"+score+"');";
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}