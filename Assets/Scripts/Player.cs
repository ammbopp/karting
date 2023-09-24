using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    
    public float BestLapTime { get; private set; } = Mathf.Infinity;
    public float LastLapTime { get; private set; } = 0;
    public float CurrentLapTime { get; private set; } = 0;
    public int CurrentLap { get; private set; } = 0;
    
    private float lapTimerTimestamp;
    private int lastCheckpointPassed =0;
    
    private Transform checkpointsParent;
    private int checkpointCount;
    private int checkpointLayer;
    private PlayerMovement playerMovement;
    void Awake()
    {
        checkpointsParent = GameObject.Find("Checkpoints").transform;
        checkpointCount = checkpointsParent.childCount;
        checkpointLayer = LayerMask.NameToLayer("Checkpoint");
        playerMovement = GetComponent<PlayerMovement>();
    }
    void StartLap() {
        Debug.Log("StartLap!!!");
        CurrentLap++;
        lastCheckpointPassed = 1;
        lapTimerTimestamp = Time.time;
    }
    
    void EndLap(){
        LastLapTime = Time.time - lapTimerTimestamp;
        BestLapTime = Mathf.Min(LastLapTime, BestLapTime);
        Debug.Log("Endlap - LapTime was" + LastLapTime + "second");

        //SceneManager.LoadScene("End");
    }
    
    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.layer != checkpointLayer){
            return;
        }
        if(collider.gameObject.name == "1"){
            if(lastCheckpointPassed == checkpointCount){
                EndLap();
            }
            if(CurrentLap == 0 || lastCheckpointPassed == checkpointCount){
                StartLap();
            }
            return;
        }
        if(collider.gameObject.name == (lastCheckpointPassed+1).ToString()){
            lastCheckpointPassed++;
            
        }
    }
    
    void Update()
    {
        CurrentLapTime = lapTimerTimestamp > 0 ? Time.time - lapTimerTimestamp : 0;
    }
}