using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnergyReactor : IEquipment
{
    float MaxEnergy { get; } // 最大エネルギー
    float EnergyRegen { get; } // エネルギー残量
}
