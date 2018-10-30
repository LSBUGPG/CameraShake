# Camera Shake

This project has 3 behaviours:
1. CameraShake
2. ShakeEffect
3. TriggerBehaviour

## CameraShake behaviour

This behaviour uses a sine wave to modify the local position of the camera in X and Y directions. You can set the frequency and amplitude of the waves separately for X and Y. You can experiment with the values for amplitude and frequency to get the effect you are looking for. This script runs continuously so set the amplitude values to zero to get no shake.

To contstruct the scene for this script, you need an empty game object to represent the position of the camera. Then place the camera as a child. This allows you to move the camera around using the parent CameraTransform. Be aware that the CameraShake script will modify the local position of the camera relative to its parent, so if you place the shake script on a camera without a parent it will move it back to 0,0,0.

## ShakeEffect behaviour

This behaviour copies values into a connected CameraShake behaviour. When you have values you like from experimenting with CameraShake, copy those values into a ShakeEffect behaviour. The amplitude curve can be any shape but you should start at zero and end at zero, ramping up in the middle if you want a smooth transition into a shake. This script will apply this curve as a modifier to the parameters it copies to CameraShake.

When you enable this behaviour it runs through the curve in time and copies the values modulated by the curve into the CameraShake. When it reaches the end of the animation, it turns itself off.

## TriggerBehaviour

This behaviour enables the linked behaviour when you press the given key. You can use it for testing purposes to start different shake effects. You can have as many ShakeEffect and TriggerBehaviour scripts as you like.

## Limitations

The effects don't combine, so if you try to run two effects at the same time, one will overwrite the other.
