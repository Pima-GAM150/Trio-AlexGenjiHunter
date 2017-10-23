using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Marble Pool", menuName = "Marble Pool")]
public class MarblePool : ScriptableObject
{
    public List<GameObject> pooledMarbles;
}