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
   
    void Start()
    {
        this.RunningRedLight.AddListener(runningRed);
    }


    void runningRed()
    {
        Debug.Log("�A�����O�F");
    }
}
