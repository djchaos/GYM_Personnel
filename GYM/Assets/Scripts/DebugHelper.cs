using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DebugHelper : MonoBehaviour
{
    public Text PlayerPos;
    public Text PlayerSpeed;
    GameObject Player;

    public bool GPP;

    void Start ()
    {
        Player = GameObject.Find("Player");
    }
	
	void Update ()
    {
        getPlayerPos();
    }

    void getPlayerPos()
    {
        if (GPP == true)
        {
            PlayerPos.text = "Pos:" +Player.transform.position.ToString();
        }
    }
}
