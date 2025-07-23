using UnityEngine;

public class CropController : MonoBehaviour
{
    public CropData cropData;

    private int stage = 0;
    private float timer = 0f;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateVisual();
    }

    void Update()
    {
        if (stage >= cropData.growthStages.Length - 1) return;

        timer += Time.deltaTime;
        if (timer >= cropData.stageDurations[stage])
        {
            stage++;
            timer = 0f;
            UpdateVisual();
        }
    }

    void UpdateVisual()
    {
        spriteRenderer.sprite = cropData.growthStages[stage];
    }

    public bool IsHarvestable() => stage >= cropData.growthStages.Length - 1;
}
