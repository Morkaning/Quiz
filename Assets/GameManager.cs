using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using System.Text;
using System;

public class GameManager : MonoBehaviour {
      
    public List<string[]> questions_anwsers = new List<string[]>();
    public Team team1;
    public Team team2;
    public Team team3;
    public Team team4;

    void Start()
    {

        Load("Assets/data/test.txt");

    }
    [MenuItem("Tools/Read file")]
    private void Load(string file_name)
    {

        // Remplissage de question / reponses depuis un fichier texte dans une liste de tableau de string
        // format de question ici : Question, reponse 1, reponse 2, reponse 3, reponse 4, bonne reponse
        StreamReader sr = new StreamReader(file_name, Encoding.Default);

        string line;

        using (sr)
        {

            do
            {
                line = sr.ReadLine();
                if (line != null)
                {
                    Debug.Log(line);
                    questions_anwsers.Add(line.Split(';'));
                }

            }
            while (line != null);
            sr.Close();


            //float timeLeft = 20.0f;

            //timeLeft -= Time.deltaTime;
            //while (timeLeft > 0) {

            //}
            //for (int i = 0; i < questions_anwsers.Count; i++)
            //{

            //    Debug.Log(message: "Question" + i + " " + questions_anwsers.ElementAt(i));


            //}
        }


    }

    private void AnswerBufferingTeam (Team teamx)
    {

    }
      
         
}



