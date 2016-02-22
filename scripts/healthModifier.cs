using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healthModifier : MonoBehaviour {
    public Text healthTargetText;



    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            statsManager.health++;
            Debug.Log (statsManager.health);
            healthTargetText.text = statsManager.health.ToString();
        }
	
	}
}
