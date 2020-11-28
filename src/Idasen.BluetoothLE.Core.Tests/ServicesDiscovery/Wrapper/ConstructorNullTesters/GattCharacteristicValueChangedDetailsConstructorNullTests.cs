﻿using Idasen.BluetoothLE.Core.ServicesDiscovery.Wrappers ;
using Idasen.BluetoothLE.Core.Tests.DevicesDiscovery.ConstructorNullTesters ;
using Microsoft.VisualStudio.TestTools.UnitTesting ;

namespace Idasen.BluetoothLE.Core.Tests.ServicesDiscovery.Wrapper.ConstructorNullTesters
{
    [ TestClass ]
    public class GattCharacteristicValueChangedDetailsConstructorNullTests
        : BaseConstructorNullTester < GattCharacteristicValueChangedDetails >
    {
        public override int NumberOfConstructorsPassed { get ; } = 1 ;
    }
}