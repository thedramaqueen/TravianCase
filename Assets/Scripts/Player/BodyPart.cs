using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class BodyPart : MonoBehaviour
{
    
    private int myId;
    public float followSpeed = 10;
    public void ActivatePart()
    {
        gameObject.SetActive(true);
    }

    public void Follow()
    {
        if (myId > 0)
        {
            
        }
    }

    public void SetID(int id)
    {
        myId = id;
    }
}
