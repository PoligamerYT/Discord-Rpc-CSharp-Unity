using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DiscordRichPresence;

public class ExampleDiscordShutDown : MonoBehaviour
{
    void OnApplicationQuit()
    {
        DiscordRpc.Shutdown();
    }
}