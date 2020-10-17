﻿using System.Collections.Generic;

namespace Idasen.BluetoothLE.Characteristics.Interfaces.Characteristics
{
    public interface IReferenceInput
        : ICharacteristicBase
    {
        IEnumerable<byte> Ctrl1 { get; }
    }
}