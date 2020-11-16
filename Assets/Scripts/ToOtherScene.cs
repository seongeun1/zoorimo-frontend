using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToOtherScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoBack()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void GoSolution()
    {
        SceneManager.LoadScene("QuizSolutionScene");
    }

    public void GoFeedQuiz()
    {
        SceneManager.LoadScene("FeedQuizScene");
    }
    public void GoMyPage()
    {
        SceneManager.LoadScene("MyPageScene");
    }

    public void GoStock()
    {
        SceneManager.LoadScene("StockScene");
    }
}
