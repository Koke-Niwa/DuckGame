using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    // 移動スピード
    public float CurrentMoveSpeed { get; set; } // 現在の限界スピード
    public float VelocityX { get; set; } // 現在のスピード

    // エネルギー
    public int MaxEnergyStorage { get; set; } // 最大エネルギー
    public int CurrentEnergy { get; set; } // エネルギー残量

    // 特殊能力の有無
    public bool CanFly { get; set; } // 飛行可能
}
