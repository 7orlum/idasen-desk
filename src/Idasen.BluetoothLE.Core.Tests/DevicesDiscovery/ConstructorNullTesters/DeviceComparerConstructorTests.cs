﻿using Idasen.BluetoothLE.Core.DevicesDiscovery ;
using Microsoft.VisualStudio.TestTools.UnitTesting ;

namespace Idasen.BluetoothLE.Core.Tests.DevicesDiscovery.ConstructorNullTesters
{
    [ TestClass ]
    public class DeviceComparerConstructorTests
        : BaseConstructorNullTester < DeviceComparer >
    {
        public override int NumberOfConstructorsPassed { get ; } = 0 ;
    }
}