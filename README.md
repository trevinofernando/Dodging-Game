# Dodging-Game
A game created using the Unity game engine where the primary goal is to try not to fall from the platform.

## Description

In this game the player is a cube that can only jump and move left and right. Multiple obstacles will randomly appear in the distance and move towards the player location with the intention to knock the player off the platform, the obstacles speed will increase based on a formula including the time since the game (scene) started. 

## Goal

Some of my goals for this game is to reduce processing power and practice my Unity skills, one example is the object pooling method implemented, where in the beginning of the game a number of obstacles are created and placed in a queue to be used for spawning them during the game. Doing this eliminates the need to create and destroy objects during run time, since we only need to movethem around.