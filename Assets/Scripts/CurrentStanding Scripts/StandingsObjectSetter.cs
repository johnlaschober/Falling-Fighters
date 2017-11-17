﻿using UnityEngine;
using System.Collections;

public class StandingsObjectSetter : MonoBehaviour
{

    ModelMaterialIdentifier info;
    int playerNum;
    GameObject playerObject;

    void Awake()
    {
        info = GameObject.Find("AirConsole").GetComponent<ModelMaterialIdentifier>();
        playerNum = name[6] - 48;

        SetObject();
    }

    void Start()
    {

    }

    public void SetObject()
    {

        GameObject playerAnimator;
        try
        {
            playerAnimator = (GameObject)Instantiate(info.playerStandingObjects[playerNum - 1], new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.73f), this.transform.rotation);
        }
        catch
        {
            playerAnimator = null;
        }
        playerAnimator.transform.parent = this.gameObject.transform;

    }
}
