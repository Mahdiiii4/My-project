using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Spela : MonoBehaviour
{
    public void SpelaMenu()
    {
        SceneManager.LoadSceneAsync(1);
    }
}