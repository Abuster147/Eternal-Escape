using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text textScore;

    // Update is called once per frame
    void Update()
    {
        textScore.text = player.localPosition.x.ToString("0") ;
    }
}
