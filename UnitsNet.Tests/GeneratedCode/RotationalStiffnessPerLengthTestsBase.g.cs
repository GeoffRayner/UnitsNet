﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of RotationalStiffnessPerLength.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RotationalStiffnessPerLengthTestsBase
    {
        protected abstract double KilonewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter { get; }
        protected abstract double MeganewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter { get; }
        protected abstract double NewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilonewtonMetersPerRadianPerMeterTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonMetersPerRadianPerMeterTolerance { get { return 1e-5; } }
        protected virtual double NewtonMetersPerRadianPerMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void NewtonMeterPerRadianPerMeterToRotationalStiffnessPerLengthUnits()
        {
            RotationalStiffnessPerLength newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            AssertEx.EqualTolerance(KilonewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.KilonewtonMetersPerRadianPerMeter, KilonewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(MeganewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.MeganewtonMetersPerRadianPerMeter, MeganewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(NewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength.From(1, RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter).KilonewtonMetersPerRadianPerMeter, KilonewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength.From(1, RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter).MeganewtonMetersPerRadianPerMeter, MeganewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength.From(1, RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
        }

        [Fact]
        public void As()
        {
            var newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            AssertEx.EqualTolerance(KilonewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.As(RotationalStiffnessPerLengthUnit.KilonewtonMeterPerRadianPerMeter), KilonewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(MeganewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.As(RotationalStiffnessPerLengthUnit.MeganewtonMeterPerRadianPerMeter), MeganewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(NewtonMetersPerRadianPerMeterInOneNewtonMeterPerRadianPerMeter, newtonmeterperradianpermeter.As(RotationalStiffnessPerLengthUnit.NewtonMeterPerRadianPerMeter), NewtonMetersPerRadianPerMeterTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RotationalStiffnessPerLength newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength.FromKilonewtonMetersPerRadianPerMeter(newtonmeterperradianpermeter.KilonewtonMetersPerRadianPerMeter).NewtonMetersPerRadianPerMeter, KilonewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength.FromMeganewtonMetersPerRadianPerMeter(newtonmeterperradianpermeter.MeganewtonMetersPerRadianPerMeter).NewtonMetersPerRadianPerMeter, MeganewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(1, RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(newtonmeterperradianpermeter.NewtonMetersPerRadianPerMeter).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RotationalStiffnessPerLength v = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(2, (RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(3)-v).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(2, (RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(10)/5).NewtonMetersPerRadianPerMeter, NewtonMetersPerRadianPerMeterTolerance);
            AssertEx.EqualTolerance(2, RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(10)/RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(5), NewtonMetersPerRadianPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RotationalStiffnessPerLength oneNewtonMeterPerRadianPerMeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            RotationalStiffnessPerLength twoNewtonMetersPerRadianPerMeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(2);

            Assert.True(oneNewtonMeterPerRadianPerMeter < twoNewtonMetersPerRadianPerMeter);
            Assert.True(oneNewtonMeterPerRadianPerMeter <= twoNewtonMetersPerRadianPerMeter);
            Assert.True(twoNewtonMetersPerRadianPerMeter > oneNewtonMeterPerRadianPerMeter);
            Assert.True(twoNewtonMetersPerRadianPerMeter >= oneNewtonMeterPerRadianPerMeter);

            Assert.False(oneNewtonMeterPerRadianPerMeter > twoNewtonMetersPerRadianPerMeter);
            Assert.False(oneNewtonMeterPerRadianPerMeter >= twoNewtonMetersPerRadianPerMeter);
            Assert.False(twoNewtonMetersPerRadianPerMeter < oneNewtonMeterPerRadianPerMeter);
            Assert.False(twoNewtonMetersPerRadianPerMeter <= oneNewtonMeterPerRadianPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RotationalStiffnessPerLength newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            Assert.Equal(0, newtonmeterperradianpermeter.CompareTo(newtonmeterperradianpermeter));
            Assert.True(newtonmeterperradianpermeter.CompareTo(RotationalStiffnessPerLength.Zero) > 0);
            Assert.True(RotationalStiffnessPerLength.Zero.CompareTo(newtonmeterperradianpermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RotationalStiffnessPerLength newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            Assert.Throws<ArgumentException>(() => newtonmeterperradianpermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RotationalStiffnessPerLength newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => newtonmeterperradianpermeter.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            RotationalStiffnessPerLength a = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            RotationalStiffnessPerLength b = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            RotationalStiffnessPerLength v = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            Assert.True(v.Equals(RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1), RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(NewtonMetersPerRadianPerMeterTolerance)));
            Assert.False(v.Equals(RotationalStiffnessPerLength.Zero, RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(NewtonMetersPerRadianPerMeterTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RotationalStiffnessPerLength newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            Assert.False(newtonmeterperradianpermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RotationalStiffnessPerLength newtonmeterperradianpermeter = RotationalStiffnessPerLength.FromNewtonMetersPerRadianPerMeter(1);
            Assert.False(newtonmeterperradianpermeter.Equals(null));
        }
    }
}
