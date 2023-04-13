﻿using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        
        // Subtract
        [Test]
        public void Subtract_ValidHou()
        {
            Assert.AreEqual(3, Program.Subtract("5", "2"));
            Assert.AreEqual(5, Program.Subtract("7", "2"));
            Assert.AreEqual(12, Program.Subtract("19", "7"));
        }

        [Test]
        public void Subtract_InvalidHou()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_NullHou()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("3", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }
        
        // Multiply
        [Test]
        public void Multiply_ValidHou()
        {
            Assert.AreEqual(3, Program.Multiply("2", "1.5"));
            Assert.AreEqual(14, Program.Multiply("7", "2"));
            Assert.AreEqual(12, Program.Multiply("2", "6"));
        }

        [Test]
        public void Multiply_InvalidHou()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_NullHou()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        // Divide
        [Test]
        public void Divide_ValidHou()
        {
            Assert.AreEqual(3, Program.Divide("6", "2"));
            Assert.AreEqual(3.5, Program.Divide("7", "2"));
            Assert.AreEqual(6, Program.Divide("12", "2"));
        }

        [Test]
        public void DivideHou()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_NullHou()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        // Power
        [Test]
        public void Power_ValidHou()
        {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(9, Program.Power("3", "2"));
            Assert.AreEqual(49, Program.Power("7", "2"));
        }

        [Test]
        public void PowerHou()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_NullHou()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
