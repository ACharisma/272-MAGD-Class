using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class charismaModifier : MonoBehaviour
{
    public Text charismaTargetText;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            statsManager.charisma++;
            Debug.Log(statsManager.charisma);
            charismaTargetText.text = statsManager.charisma.ToString();
        }

    }
}

