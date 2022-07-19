using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

[System.Serializable]
public class BoxQuestionsAndAnswers 
{
    public string Questions;
    public Sprite[] Answers;
    public int correctAnswerID;

    public BoxQuestionsAndAnswers(string Questions, Sprite[] Answers, int correctAnswerID) {
        this.Questions = Questions;
        this.Answers = Answers;
        this.correctAnswerID = correctAnswerID;
    }
    public string QuestionsTitle
    {
        get { return Questions;  }
        set { Questions = value; }
    }
    public Sprite[] AnswersOption
    {
        get { return Answers;  }
        set { Answers = value; }
    }
    public int CorrectAnswerID
    {
        get { return correctAnswerID; }
        set { correctAnswerID = value; }
    }
}
