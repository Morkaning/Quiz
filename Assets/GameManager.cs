using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using System.Text;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    [SerializeField]
    public List<string[]> questions_anwsers = new List<string[]>();

    public Team team1;
    public Team team2;
    public Team team3;
    public Team team4;

    [SerializeField]
    private Text question;

    [SerializeField]
    private Text ans1;
    [SerializeField]
    private Text ans2;
    [SerializeField]
    private Text ans3;
    [SerializeField]
    private Text ans4;

    private int current_index;

    private float timer = 5.0f;

    void Start()
    {
        current_index = 0;
        Load("Assets/data/test.txt");

        SetCurrentQuestion();
        SetCurrentAnswers();

        while (questions_anwsers.Count > 0 && questions_anwsers != null)
        { 
            timer -= Time.deltaTime;

            if (timer <= 0.0f)
            {
                  SetCurrentQuestion();
                  SetCurrentAnswers();
                  questions_anwsers.Remove(questions_anwsers.ElementAt(current_index));
                
            }
        }

        
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
            // Fin remplissage
       
          
            //for (int i = 0; i < questions_anwsers.Count; i++)
            //{

            //    Debug.Log(message: "Question" + i + " " + questions_anwsers.ElementAt(i));


            //}
        }
    }

    public void SetCurrentQuestion()
    {
        question.text = questions_anwsers.ElementAt(current_index)[0];
    }

    public void SetCurrentAnswers()
    {
       
        ans1.text = questions_anwsers.ElementAt(current_index)[1];
        ans2.text = questions_anwsers.ElementAt(current_index)[2];
        ans3.text = questions_anwsers.ElementAt(current_index)[3];
        ans4.text = questions_anwsers.ElementAt(current_index)[4];
    }

    

    public void Answer1BufferingTeam()
    {
        if (!team1.have_answered)
        {
            team1.answer = ans1.text;
            team1.have_answered = true;
            if (team1.answer == questions_anwsers.ElementAt(current_index)[5])
            {
                team1.correct_answer = true;
            }
            Debug.Log(team1.answer);
        }
        
    }

    public void Answer2BufferingTeam()
    {
        if (!team1.have_answered)
        {
            team1.answer = ans2.text;
            team1.have_answered = true;
            if (team1.answer == questions_anwsers.ElementAt(current_index)[5])
            {
                team1.correct_answer = true;
            }
            Debug.Log(team1.answer);
        }
    }

    public void Answer3BufferingTeam()
    {
        if (!team1.have_answered)
        {
            team1.answer = ans3.text;
            team1.have_answered = true;
            if (team1.answer == questions_anwsers.ElementAt(current_index)[5])
            {
                team1.correct_answer = true;
            }
            Debug.Log(team1.answer);
        }
    }

    public void Answer4BufferingTeam()
    {
        if (!team1.have_answered)
        {
            team1.answer = ans4.text;
            team1.have_answered = true;
            if (team1.answer == questions_anwsers.ElementAt(current_index)[5])
            {
                team1.correct_answer = true;
            }
            Debug.Log(team1.answer);
        }
    }


}
    





