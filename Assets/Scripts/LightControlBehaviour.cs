using System;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class LightControlBehaviour : PlayableBehaviour
{
    [SerializeField]
    private Color color = Color.white;

    [SerializeField]
    private float intensity = 1f;

    [SerializeField]
    private float bounceIntensity = 1f;

    [SerializeField]
    private float range = 10f;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        var light = playerData as Light;

        if (light != null)
        {
            light.color = color;
            light.intensity = intensity;
            light.bounceIntensity = bounceIntensity;
            light.range = range;
        }
    }
}
