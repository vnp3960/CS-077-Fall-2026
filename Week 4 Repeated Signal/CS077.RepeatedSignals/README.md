# CS077 Week 4 - Repeated Signals

This raw starter deliberately opens a plain window. Build the UI and code using the illustrated tutorial in Resources. It contains no Scan, STOP or reset implementation.

## My runner and Attention First connection

## Expected and observed tests
PING;PING;DISTRESS;STOP;PING	3	STOP received; the last PING is ignored.
STOP;PING	0	STOP first; no data packet processed.
PING;DISTRESS;PING	3	End of batch; no STOP needed.
(empty)	0	Empty batch; zero loop passes.
A;B;C;D;E;F;G;H	6	Safety limit; G and H are not processed.
## AI question, change, test result and next step

## Whiteboard and course collaboration evidence

## How to run and sources

Open CS077.RepeatedSignals.csproj in Visual Studio on Windows with .NET desktop development. Press F5.
