using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour
{
    public int answer;
    public string randomOperator;
    public string rightansweroption1;

    public GameObject Question;
    public GameObject Option1;
    public GameObject Option2;
    public GameObject Option3;
    public GameObject newgame;

    // Use this for initialization
    public void OnMouseDown()
    {
        GenerateQuestion();
    }

    void Start()
    {
                GenerateQuestion();
    }

    // Update is called once per frame
    void Update()
    {


    }
  
    public void GenerateQuestion()
    {
        Option1.GetComponent<TextMesh>().color = Color.white;
        Option2.GetComponent<TextMesh>().color = Color.white;
        Option3.GetComponent<TextMesh>().color = Color.white;
        int a = Random.Range(0, 101);
        int b = Random.Range(0, 101);

        int operatorNumber = Random.Range(0, 3);

        if(operatorNumber == 0)
        {
            randomOperator="+";
            answer=a+b;
        }
        else if(operatorNumber==1)
        {
            randomOperator="-";
            answer=a-b;
        }
        else
        {
            randomOperator = "*";
            answer = a * b;
        }
        int option= Random.Range(0, 3);
        if (option == 0)
        {
            rightansweroption1 = answer.ToString();
            Option1.GetComponent<TextMesh>().text = answer.ToString();
            Option2.GetComponent<TextMesh>().text = (answer + (Random.Range(-2, 2) * 2 - 1)).ToString();
            Option3.GetComponent<TextMesh>().text = (answer + (Random.Range(-2, 2) * 3 - 2)).ToString();
            Option1.GetComponent<option>().isCorrect = true;
            Option2.GetComponent<option>().isCorrect = false;
            Option3.GetComponent<option>().isCorrect = false;
        }

        else if (option == 1)
        {
            rightansweroption1 = answer.ToString();
            Option1.GetComponent<TextMesh>().text = (answer + (Random.Range(-2, 2) * 2 - 1)).ToString();
            Option2.GetComponent<TextMesh>().text = answer.ToString();
            Option3.GetComponent<TextMesh>().text = (answer + (Random.Range(-2, 2) * 3 - 2)).ToString();
            Option1.GetComponent<option>().isCorrect = false;
            Option2.GetComponent<option>().isCorrect = true;
            Option3.GetComponent<option>().isCorrect = false;

        }
        else
        {
            rightansweroption1 = answer.ToString();
            Option1.GetComponent<TextMesh>().text = (answer + (Random.Range(-2, 2) * 2 - 1)).ToString();
            Option2.GetComponent<TextMesh>().text = (answer + (Random.Range(-2, 2) * 3 - 2)).ToString();
            Option3.GetComponent<TextMesh>().text = answer.ToString();
            Option1.GetComponent<option>().isCorrect = false;
            Option2.GetComponent<option>().isCorrect = false;
            Option3.GetComponent<option>().isCorrect = true;
        }
        Question.GetComponent<TextMesh>().text = a + " " + randomOperator + " " + b + "=?";
    }


}
