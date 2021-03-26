using UnityEngine;
using UnityEngine.Timeline;

[TrackColor(1, 1, 0)]
[TrackBindingType(typeof(Light))]
[TrackClipType(typeof(LightControlClip))]
public class LightControlTrack : TrackAsset
{

}
