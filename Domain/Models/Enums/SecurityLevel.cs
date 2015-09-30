using System;

namespace Domain.Models.Enums
{
    [Flags]
    public enum SecurityLevel
    {
        Open = 1,
        EyesOnly = 2
    }
}