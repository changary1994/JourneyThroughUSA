using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ProgressBar : FillBar
{
    // Event to invoke when progress bar fills up
    private UnityEvent onProgressComplete;
    GameObject Score; 
    
    // Create a property to handle the slider's value
    public new float CurrentValue
    {
        get
        {
            return base.CurrentValue;
        }
        set
        {
            // If the value exceeds the max fill, invoke the completion function
            if (value >= slider.maxValue)
                onProgressComplete.Invoke();
            // Remove any overfill
            base.CurrentValue = value % slider.maxValue;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (onProgressComplete == null)
            onProgressComplete = new UnityEvent();
        onProgressComplete.AddListener(OnProgressComplete);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentValue = (GameObject.Find("Score").GetComponent<Scoring>().score) / 100;
    }

    void OnProgressComplete()
    {
        Debug.Log("Progress Complete");
    }
}
