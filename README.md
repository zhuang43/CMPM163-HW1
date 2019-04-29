# CMPM163-HW1
# Zeyun Huang

CMPM 163 S2019
Game Graphics & Real-time Rendering
Homework 1 (100 pts) – Due Sunday, 4/28 at 11:59pm

A. Design a 3D scene (30 pts)
Using Unity, create a scene with at least 3 objects and 3 lights.
— Each object will use a different shader, e.g., a Phong shader, a shader that applies a
texture, a vertex displacement shader, etc. At least one of the objects must both be
textured and react to lighting.
— Each object and light in the scene will move or rotate.
(The TAs will show you how to create and load in more complex shapes using Blender in
this week’s Lab sections. You can also use .obj or other 3D data files, for example, taken
from the Google Poly library or the Unity Asset Store).
B. Image processing (20 pts)
Using Unity, create a fragment shader that takes an image and applies an image
processing algorithm to it.
— Design an image processing shader of your choice using a filter kernel, such as one
described on https://en.wikipedia.org/wiki/Kernel_(image_processing).
— Add simple mouse or keyboard interactivity to increase or decrease the effect in some
way.
C. Cellular automata or reaction-diffusion system using shaders (40 pts)
In this exercise, you will use Unity shaders to create a multi-color game of life or reactiondiffusion system that extends the code I provided in class (i.e., using the “ping-pong”
strategy). You can use any of the rules described here:
https://softologyblog.wordpress.com/2013/08/29/cyclic-cellular-automata/
— Choose your own colors, number of states, etc.
— You can use these (non-shader) examples as inspiration, or come up with your own
ideas: http://jsfiddle.net/awilliams47/LJnue/, http://xpl.github.io/expression/.
Another option for this exercise is to instead implement a custom reaction-diffusion
system. Some inspiration can be found here: http://colordodge.com/ReactionDiffusion/,
https://vimeo.com/232765714, https://www.karlsims.com/rd-exhibit.html,
https://github.com/keijiro/RDSystem.
D. Discuss a visual effect (10 pts)
Take a screenshot (or photo) of an interesting visual effect you noticed in a video game or
computational artwork. In a few paragraphs, describe the effect. What do you like about it?
Does the effect change depending on the camera view? The lights? Is it an effect that
updates the geometry itself, or change the color of the pixels, or does it alter a texture?
How do you think it was created? What is the effect called? Do some research/Googling
and see if you can find papers, online tutorials, or blog posts that give insight into how it
was created and how you might emulate it in a Unity shader. 
