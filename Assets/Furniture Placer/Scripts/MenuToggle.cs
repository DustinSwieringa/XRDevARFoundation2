using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuToggle : MonoBehaviour
{
    [SerializeField]
    private RectTransform _menuTransform;

    [SerializeField]
    private float _openPosition;
    [SerializeField]
    private float _closePosition;

    private bool _isOpen;

    private void Start()
    {
        Toggle();
    }

    public void Toggle()
    {
        _isOpen = !_isOpen;
        Vector2 targetPosition = new Vector2(0, _isOpen ? _openPosition : _closePosition);
        _menuTransform.DOAnchorPos(targetPosition, 0.5f);
    }
}
