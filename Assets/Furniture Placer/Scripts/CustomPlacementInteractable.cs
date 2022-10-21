using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class CustomPlacementInteractable : ARPlacementInteractable
{
    private List<RaycastResult> _raycastHits = new List<RaycastResult>();

    protected override bool CanStartManipulationForGesture(TapGesture gesture)
    {
        if (gestureInteractor.interactablesSelected.Count > 0)
            return false;

        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = gesture.startPosition;
        EventSystem.current.RaycastAll(eventData, _raycastHits);

        if (_raycastHits.Count > 0)
            return false;

        return base.CanStartManipulationForGesture(gesture);
    }
}
