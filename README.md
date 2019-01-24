# Bolt IoT - A C# Library  

Interact with Bolt Cloud API easily using **C#**. API documentation is available [here](https://docs.boltiot.com/docs/introduction).

## Quickstart

Start by creating a `Bolt` object.

    Bolt myBolt = new Bolt("<API KEY>", "DEVICE ID>");

## GPIO Functions

### DigitalWrite

    Response response = await myBolt.DigitalWrite(pin, state);
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
    
### DigitalWriteMulti

    MultiPinConfig config = new MultiPinConfig();
    config.AddPinState(DigitalPins.D0, DigitalStates.High);
    config.AddPinState(DigitalPins.D1, DigitalStates.High);
    config.AddPinState(DigitalPins.D4, DigitalStates.Low);

    Response response = await myBolt.DigitalWriteMulti(config);
    MessageBox.Show("Opertion Succeeded: " + response.Success.ToString());
