﻿using System;

namespace GrpcConsul
{
    public static class ConsulConfig
    {
        public static readonly TimeSpan BlacklistPeriod = TimeSpan.FromMinutes(2);
        public static readonly TimeSpan CheckInterval = TimeSpan.FromSeconds(30);
        public static readonly TimeSpan CriticalInterval = TimeSpan.FromSeconds(60);
    }
}