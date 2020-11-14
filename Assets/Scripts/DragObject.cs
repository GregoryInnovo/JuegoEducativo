using UnityEngine;
using UnityEngine.EventSystems;

public class DragObject : MonoBehaviour, IDragHandler
{
    public float z = 0.0f;
    public void OnDrag(PointerEventData data)
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = z;

        transform.position = Camera.main.ScreenToWorldPoint(mousePos);
    }


}
