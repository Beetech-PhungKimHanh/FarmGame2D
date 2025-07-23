using UnityEngine;

public class CropPlacer : MonoBehaviour
{
    public GameObject cropPrefab;
    public CropPlantedEvent cropPlantedEvent;

    private void OnEnable()
    {
        cropPlantedEvent.OnRaised += SpawnCrop;
    }

    private void OnDisable()
    {
        cropPlantedEvent.OnRaised -= SpawnCrop;
    }

    void SpawnCrop(Vector2 pos)
    {
        var newCrop = Instantiate(cropPrefab, pos, Quaternion.identity);
        newCrop.transform.SetParent(transform); // Set parent to CropPlacer
    
    }
}
