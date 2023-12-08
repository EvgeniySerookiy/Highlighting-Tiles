using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    [SerializeField] private Collider _collider;
    [SerializeField] private Material _currentMaterial;
    private float darkenAmount = 0.5f;
    

    private void Update()
    {
        
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (_collider.Raycast(ray, out RaycastHit hitInfo, 50f))
        {
            Color darkenColor = _currentMaterial.color * darkenAmount;
            _collider.GetComponent<Renderer>().material.color = darkenColor;
        }
        else
        {
            _collider.GetComponent<Renderer>().material = _currentMaterial;
        }
    }
}
