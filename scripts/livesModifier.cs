using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class livesModifier : MonoBehaviour
{
    public Text livesTargetText;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            statsManager.lives++;
            Debug.Log(statsManager.lives);
            livesTargetText.text = statsManager.lives.ToString();
        }

    }
}
