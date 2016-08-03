# Intelligent-Robotic-Arm
Intelligent Robotic Arm is a 5 dof  autonomous arm with webcam attached to it for vision. Check it here https://mayurvarma14.wordpress.com/2014/08/01/mayur-intelligent-robotic-arm/



This is an Intelligent Robotic Arm with 5 degree of freedom for control.It has a webcam attached for autonomous control.The Robotic arm searches for the Object autonomously and if it detects the object,it tries to pickup the object by estimating the position of object in each frame. Once it has reached the object it picks up the Object.For this i have used Image based servo control technology.It can detect different color objects and sort the objects based on colors without any human intervention.


![enter image description here](https://mayurvarma14.files.wordpress.com/2014/07/11.jpg)




**Mode**

----------
It has 2 modes to operate 
1. Simple Mode
2. Autonomous Mode


**Simple Mode**

----------

For making the program for microcontroller i have used Avr Studio and for USB interface application i have used Visual C#.

The software has the functionality to program the robotic arm and allow it to run the sequence of steps.

Each servo motors can be controlled individually  and it also include Inverse Kinematics which allows X,Y,Z parameter for controlling  the robotic arm easily.

User can save the script and load the script created by them.

![enter image description here](https://mayurvarma14.files.wordpress.com/2014/07/gui1.jpg)

**Autonomous Mode**

----------

It has autonomous mode and it can detect objects with the help of Image Processing.

For Image Processing I have used AFORGE.NET library.

The Robotic arm searches for the Object autonomously and if it detects the object,it tries to pickup the object by estimating the position of object in each frame. Once it has reached the object it picks up the Object.For this i have used Image based servo control technology.

It can detect different color objects and sort the object based on colors without any human intervention.

![enter image description here](https://mayurvarma14.files.wordpress.com/2014/07/gui2.jpg?w=650&h=244)


Licensed under [MIT License](LICENSE) 
