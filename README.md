# Unity First Person Movement

Karlson like first person movement made for the unity game engine, link to setup tutorial comming soon.
There will be more features added to this, like wallruning, vaulting and crouching

![alt text](https://github.com/AtanGames/UnityFPMovement/blob/main/MovementDemoGif.gif?raw=true "MovementDemo")

This is a basic Movement script for first person games, with quick setup for game jams, prototyping and other purposes. 

Note: This Script is using the old Input Manager

Setup:
 - Create capsule, scale Y to 1.2, assign it a new layer (for example "Player"), remove MeshFilter and Mesh Renderer
 - Create 3 childs on the player Look, Head and Groundcheck (in this order)
 - Set heads Y position to about 0.8
 - Set groundchecks Y position to -0.95 (NOT LOWER)
 - Add a Rigidbody to the player, freeze all rotations (X, Y and Z), set the rigidbody to interpolate, increase mass to 1.2
 - Select the main Camera, set FOV to about 90, set near clipping plane to minimum (0.01)
 - Create an empty Parent for the Camera, make sure to set the Camera's localPosition and localRotation to (0, 0, 0), on this new parent add the "Camera Controller Component"
 - Attach the "Movement" script to the player, set groundcheck layer to all except player, assign the camera variable (assign to it the camera parent we created earlier)
 - Set Physics gravity in project settings to -30
 - Create a physics material and set the dynamic and static frition to 0, set friction combine to minimum, assign this to the player's capsule collider
 - 
Most Values are fine by default, but you can modify them for your needs
