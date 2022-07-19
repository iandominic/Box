using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class BoxScript : MonoBehaviour
{
    public List<BoxQuestionsAndAnswers> QnA;
    public List<BoxQuestionsAndAnswers> bQnA = new List<BoxQuestionsAndAnswers>();
    public GameObject[] options;
    public Sprite[] spriteChoice;
    public GameObject boxQuizPanel;
    public GameObject trueOrFalse;
    public GameObject dragBodyPart;
    public GameObject StudyTable;
    public GameObject pe;
    public int score;
    public int currentQuestion;
    int totalQuestions = 0;
    public TMP_Text questionText;
    public TMP_Text scoreText;
    public Button[] boxButtons;
    public Animator boxChoiceAnim;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Restart();
        anim = scoreText.GetComponent<Animator>();
        totalQuestions = bQnA.Count;
        generateQuestions();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score + "/" + totalQuestions;       
    }
    public void Correct() {
        bQnA.RemoveAt(currentQuestion);
        generateQuestions();
        score += 1;
        anim.Play("BoxCorrect", -1, 0f);
    }
    public void Wrong() {
        bQnA.RemoveAt(currentQuestion);
        generateQuestions();
        anim.Play("BoxScore", -1, 0f);
        Debug.Log("Wrong Answer");
    }
    void SetAnswers() {
        for(int i = 0; i < options.Length; i++) {
            options[i].GetComponent<BoxQuizAnswers>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Image>().sprite = bQnA[currentQuestion].AnswersOption[i];

            if(bQnA[currentQuestion].CorrectAnswerID == i+1) {
                options[i].GetComponent<BoxQuizAnswers>().isCorrect = true;
            }
        }
    }
    public void generateQuestions() {
        if(bQnA.Count > 0) {
            currentQuestion = Random.Range(0, bQnA.Count);
            questionText.text = bQnA[currentQuestion].QuestionsTitle;
            CloseBox();
            SetAnswers();
        }
        else {
            Debug.Log("Out of questions");
            // mathQuizScreen.gameObject.SetActive(false);
        }
    }
    public void OpenBox() {
        boxButtons[1].gameObject.SetActive(true);
        boxButtons[0].gameObject.SetActive(false);

        boxChoiceAnim.Play("ChoicesBoxAnim", -1, 0f);
    }
    void CloseBox() {
        boxButtons[1].gameObject.SetActive(false);
        boxButtons[0].gameObject.SetActive(true);

        boxButtons[1].interactable = true;
        boxChoiceAnim.Play("ChoiceIdleBoxAnim", -1, 0f);
    }
    void Restart() {
        bQnA.Add(new BoxQuestionsAndAnswers("Which is the ear", new Sprite[2]{spriteChoice[0], spriteChoice[1]}, 2));
         bQnA.Add(new BoxQuestionsAndAnswers("Which is the ear", new Sprite[2]{spriteChoice[0], spriteChoice[1]}, 2));
          bQnA.Add(new BoxQuestionsAndAnswers("Which is the ear", new Sprite[2]{spriteChoice[0], spriteChoice[1]}, 2));
           bQnA.Add(new BoxQuestionsAndAnswers("Which is the ear", new Sprite[2]{spriteChoice[0], spriteChoice[1]}, 2));
            bQnA.Add(new BoxQuestionsAndAnswers("Which is the ear", new Sprite[2]{spriteChoice[0], spriteChoice[1]}, 2));
             bQnA.Add(new BoxQuestionsAndAnswers("Which is the ear", new Sprite[2]{spriteChoice[0], spriteChoice[1]}, 2));
              bQnA.Add(new BoxQuestionsAndAnswers("Which is the ear", new Sprite[2]{spriteChoice[0], spriteChoice[1]}, 2));
               bQnA.Add(new BoxQuestionsAndAnswers("Which is the ear", new Sprite[2]{spriteChoice[0], spriteChoice[1]}, 2));
                bQnA.Add(new BoxQuestionsAndAnswers("Which is the ear", new Sprite[2]{spriteChoice[0], spriteChoice[1]}, 2));
                 bQnA.Add(new BoxQuestionsAndAnswers("Which is the ear", new Sprite[2]{spriteChoice[0], spriteChoice[1]}, 2));
                  bQnA.Add(new BoxQuestionsAndAnswers("Which is the ear", new Sprite[2]{spriteChoice[0], spriteChoice[1]}, 2));
    }
}
