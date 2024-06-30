using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetailBack : MonoBehaviour
{
    public void Back(){
        SceneManager.LoadScene("Start");
    }
}
