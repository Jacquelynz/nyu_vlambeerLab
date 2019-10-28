using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonEvent : MonoBehaviour
{
    public void OnClick()
    {
        Pathmaker.Counter = 0;
        SceneManager.GetActiveScene();
        SceneManager.LoadScene("Scene1");
    }
}
