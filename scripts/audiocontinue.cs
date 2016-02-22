using UnityEngine;
using System.Collections;

public class audiocontinue : MonoBehaviour {
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

	
}
