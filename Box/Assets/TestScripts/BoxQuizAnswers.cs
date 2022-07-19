using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxQuizAnswers : MonoBehaviour
{
    public bool isCorrect = false;
    public BoxScript quizManager;
    public void Answer() {
        if(isCorrect) {
            quizManager.Correct();
            Debug.Log("Correct");
        } else {
            quizManager.Wrong();
            Debug.Log("Wrong");
        }
    }
}
