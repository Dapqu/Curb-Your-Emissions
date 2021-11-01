using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Test
{
    [Test]
    public void TickSpeed() {
        Assert.AreEqual(1, TimeTickSystem.TICK_TIMER_MAX);
    }

    [Test]
    public void GoldPerTick() {
        Assert.AreEqual(0, GameManager.goldPerTick);
    }

    [Test]
    public void EmissionPerTick() {
        Assert.AreEqual(0, GameManager.emissionPerTick);
    }

    [Test]
    public void PowerPerTick() {
        Assert.AreEqual(0, GameManager.powerPerTick);
    }

    [Test]
    public void GridMap() {
        int gridTileCount = 16 * 9;
        Assert.AreEqual(gridTileCount, GridManager.width * GridManager.height);
    }
}
