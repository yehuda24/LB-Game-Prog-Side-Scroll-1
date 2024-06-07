using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionHandler : MonoBehaviour
{
    [SerializeField] Vector2 playerCurrentPosition;
    public Vector2 currentCheckpointPosition;
    public TransformData playerPositionData;
    private TriggerEvent playerTriggerEvent;

    void Start()
    {
        playerTriggerEvent = GetComponent<TriggerEvent>();
        currentCheckpointPosition = new Vector2(7f, 0f);
    }

    public void OnCheckPoint(GameObject col)
    {
        Vector2 newCheckpointPosition = col.transform.position;
        currentCheckpointPosition = newCheckpointPosition;
        SavePosition(currentCheckpointPosition);
    }

    public void OnTrap()
    {
        ChangePlayerPosition(currentCheckpointPosition);
    }

    public void OnFinish() 
    {
        playerPositionData.ResetData();
    }

    private void ChangePlayerPosition(Vector2 newPosition)
    {
        transform.position = newPosition;
    }

    private void LoadPosition() 
    {
        playerCurrentPosition = playerPositionData.position;
    }

    private void SavePosition(Vector2 newPosition) 
    {
        playerPositionData.position = newPosition;
    }

}
