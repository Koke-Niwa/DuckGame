using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShieldGenerator : IEquipment
{
    float ConversionEfficiency { get; } // 変換効率
    float ShieldStrength { get; } // シールド強度
}
