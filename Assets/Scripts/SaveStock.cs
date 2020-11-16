using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveStock : MonoBehaviour
{

    public GameObject p;
    // Start is called before the first frame update
    void Start()
    {
        p.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SaveBtn()
    {
        p.SetActive(true);
    }

    public void YesSaveBtn()
    {
        if (p.gameObject.activeSelf)
        {

            p.SetActive(false);

        }

        Debug.Log("저장할거다");
        SceneManager.LoadScene("GameScene");
    }

    public void NoSaveBtn()
    {
        if (p.gameObject.activeSelf)
        {

            p.SetActive(false);

        }
    }

}
