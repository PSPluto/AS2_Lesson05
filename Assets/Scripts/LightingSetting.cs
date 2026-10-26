using UnityEngine;

public class LightingSetting : MonoBehaviour
{
    [SerializeField] private float intensity = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.ambientIntensity = intensity;
        DynamicGI.UpdateEnvironment();

    }
}
