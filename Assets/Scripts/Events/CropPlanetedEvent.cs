using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName="CropPlantedEvent", menuName = Constants.SCRIPTABLE_OBJECTS_FOLDER + "Events/CropPlantedEvent")]
public class CropPlantedEvent : ScriptableObject
{
 public UnityAction<Vector2> OnRaised;

    public void Raise(Vector2 pos)
    {
        OnRaised?.Invoke(pos);
    }
}
