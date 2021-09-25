using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DiscordRichPresence;

public class ExampleDiscordshutdown : MonoBehaviour
{
    void OnApplicationQuit()
    {
        DiscordRpc.Shutdown();
    }
}
