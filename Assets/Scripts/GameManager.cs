using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    GameObject playerStatus;
    string user_pk;
    // Start is called before the first frame update
    void Start()
    {
        playerStatus = GameObject.Find("PlayerStatus");
        user_pk = playerStatus.GetComponent<StatusManagerStart>().user_pk;
        Debug.Log("user_pk:  " + user_pk);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
