using UnityEngine;
using UnityEngine.UI;

namespace edu.ua.petiushka.masters
{
  public class Info : MonoBehaviour
  {
    //---------------------------------------------------------------------
    // Editor
    //---------------------------------------------------------------------

    [SerializeField] private Text _text;
    
    //---------------------------------------------------------------------
    // Internal
    //---------------------------------------------------------------------

    private Image _image;
    private float _timeLeft;
    private bool _active;
    private const float DISPLAY_TIME = 2f;
    
    //---------------------------------------------------------------------
    // Messages
    //---------------------------------------------------------------------

    private void Awake()
    {
      _image = GetComponent<Image>();
    }

    private void Update()
    {
      if (!_active) return;

      _timeLeft -= Time.deltaTime;
      if(_timeLeft < 0) TurnOff();
    }

    //---------------------------------------------------------------------
    // Public
    //---------------------------------------------------------------------

    public void DisplayText(string text)
    {
      _text.text = text;
      _image.color = new Color(0, 0, 0, 32f/255);
      _active = true;
      _timeLeft = DISPLAY_TIME;
    }
    
    //---------------------------------------------------------------------
    // Helpers
    //---------------------------------------------------------------------

    private void TurnOff()
    {
      _text.text = "";
      _image.color = new Color(0, 0, 0, 0);
      _active = false;
    }
  }
}