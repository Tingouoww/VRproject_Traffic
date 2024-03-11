using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleTrigger : MonoBehaviour
{
    [SerializeField] private EventManager eventManager;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        eventManager.WaitForPedestrians.Invoke();
    }
}
