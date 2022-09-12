# UnityRollABall - Soccer
CS 328 Assignment One

Unity Roll A Ball Assignment following https://learn.unity.com/project/roll-a-ball . I used some of my previous Unity experience to have fun with this assignment by adding several changes and features to make the game more unique.

I first changed the material of my ball to a different URP shader. I tried to go with a legacy shader such as diffuse but quickly realized that was not possible as this project was built in the URP environment. So I am using the URP 2D Sprite Lit shader so that I could apply my soccer ball sprite to the player object. 

Next instead of a cube for the pick up object, I am using another sphere that is scaled to replicate a coin. I made a small change to the rotator script for my coin so that it would work better for my case as I want my coin to only rotate about a certain axis. 
