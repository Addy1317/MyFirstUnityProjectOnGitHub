using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    [Header("Scene Name")]
    [SerializeField] private string MainScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnBackButtonClick()
    {
        Debug.Log("Back Button is Clicked");
        SceneManager.LoadScene(MainScene);
    }
}
