using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public CropPlantedEvent cropPlantedEvent; // ← gán qua Inspector

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // click chuột trái
        {
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            cropPlantedEvent.Raise(worldPos); // ← phát sự kiện
        }
    }
}
