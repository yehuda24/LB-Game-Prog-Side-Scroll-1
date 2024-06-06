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
    }

    public void OnTrap()
    {
        ChangePlayerPosition(currentCheckpointPosition);
    }

    public void ChangePlayerPosition(Vector2 newPosition)
    {
        transform.position = newPosition;
    }



}
