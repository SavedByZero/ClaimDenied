using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using Unity.VisualScripting;
using UnityEngine.UI;

public class SmartField : MonoBehaviour, IPointerClickHandler
{
    private bool _highlighted;
    private TextMeshProUGUI _field;
    public delegate void Highlighted(bool value, TextMeshProUGUI field);
    public Highlighted onHighlighted;


    public void Start()
    {
        _field = GetComponentInChildren<TextMeshProUGUI>();
      
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        _highlighted = !_highlighted;
        if (_field != null)
        {
            _field.color = _highlighted ? _field.color.ToDarkGreen() : Color.black;
            _field.fontStyle = _highlighted ? FontStyles.Bold : FontStyles.Normal;
              
            //_field.outlineWidth = _highlighted ? 20 : 0;
            //TODO: play highlight sound 
            onHighlighted?.Invoke(_highlighted, _field);
        }
        else
            Debug.LogError("no field for SmartField to find. ");

    }
}
