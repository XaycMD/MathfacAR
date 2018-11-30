using UnityEngine;
using UnityEngine.UI;

namespace edu.ua.petiushka.masters
{
  public class MapMode : MonoBehaviour
  {
    //---------------------------------------------------------------------
    // Editor
    //---------------------------------------------------------------------

    [Header("Panels")]
    [SerializeField] private GameObject _cabinetNumbers;
    [SerializeField] private GameObject _infoIcons;

    [Space]
    [Header("Button")]
    [SerializeField] private Image _imageIcon;
    [SerializeField] private Sprite _infoSprite;
    [SerializeField] private Sprite _numberSprite;

    //---------------------------------------------------------------------
    // Internal
    //---------------------------------------------------------------------

    private bool _info = true;

    //---------------------------------------------------------------------
    // Public
    //---------------------------------------------------------------------

    public void Toggle()
    {
      if (_info) ShowNumbers();
      else ShowInfo();

      _info = !_info;
    }

    //---------------------------------------------------------------------
    // Helpers
    //---------------------------------------------------------------------

    private void ShowInfo()
    {
      _cabinetNumbers.SetActive(false);
      _infoIcons.SetActive(true);
      _imageIcon.sprite = _infoSprite;
    }

    private void ShowNumbers()
    {
      _cabinetNumbers.SetActive(true);
      _infoIcons.SetActive(false);
      _imageIcon.sprite = _numberSprite;
    }
  }
}