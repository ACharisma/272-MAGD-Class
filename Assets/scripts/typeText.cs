using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class typeText : MonoBehaviour {

    public string myText = "Hello, what is your name?";
    public string myOtherText = "Happy Birthday, Merlin!";
    public float interLetterTime;
    public Text targetTypeText;
    public AudioSource chirper;

    public InputField userInputField;


	// Use this for initialization
	void Start () {
        StartCoroutine(addText(myText));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator addText(string text)
    {
        int textLength = text.Length;
        for(int i =0; i < textLength + 1; i++)
        {
            targetTypeText.text = text.Substring(0, i);
            chirper.Play();
            
            yield return new WaitForSeconds(interLetterTime);
            chirper.Stop();
        }
    }

    public void storeUserName()
    {
        statsManager.userName = userInputField.text;
        userInputField.text = "";
        StartCoroutine(addText("Hi " + statsManager.userName + " it's nice to meet you!"));   }

}
