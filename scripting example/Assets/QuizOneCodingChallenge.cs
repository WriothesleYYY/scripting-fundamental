using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    public int score = 0;
    public string Playername = "bonbon";
    public int Health = 100;
    // Start is called before the first frame update
    // spelled quizonechallenge wrong to Mr scott :D
    void Start()
    {
        increasescore();
        DecreaseHealth();
        PrintPlayername();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void DecreaseHealth()
    {
        Health -= 20;
    }

    private void increasescore()
    {
        score = +10;
    }

    private void PrintPlayername()
    {
        Debug.Log(Playername);
    }
}
