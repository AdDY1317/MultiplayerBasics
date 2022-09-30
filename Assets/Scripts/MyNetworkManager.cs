using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MyNetworkManager : NetworkManager
{
   public override void OnClientConnect()
    {
        base.OnClientConnect();

        Debug.Log("I Connected To A Server");
    }
}