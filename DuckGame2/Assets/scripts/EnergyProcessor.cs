using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyProcessor
{
    public int CalculateDamage (int rawDamage, IShieldGenerator shield)
    {
        if (shield == null) return rawDamage;

        float damageToEnergy = (rawDamage - shield.ShieldStrength) / shield.ConversionEfficiency;
        return Mathf.Max(0, (int)damageToEnergy);
    }
}
