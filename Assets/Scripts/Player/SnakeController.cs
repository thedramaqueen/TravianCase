using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{

    [SerializeField] private CollectableController _collectableController;
    
    [SerializeField] private List<BodyPart> bodyParts = new List<BodyPart>();

    private int _lastActivePart = 0;

    private void Awake()
    {
        SetPartsID();
    }

    private void Update()
    {
        Follow();
    }

    private void Follow()
    {
        for (int i = bodyParts.Count - 1; i > 0; i--)
        {
            Transform currentObject = bodyParts[i].transform;
            Transform previousObject = bodyParts[i - 1].transform;

            // Calculate the new position using Lerp
            Vector3 targetPosition = previousObject.position;
            currentObject.position = Vector3.Lerp(currentObject.position, targetPosition, 10 * Time.deltaTime);
        }
    }

    private void SetPartsID()
    {
        for (int i = 0; i < bodyParts.Count; i++)
        {
            bodyParts[i].SetID(i);
        }
    }

    private void ActivateBodyPart()
    {
        if (bodyParts[_lastActivePart] == null)
            return;
        
        bodyParts[_lastActivePart].ActivatePart();
        _lastActivePart += 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        var collectable = other.GetComponent<Collectable>();
        if (collectable != null)
        {
            ActivateBodyPart();
            collectable.DestroyItself();
            _collectableController.SpawnCollectable();
        }
    }
}
