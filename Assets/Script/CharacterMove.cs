using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    GameObject gameObj;

    void Update()
    {
        gameObj = GameObject.FindWithTag("MainCamera");
        
        Debug.Log(gameObj.transform.position);
        transform.position = gameObj.transform.position;
    }

}