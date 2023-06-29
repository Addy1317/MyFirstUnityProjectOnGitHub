using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    [Header("UI Buttons")]
    [SerializeField] private Button buttonOne;
    [SerializeField] private Button buttonTwo;
    [SerializeField] private Button ButtonThree;

    [Header("Scene Name")]
    [SerializeField] private string scene1;
    [SerializeField] private string scene2;
    [SerializeField] private string scene3;

    // Start is called before the first frame update
    void Start()
    {
        buttonOne.onClick.AddListener(OnButtonOneClick);
        buttonTwo.onClick.AddListener(OnButtonTwoClick);
        ButtonThree.onClick.AddListener(OnButtonThreeClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnButtonOneClick()
    {
        Debug.Log("Button #1 clicked");
        SceneManager.LoadScene(scene1);
    }

    private void OnButtonTwoClick()
    {
        Debug.Log("Button #2 clicked");
        SceneManager.LoadScene(scene2);
    }

    private void OnButtonThreeClick()
    {
        Debug.Log("Button #3 clicked");
        SceneManager.LoadScene(scene3);
    }

    public void OnBackButtonClick()
    {
        Debug.Log("Back Button is Clicked");
        SceneManager.LoadScene(0);
    }
}
