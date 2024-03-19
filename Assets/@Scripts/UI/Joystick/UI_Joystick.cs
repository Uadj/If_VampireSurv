using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Joystick : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler
{

    [SerializeField]
    Image _background;

    [SerializeField]
    Image _handler;

    float _joysticRadius;
    Vector2 _touchPosition;
    Vector2 _moveDir;

    PlayerController _player;

    // Start is called before the first frame update
    void Start()
    {
        _joysticRadius = _background.gameObject.GetComponent<RectTransform>().sizeDelta.y / 2;
        _player = GameObject.Find("Slime_01").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 touchDir = (eventData.position - _touchPosition);

        float moveDist = Mathf.Min(touchDir.magnitude, _joysticRadius);

        _moveDir = touchDir.normalized;

        Vector2 newPosition = _touchPosition + _moveDir * moveDist;
        _handler.transform.position = newPosition;

        _player.MoveDir = _moveDir;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
     
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _background.transform.position = eventData.position;
        _handler.transform.position = eventData.position;
        _touchPosition = eventData.position;

        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _handler.transform.position = _touchPosition;
        _moveDir = Vector2.zero;

        _player.MoveDir = _moveDir;
    }


}