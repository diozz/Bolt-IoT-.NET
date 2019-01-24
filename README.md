# Bolt IoT - A C# Library  

Interact with Bolt Cloud API easily using **C#**. API documentation is available [here](https://docs.boltiot.com/docs/introduction).

## Quickstart

Start by creating a `Bolt` object.

    Bolt myBolt = new Bolt("<API KEY>", "DEVICE ID>");

## GPIO Functions

### DigitalWrite

    Response response = await myBolt.DigitalWrite(pin, state);
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
    
### DigitalMultiWrite

    MultiPinConfig config = new MultiPinConfig();
    config.AddPinState(DigitalPins.D0, DigitalStates.High);
    config.AddPinState(DigitalPins.D1, DigitalStates.High);
    config.AddPinState(DigitalPins.D4, DigitalStates.Low);

    Response response = await myBolt.DigitalMultiWrite(config);
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
    
### DigitalRead

    Response response = await myBolt.DigitalRead(DigitalPins.D0);
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
        
### DigitalMultiRead
  
    List<string> pinsToRead = new List<string>
                              {
                                  DigitalPins.D0,
                                  DigitalPins.D1,
                                  DigitalPins.D2
                              };

    Response response = await DigitalMultiRead(pinsToRead);
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
        
### AnalogWrite

    Response response = await myBolt.AnalogWrite(AnalogPins.A0, "");
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
    
### AnalogMultiWrite

    MultiPinConfig config = new MultiPinConfig();
    config.AddPinState(DigitalPins.D0, DigitalStates.Low);
    config.AddPinState(DigitalPins.D1, DigitalStates.High);
    config.AddPinState(DigitalPins.D3, DigitalStates.Low);

    Response response = await myBolt.AnalogMultiWrite(config);
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
    
### AnalogRead

    Response response = await myBolt.DigitalRead(AnalogPins.A0);
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
        

## UART Functions
        
### SerialBegin

    Response response = await myBolt.SerialBegin(BaudRates.Baud9600);
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
    
### SerialWrite
    
    Response response = await myBolt.SerialWrite("<DATA>");
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
    
### SerialRead

Reads till (excluding) the specified character. `till` is the ASCII of requred character, that can range from 0 - 127.

    Response response = await myBolt.SerialRead(till);
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
    
Or, Read till a new line (`\n`) is encountered :

    Response response = await myBolt.SerialRead();
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
    
### SerialWriteRead
    
    Response response = await myBolt.SerialWriteRead("<DATA>", till);
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
    
`till` here, is optional. Reads upto newline (`\n`) by default.

## Utility Functions

### GetDeviceVersion

    Response response = await myBolt.GetDeviceVersion();
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());

### IsOnline

    Response response = await myBolt.IsOnline();
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());

### Restart

    Response response = await myBolt.Restart();
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
    
    
    
