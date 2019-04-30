using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;
using ComposePC;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class ComposePCTest
    {
        [TestMethod]
        public void should_have_correct_price()
        {
            IPC pc = new PCBuilder(
                    new I7(),
                    new Ram16Go()
                )
                .AddScreen(new SixteenInchesScreen())
                .AddMouse(new WirelessMouse())
                .Build();

            Check.That(pc.GetPrice()).Equals(300.0 + 130.0 + 135.0 + 80.0 + 26.80);
        }
    }
}
