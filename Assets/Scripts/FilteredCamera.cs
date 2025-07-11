using UnityEngine;

public class FilteredCamera : MonoBehaviour
{
    [SerializeField] public LayerMask _visibleLayers;
    private Camera _cam;

    private void Start()
    {
        _cam = GetComponent<Camera>();
        if (_cam != null)
        {
            _cam.cullingMask = _visibleLayers;
        }
    }
}
