using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CollectableController : MonoBehaviour
{

    [SerializeField] private GameObject _collectablePrefab;
    [SerializeField] private Vector2 _collectablePos;

    [SerializeField] private Vector2 horizontalClamp;
    [SerializeField] private Vector2 verticalClamp;


    private void Start()
    {
        SpawnCollectable();
    }

    public void SpawnCollectable()
    {
        Instantiate(_collectablePrefab, SetPosition(), Quaternion.identity, transform);
    }

    private Vector2 SetPosition()
    {
        var x = Random.Range(horizontalClamp.x, horizontalClamp.y);
        var y = Random.Range(verticalClamp.x, verticalClamp.y);

        _collectablePos = new Vector2(x, y);
        return _collectablePos;
    }
}
