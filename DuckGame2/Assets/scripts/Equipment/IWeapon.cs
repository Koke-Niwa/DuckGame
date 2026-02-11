using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon : IEquipment
{
    void Attack();
    float AttackInterval { get; } // クールダウン
    int AnimationID { get; } // 武器固有のアニメーション
}
