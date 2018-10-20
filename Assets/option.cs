using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option : MonoBehaviour {
    public bool isCorrect;
    public GameObject optionA;
    public GameObject optionB;




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {

        if(isCorrect)
        {
            GetComponent<TextMesh>().color= Color.green;
            optionB.GetComponent<TextMesh>().color = Color.white;
            optionA.GetComponent<TextMesh>().color = Color.white;
        }
        else
        {
            GetComponent<TextMesh>().color = Color.red;
            if (optionA.GetComponent<option>().isCorrect)
            {
                optionA.GetComponent<TextMesh>().color = new Color(0.79f, 0.47f, 0.17f, 2.55f);
                optionB.GetComponent<TextMesh>().color =  Color.white;
            }
            else if (optionB.GetComponent<option>().isCorrect)
            {
                optionB.GetComponent<TextMesh>().color = new Color(0.79f, 0.47f, 0.17f, 2.55f);
                optionA.GetComponent<TextMesh>().color = Color.white;
            }

        }
    }
    }
