using UnityEngine;
using System.Collections;

public class UIContol : MonoBehaviour
{

    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
