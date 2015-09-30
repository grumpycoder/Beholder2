using System;

namespace Domain.Models.Enums
{
    [Flags]
    public enum Status
    {
        Active = 1,
        InActive = 2,
        Review = 4,
        Deleted = 8,
        Approved = 16,
        Pending = 32,
        Disapproved = 64,
        New = 128
    }
}