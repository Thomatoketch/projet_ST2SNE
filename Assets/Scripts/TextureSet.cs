using UnityEngine;

public class TextureSet : MonoBehaviour
{
    [System.Serializable]
    public class TextureAssignment
    {
        public string[] partName;              // Nom unique pour identifier la pièce (ex: "Bracelet")
        public Material textureToApply;       // Texture à appliquer à cette pièce
    }

    public TextureAssignment[] assignments;  // Liste des textures à appliquer
}