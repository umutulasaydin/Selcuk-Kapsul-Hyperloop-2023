# Selcuk-Kapsul-Hyperloop-2023

This project was made with the aim of 2023 Hyperloop Development Competition. This project includes the codes required for the communication of the pod with the control computer, the control computer interface, the autonomous driving control of the pod computer and the operation of subcomponents such as engine, brake and levitation. In the competition, full points were obtained from all reports and technical controls made in the name of communication and 1st place throughout the competition.

## Control Computer

The interface is made with c# and windows forms interface tool. TCP protocol is used for communication. The communication is bidirectional and commands are sent to the pod while telemetry data is received from the pod. While driving, data is stored and finally saved in csv version.

## Pod Computer

It provides communication between control computer and arduino. It checks the data coming from the control computer and the data from the arduinos and delivers them to the places of interest. It transmits the instant ping information to the control computer. It checks the disconnection and informs the arduino in case of connection loss or emergency.

## Arduino

There are 2 arduinos in the system. First, the main control arduino all moves according to the command from the control computer. The second arduino levitation arduino provides the levitation control and acts according to the command from the main control arduino. In general, distance control is done with encoder and optical reader in these arduinos. It provides control computer communication with UART. It is also controlled by rf remote control. There are various autonomous driving modes.
