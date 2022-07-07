```c#
        public static Serilog.Core.Logger log = new LoggerConfiguration().WriteTo.File("d:\\log.txt").CreateLogger();

then

        log.Information("Some information");
```
