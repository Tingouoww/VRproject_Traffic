using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightTrigger : MonoBehaviour
{
    [SerializeField] private TrafficLightController controller;
    [SerializeField] private EventManager eventManager;
  
    //當物件進入觸發器時，判斷是否為紅燈，若紅燈，調用紅燈事件
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
