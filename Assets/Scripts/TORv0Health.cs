﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TORv0Health : EnemyHealth {

    bool vulnerable;

    /// <summary>
    /// Si es vulnerable, recibe daño y actualiza su barra de vida
    /// </summary>
    /// <param name="amount"></param>
    public override void TakeDamage(float amount)
    {
        if (vulnerable)
        {
            base.TakeDamage(amount);
            GameManager.instance.ui.UpdateBossHealth(curHealth, maxHealth);
        }
    }

    /// <summary>
    /// Hace vulnerable al boss según su estado
    /// </summary>
    public void MakeVulnerable(EnemyState est)
    {
        vulnerable = est == EnemyState.Stunned;
    } 
}
