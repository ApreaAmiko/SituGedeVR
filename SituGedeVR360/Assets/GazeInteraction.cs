using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GazeInteraction : MonoBehaviour
{
    public float gazeTime = 10f;
    private float timer;
    private bool gazeDat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gazeDat)
        {
            timer += Time.deltaTime;

            if(timer >= gazeTime)
            {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
            }
        }
    }

    public void PointerEnter()
    {
        gazeDat = true;
    }

    public void PointerExit()
    {
        gazeDat = false;
    }

    public void PointerDown()
    {
        Debug.Log("Show");
    }
}
