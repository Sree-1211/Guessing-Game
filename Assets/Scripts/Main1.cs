using TMPro;
using UnityEngine;

public class Main1 : MonoBehaviour
{
    int randomNumber;
    int playerNumber;

    //GUID hookup

    TMP_InputField InputAnswer;     //name of input field in the inspector
    TextMeshProUGUI TextResult;        //name of text field in the inspector
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomNumber = Random.Range(1, 100);
        Debug.Log("Random Number: " + randomNumber);

        //initialize playerNumber to 0
        playerNumber = 0;

        //hookup access

        InputAnswer =GameObject.Find("InputAnswer").GetComponent<TMP_InputField>();
        TextResult = GameObject.Find("TextResult").GetComponent<TextMeshProUGUI>();
    }

    public void SubmitClick()
    {
        playerNumber = int.Parse(InputAnswer.text);

        if (playerNumber < randomNumber)
        {
            TextResult.text = "Too low!";
        }
        else if (playerNumber > randomNumber)
        {
            TextResult.text = "Too high!";
        }
        else
        {
            TextResult.text = "Correct!";
        }   

    }
}   
