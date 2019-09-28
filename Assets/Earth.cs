using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    public QuestionCollector[] questions;
    public int maxQuestions = 3;
    void Start()
    {
        questions = new QuestionCollector[4];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            QuestionTemplate();
        }
    }

    public void QuestionTemplate() {
        questions[0].Questions = "What is your name?";
        questions[0].A = "Shanta";
        questions[0].B = "Shafayet";
        questions[0].C = "Rajib";
        questions[0].D = "Dimik";
        questions[0].correctAns = "Shanta";
        questions[1].Questions = "Which planet is for human?";
        questions[1].A = "Earth";
        questions[1].B = "Mars";
        questions[1].C = "Venus";
        questions[1].D = "Saturn";
        questions[1].correctAns = "Earth";
        questions[2].Questions = "From where do we receive Light?";
        questions[2].A = "Sun";
        questions[2].B = "Moon";
        questions[2].C = "Saturn";
        questions[2].D = "Pluto";
        questions[2].correctAns = "Sun";

        QuizManager.instance.maxQuestions = maxQuestions;
        QuizManager.instance.ReceiveQuiz(questions);
    }
}
