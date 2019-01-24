# Bolt API Cloud - A C# Client Library

## Quickstart

Start by creating a `Bolt` object.

```c#
Bolt myBolt = new Bolt("<API KEY>", "DEVICE ID>");
```

## GPIO Functions

### DigitalWrite

```c#
Response response = await myBolt.DigitalWrite(DigitalPins.D0, DigitalStates.High);
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

### DigitalMultiWrite

```c#
MultiPinConfig config = new MultiPinConfig();
config.AddPinState(DigitalPins.D0, DigitalStates.High);
config.AddPinState(DigitalPins.D1, DigitalStates.High);
config.AddPinState(DigitalPins.D4, DigitalStates.Low);

Response response = await myBolt.DigitalMultiWrite(config);
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

### DigitalRead

```c#
Response response = await myBolt.DigitalRead(DigitalPins.D0);
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

### DigitalMultiRead

```c#
List<string> pinsToRead = new List<string>
                          {
                              DigitalPins.D0,
                              DigitalPins.D1,
                              DigitalPins.D2
                          };

Response response = await DigitalMultiRead(pinsToRead);
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

### AnalogWrite

```c#
Response response = await myBolt.AnalogWrite(AnalogPins.A0, 128);
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

### AnalogMultiWrite

```c#
MultiPinConfig config = new MultiPinConfig();
config.AddPinState(DigitalPins.D0, DigitalStates.Low);
config.AddPinState(DigitalPins.D1, DigitalStates.High);
config.AddPinState(DigitalPins.D3, DigitalStates.Low);

Response response = await myBolt.AnalogMultiWrite(config);
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

### AnalogRead

```c#
Response response = await myBolt.DigitalRead(AnalogPins.A0);
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

## UART Functions

### SerialBegin

```c#
Response response = await myBolt.SerialBegin(BaudRates.Baud9600);
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

### SerialWrite

```c#
Response response = await myBolt.SerialWrite("<DATA>");
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

### SerialRead

Reads till (excluding) the specified character. `till` is the ASCII of requred character, that can range from 0 - 127.

```c#
Response response = await myBolt.SerialRead(till);
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

Or, Read till a new line (`\n`) is encountered :

```c#
Response response = await myBolt.SerialRead();
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

### SerialWriteRead

```c#
Response response = await myBolt.SerialWriteRead("<DATA>", till);
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

`till` here, is optional. Reads upto newline (`\n`) by default.

## Utility Functions

### GetDeviceVersion

```c#
Response response = await myBolt.GetDeviceVersion();
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

### IsOnline

```c#
Response response = await myBolt.IsOnline();
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

### Restart

```c#
Response response = await myBolt.Restart();
MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
```

## Demo

Go through the sample project to have a better understanding of different usages. The project demostrates almost all the functions of the library. To run the demo, right click on the project, set it as startup project and press the run button.

![](https://i.imgur.com/ikxmccI.png)

## See Also

• [Bolt Cloud API Ddocumentation](https://docs.boltiot.com/docs/introduction).<br />
• [Official Python Client Library](https://github.com/Inventrom/bolt-api-python).<br />
• [Python Client Library Documentation](https://docs.boltiot.com/docs/python-library).
