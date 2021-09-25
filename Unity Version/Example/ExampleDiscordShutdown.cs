using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DiscordRichPresence;

public class ExampleDiscordShutdown : MonoBehaviour
{
    void OnApplicationQuit()
    {
        DiscordRpc.Shutdown();
    }
}