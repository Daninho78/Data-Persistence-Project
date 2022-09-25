using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUi : MonoBehaviour

{
    public TMP_InputField inputUserName;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
        SaveManager.Instance.LoadBestScore();
    }

    public void Quit()
    {
        

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else

        Application.Quit();
#endif
        
    }

    public void InputName()
    {
        SaveManager.Instance.userName = inputUserName.text;
        
    }


}
