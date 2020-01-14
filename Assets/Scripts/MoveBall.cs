using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBall : MonoBehaviour
{
    [SerializeField] private GameObject[] ballPositions;
    /*public GameObject ballPosTopLeft;
    public GameObject ballPosTopRight;
    public GameObject ballPosBottomLeft;
    public GameObject ballPosBottomRight;*/

    [SerializeField] private GameObject ball;

    public void MoveTheBall()
    {
        Debug.Log(Random.Range(0, 1));
    }


}
