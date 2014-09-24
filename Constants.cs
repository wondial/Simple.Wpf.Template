namespace WpfTemplate
{
    using System;

    public static class Constants
    {
        public static readonly TimeSpan Heartbeat = TimeSpan.FromSeconds(60);
        public static readonly TimeSpan UiFreeze = TimeSpan.FromMilliseconds(500);
        public static readonly TimeSpan UiFreezeTimer = TimeSpan.FromMilliseconds(333);

        public static readonly TimeSpan DiagnosticsIdleBuffer = TimeSpan.FromMilliseconds(999);
        public static readonly TimeSpan DiagnosticsCpuBuffer = TimeSpan.FromMilliseconds(750);
        public static readonly TimeSpan DiagnosticsSubscriptionDelay = TimeSpan.FromMilliseconds(7500);
    }
}
