# Fongwah Desktop UHF RFID Reader SDK (C#)

![UHF Reader Image](https://fongwahrfid.net/wp-content/uploads/2025/09/U6-CU-91-768x768.jpg)

## Overview
Official C# SDK and sample application for **Fongwah Desktop UHF RFID Readers**.
This project provides a complete Visual Studio solution (.NET Framework 3.5) to help developers integrate RFID functionalities into Windows applications.

## Compatible Hardware
* **U6-CU-91** (Desktop Writer/Reader) (https://fongwahrfid.net/rfid-reader-module/uhf-rfid-reader-u6-cu-91/)
* **U1-CU-71** (Desktop Writer/Reader) (https://fongwahrfid.net/rfid-reader-module/uhf-rfid-reader-u1-cu-71/)


## Features
Based on the provided `E7umf.DLL` library, this sample demonstrates:
* ✅ **USB Connectivity**: Default connection mode (Port 100) for plug-and-play ease.
* ✅ **Bulk Inventory**: Read multiple EPC tags simultaneously (Anti-collision).
* ✅ **Memory Access**: Read/Write data to **EPC, TID, USER, and Reserved** banks.
* ✅ **Security Features**: 
    * **Lock Tag**: Permanently lock specific memory banks (EPC/User/TID).
    * **Kill Tag**: Permanently deactivate a tag using a Kill Password.
* ✅ **Device Control**: Control the buzzer and LED via software.

## 🚀 Quick Start
1.  **Clone the Repo**: Download this repository or use `git clone`.
2.  **Open Solution**: Double-click `UHFtest.sln` in Visual Studio.
    * *Note: Since this is a legacy VS2008 project, newer Visual Studio versions may ask to "Retarget" the project. Click OK to accept.*
3.  **⚠️ Critical Step (DLL Placement)**: 
    * Ensure the file **`E7umf.DLL`** is present in your execution folder.
    * Usually: `\bin\Debug\` or `\bin\x86\Debug\`.
    * *If missing, the software will crash with "Unable to load DLL".*
4.  **Run & Connect**: 
    * Connect the reader via USB.
    * Click **"Test"** to verify connection (Default checks USB Mode).
    * Click **"Read multiple EPC"** to test bulk reading.

## 💻 Development Notes
* **Platform Target**: The project is pre-configured for **x86 (32-bit)** because `E7umf.DLL` is a 32-bit library. Do not change this to "Any CPU" or "x64", or the application will fail on 64-bit Windows.
* **USB vs COM**: The sample code defaults to `uhf_connect(100, ...)` which is the specific ID for USB mode. If you need to use a virtual COM port (e.g., COM3), you must modify the source code in `Form1.cs` to pass the port number instead of `100`.

## Troubleshooting
* **"DllNotFoundException" or "Unable to load DLL"?**
    * Make sure `E7umf.DLL` is in the same folder as the `.exe` file.
* **"BadImageFormatException"?**
    * Your project is running as 64-bit. Go to `Project Properties` -> `Build` -> `Platform Target` and select **x86**.
* **Reader not responding?**
    * Re-plug the USB cable.
    * Ensure the **Silicon Labs CP210x** or **CH340** driver is installed in Device Manager.

## Support
For full datasheets and protocols, visit [Fongwah Tech](https://fongwahrfid.net).
