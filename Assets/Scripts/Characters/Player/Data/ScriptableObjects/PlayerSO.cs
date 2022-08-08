using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinImpactMovementSystem
{
    [CreateAssetMenu(fileName = "PlayerSO", menuName = "GenshinImpactMovementSystem/PlayerSO", order = 0)]
    public class PlayerSO : ScriptableObject
    {
        [field: SerializeField] public PlayerGroundedData GroundedData {get; private set;}
    }
}
