using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeLine : MonoBehaviour
{
    public PlayableDirector playableDirector;
    

    // Start is called before the first frame update
    private void Awake()
    {
         
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(playableDirector != null)
            {
                Debug.Log("Entered");

                
                playableDirector.Play();
            }
            else
            {
                Debug.Log("No playableDirector detected.");
                
            }
        }
    }
}
