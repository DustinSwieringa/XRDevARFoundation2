using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class FurnitureManager : MonoBehaviour
{
    [SerializeField]
    private FurnitureData[] _furnitureData;

    [SerializeField]
    private Transform _contentTransform;

    [SerializeField]
    private FurnitureMenuOption _furnitureUIPrefab;

    [SerializeField]
    private ARPlacementInteractable _placementInteractable;

    private FurnitureMenuOption _currentMenuOption;

    private void Start()
    {
        foreach (FurnitureData data in _furnitureData)
        {
            FurnitureMenuOption menuOption = Instantiate(_furnitureUIPrefab, _contentTransform);
            menuOption.nameText.text = data.name;
            menuOption.iconImage.texture = data.furnitureIcon;

            //UIOptionAction action = new UIOptionAction(menuOption, data, this);
            //menuOption.button.onClick.AddListener(action.SelectFurniture);

            menuOption.button.onClick.AddListener(() => SelectFurniture(menuOption, data));
        }
    }

    private void SelectFurniture(FurnitureMenuOption newMenuOption, FurnitureData furnitureData)
    {
        if (_currentMenuOption != null)
            _currentMenuOption.backgroundImage.color = newMenuOption.backgroundImage.color;

        _currentMenuOption = newMenuOption;
        _placementInteractable.placementPrefab = furnitureData.furniturePrefab;

        newMenuOption.backgroundImage.color = Color.yellow;
    }

    //private class UIOptionAction
    //{
    //    private FurnitureMenuOption _menuOption;
    //    private FurnitureData _furnitureData;
    //    private FurnitureManager _manager;

    //    public UIOptionAction(FurnitureMenuOption newMenuOption, FurnitureData furnitureData, FurnitureManager manager)
    //    {
    //        _menuOption = newMenuOption;
    //        _furnitureData = furnitureData;
    //        _manager = manager;
    //    }

    //    public void SelectFurniture()
    //    {

    //    }
    //}
}
