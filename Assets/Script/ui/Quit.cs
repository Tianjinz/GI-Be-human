using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void QuitGame() {
        Debug.Log("success");
        Application.Quit();
    }
}
