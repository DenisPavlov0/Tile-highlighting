using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastForBridge : MonoBehaviour
{
    [SerializeField] private Collider _collider;
    [SerializeField] private Renderer _renderer;
    
    private Color _originalColor;

    private void Awake()
    {
        _originalColor = _renderer.material.color;
    }

    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (_collider.Raycast(ray, out RaycastHit hitInfo,20f)) 
        {
            _renderer.material.color = Color.grey;
        }
        else
        {
            _renderer.material.color = _originalColor;
        }
        
    }
}
