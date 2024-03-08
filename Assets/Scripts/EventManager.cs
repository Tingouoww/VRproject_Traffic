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
   
    void Start()
    {
        this.RunningRedLight.AddListener(runningRed);
    }


    void runningRed()
    {
        Debug.Log("你闖紅燈了");
    }
}
