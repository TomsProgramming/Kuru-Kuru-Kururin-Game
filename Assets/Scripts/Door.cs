using UnityEngine;

public class Door : MonoBehaviour
{
    private enum DoorStatus
    {
        close,
        open
    }

    [SerializeField] private DoorStatus status;

    [SerializeField] private Vector2 defaultPosition;
    [SerializeField] private Vector2 targetPosition;

    void Awake()
    {
        status = DoorStatus.close;
        defaultPosition = transform.position;
    }

    void Update()
    {
        if (status == DoorStatus.open)
        {
            transform.position = Vector2.Lerp(transform.position, targetPosition, Time.deltaTime * 4);
        }
        else if (status == DoorStatus.close)
        {
            transform.position = Vector2.Lerp(transform.position, defaultPosition, Time.deltaTime * 4);
        }
    }

    public void OpenOrClose()
    {
        if (status == DoorStatus.close)
        {
            status = DoorStatus.open;
        }
        else if (status == DoorStatus.open)
        {
            status = DoorStatus.close;
        }

    }
    public void Open()
    {
        //status = DoorStatus.opens;
        //currentY = transform.position.y;
        //moveSpeed = (targetY - currentY) / targetTime;
    }

    public void Close()
    {
        //status = DoorStatus.closes;
        //currentY = transform.position.y;
        //moveSpeed = (defaultY - currentY) / targetTime;
    }
}
