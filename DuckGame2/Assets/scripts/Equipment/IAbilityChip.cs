using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAbilityChip : IEquipment
{
    float JumpForce { get; } // ジャンプ力
    int MaxJumpCount { get; } // n段ジャンプ用
    bool CanHover { get; }  // 飛行可能
}
