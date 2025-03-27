### Arduino RGB Controller Application for Windows - .NET Project

## Overview
This Windows application allows users to control an RGB LED connected to an Arduino board via a serial connection. The application provides both static and dynamic lighting options, enabling users to manually set RGB values or choose from predefined colors.

## Features
- **Serial Communication**: Connects to the Arduino via a serial port and sends commands.
- **Predefined Colors**: Choose from colors like red, blue, green, yellow, purple, turquoise, sky blue, and orange.
- **Manual Color Control**: Adjust RGB values using sliders.
- **Dynamic Lighting Mode**: Enables automated color transitions with adjustable timing.
- **Connection Handling**: Handshaking mechanism ensures reliable communication with the Arduino.

## Requirements
- Windows OS
- .NET Framework (for running Windows Forms applications)
- Arduino board with an RGB LED
- USB cable for serial communication

## Installation
1. Clone or download the project files.
2. Open the solution in Visual Studio.
3. Build and run the application.

## Usage
### Connecting to Arduino
1. Select the correct **COM port** from the dropdown.
2. Set the **baud rate** (default: 9600).
3. Click **CONNECT** to establish communication with the Arduino.

### Controlling the RGB LED
#### **Static Lighting Mode**
- Adjust **Red, Green, and Blue** sliders to set a custom color.
- Click predefined color buttons to quickly switch colors.
- Use the **Turn Off All Colors** button to reset the LED.

#### **Dynamic Lighting Mode**
- Click **Dynamic Lighting** to enter automatic mode.
- Adjust the **speed slider** to set transition delay.
- Click **Start** to begin the color transitions.
- Click **Stop** to disable dynamic lighting.

### Disconnecting
- Click **DISCONNECT** to stop communication and turn off the LED.
- Closing the application automatically sends a shutdown command to the Arduino.

## Serial Commands Sent to Arduino
- `1024` – Turns off the LED.
- `255`, `511`, `767` – Corresponding color values.
- `9090` – Handshaking response.
- `10` – Stops dynamic lighting mode.
- Custom RGB values sent as numeric strings.

## Future Improvements
- Add support for saving custom colors.
- Implement a color picker for easier selection.
- Enhance UI responsiveness.

## License
This project is open-source and available under the MIT License.

