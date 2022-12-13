using UnityEngine;

public class HealthCollectable : MonoBehaviour, ICollectableBehaviour
{
    [SerializeField]
    private float _healthAmount;

    private HealthController _heathController;

    public void OnCollected()
    {
        _heathController.AddHealth(_healthAmount);
    }
}
