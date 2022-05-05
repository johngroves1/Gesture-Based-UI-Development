using UnityEngine;
using UnityEngine.EventSystems;

public class PinchScaleController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isDragging;
    private float currentScale;
    public float minScale, maxScale;
    private float temp;
    private float scalingRate = 2;
    private float time = 0.0166666f;

    private void Start()
    {
        currentScale = transform.localScale.x;

    }

    //Using Pointer Events to check if is touching screen
    public void OnPointerDown(PointerEventData eventData)
    {
        if (Input.touchCount == 1)
        {
            isDragging = true;

        }
    }

    //Using Pointer Events to check if not touching screen
    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
    }


    private void Update()
    {
        if (isDragging)
        {
            if (Input.touchCount == 2)
            {
                transform.localScale = new Vector3(currentScale, currentScale, 1f);
                float distance = Vector3.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
                if (temp > distance)
                {
                    if (currentScale < minScale)
                        return;
                    currentScale -= (time) * scalingRate;
                    AudioListener.volume = currentScale - 1;
                }

                else if (temp < distance)
                {
                    if (currentScale >= maxScale)
                        return;
                    currentScale += (time) * scalingRate;
                    AudioListener.volume = currentScale - 1;
                }

                temp = distance;
            }


        }

    }

}