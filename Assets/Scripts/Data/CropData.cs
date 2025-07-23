using UnityEngine;

[CreateAssetMenu(fileName = "CropData", menuName = Constants.SCRIPTABLE_OBJECTS_FOLDER + "Data/Crop Data")]
public class CropData : ScriptableObject
{
    public string cropId;
    public Sprite[] growthStages;
    public float[] stageDurations; // duration for each stage (in seconds)
    public Sprite harvestSprite;
}
