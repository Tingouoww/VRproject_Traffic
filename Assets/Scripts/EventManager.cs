using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    /*
     此為事件管理器，管理所有交通事件，供其他物件調用
     */

    public UnityEvent RunningRedLight;
    public UnityEvent WaitForPedestrians;


    void Start()
    {
        this.RunningRedLight.AddListener(runningRed);
        this.WaitForPedestrians.AddListener(waitForPedestrians);
    }


    void runningRed()
    {
        Debug.Log("你闖紅燈了");
    }

    void waitForPedestrians()
    {
        Debug.Log("你未禮讓行人");
    }
}
