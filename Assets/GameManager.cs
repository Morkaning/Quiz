using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using System.Text;
using System;

public class GameManager : MonoBehaviour {
    public List<string[]> questions_anwsers = new List<string[]>(5);
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
       

            StreamReader sr = new StreamReader(file_name, Encoding.Default);
            Debug.Log("Je suis la");
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
                for (int i = 0; i < questions_anwsers.Count; i++)
                {
                    
                    Debug.Log(message: "Question" + i + " " + questions_anwsers.ElementAt(i));
                    

                }
            }
        
      
    }


}
