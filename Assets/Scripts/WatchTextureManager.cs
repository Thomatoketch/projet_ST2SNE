using UnityEngine;
using System.Collections.Generic;

public class WatchTextureManager : MonoBehaviour
{
    [System.Serializable]
    public class WatchPart
    {
        public string partName;        // Nom (doit correspondre à celui du TextureSet)
        public Renderer targetRenderer;
    }

    public WatchPart[] parts; // Pièces de la montre

    private Dictionary<string, Renderer> partLookup;

    private void Awake()
    {
        partLookup = new Dictionary<string, Renderer>();
        foreach (var part in parts)
        {
            partLookup[part.partName] = part.targetRenderer;
        }
    }

    public void ApplyTextures(TextureSet textureSet)
    {
        foreach (var assign in textureSet.assignments)
        {
            foreach (var partName in assign.partName)
            {
                if (partLookup.TryGetValue(partName, out Renderer rend))
                {
                    rend.material = assign.textureToApply;
                }
            }
        }
    }
}
