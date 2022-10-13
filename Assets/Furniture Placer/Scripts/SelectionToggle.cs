using UnityEngine;

public class SelectionToggle : MonoBehaviour
{
    [SerializeField]
    private Renderer _rendererToChange;

    [SerializeField]
    private Material _selectionMaterial;

    private Material _defaultMaterial;

    private void Awake()
    {
        _defaultMaterial = _rendererToChange.sharedMaterial;
    }

    private void OnEnable()
    {
        _rendererToChange.sharedMaterial = _selectionMaterial;
    }

    private void OnDisable()
    {
        _rendererToChange.sharedMaterial = _defaultMaterial;
    }
}
