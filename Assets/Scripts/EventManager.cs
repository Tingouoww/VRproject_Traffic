using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    /*
     �����ƥ�޲z���A�޲z�Ҧ���q�ƥ�A�Ѩ�L����ե�
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
        Debug.Log("�A�����O�F");
    }

    void waitForPedestrians()
    {
        Debug.Log("�A��§����H");
    }
}
