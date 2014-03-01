#Logger

This C# logger provides a simple logging mechanism, intended to be just
slightly more useful than a generic standard output or file logging mechanism.

The logger can log (exclusively to or in combination with) either of the
following:
 - standard output
 - a file

The logger has severity rating levels, which permit the following ratings:
 - None
 - Debug (only logged in Debug builds)
 - Low
 - Medium
 - High

Additionally, permitted logging levels may be optionally specified, to
restrict certain levels of messages from being logged.
