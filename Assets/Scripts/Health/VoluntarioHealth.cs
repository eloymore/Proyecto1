﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoluntarioHealth : BossHealth {

    VoluntarioController controller;

    private void Start()
    {
        controller = GetComponent<VoluntarioController>();       
    }

    /// <summary>
    /// Si es vulnerable, recibe daño y actualiza su barra de vida
    /// </summary>
    public override void TakeDamage(float amount)
    {
        if (controller.BulletHit())
        {
            base.TakeDamage(amount);
        }
    }
}
