using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreModifier : MonoBehaviour
{
    public Text scoreTargetText;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            statsManager.score++;
            Debug.Log(statsManager.score);
            scoreTargetText.text = statsManager.score.ToString();
        }

    }
}
