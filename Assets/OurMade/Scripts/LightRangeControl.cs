using UnityEngine;

public class LightRangeControl : MonoBehaviour
{
    private Light lightComponent;
    public float maxRange = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lightComponent = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, maxRange);
        if (hitInfo.collider != null)
        {
            float distance = hitInfo.distance;
            lightComponent.range = distance + 0.5f;
        }
        else
        {
            lightComponent.range = maxRange;
        }
    }
}
