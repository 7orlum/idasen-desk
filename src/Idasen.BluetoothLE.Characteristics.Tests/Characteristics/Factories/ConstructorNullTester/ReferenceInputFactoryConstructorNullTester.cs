﻿using Idasen.BluetoothLE.Characteristics.Characteristics.Factories ;
using Idasen.BluetoothLE.Common.Tests ;
using Microsoft.VisualStudio.TestTools.UnitTesting ;

namespace Idasen.BluetoothLE.Characteristics.Tests.Characteristics.Factories.ConstructorNullTester
{
    [ TestClass ]
    public class ReferenceInputFactoryConstructorNullTester
        : BaseConstructorNullTester < ReferenceInputFactory >
    {
        public override int NumberOfConstructorsPassed { get ; } = 1 ;
    }
}