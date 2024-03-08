using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightTrigger : MonoBehaviour
{
    [SerializeField] private TrafficLightController controller;
    [SerializeField] private EventManager eventManager;
  
    //����i�JĲ�o���ɡA�P�_�O�_�����O�A�Y���O�A�եά��O�ƥ�
    private void OnTriggerEnter(Collider other)
    {
        if (controller != null)
        {
            if (controller.IsRed()) {
                
                eventManager.RunningRedLight.Invoke();
                Debug.Log(controller.IsRed());
            }
        }
    }
}
