using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public InputField inputID;
    public InputField inputPW;

    string id;
    string pw;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStartBtn()
    {
        inputID = GetComponent<InputField>();
        inputPW = GetComponent<InputField>();

        id = inputID.text;
        pw = inputPW.text;

        StartCoroutine(ReqeustSignIn());



    }

    public void ChangeSceneToGameForTest()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ChangeSceneToSignUp()
    {
        SceneManager.LoadScene("SignUpScene");
    }

    IEnumerator ReqeustSignIn()
    {

        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        formData.Add(new MultipartFormDataSection("username", id));
        formData.Add(new MultipartFormDataSection("input_password", pw));

        UnityWebRequest webRequest = UnityWebRequest.Post("http://15.164.165.118:8000/", formData);

        yield return webRequest.SendWebRequest();

        if (webRequest.isNetworkError || webRequest.isHttpError)
        {
            Debug.Log(webRequest.error);
            // pop up??
        }
        else
        {
            Debug.Log("Form upload complete!");
            string result = webRequest.downloadHandler.text;
            Debug.Log("Response: " + result);
            SceneManager.LoadScene("GameScene");
        }

    }


}
