# Dodging-Game
A game created using the Unity game engine where the primary goal is to try not to fall from the platform.

## Description

In this game the player is a red cube that can only move left and right. Multiple obstacles will randomly appear in the distance and move towards the player location, the obstacles speed will increase based on a formula including the time since the game (scene) started. 

## Goal

Some of my goals for this game is to use as minimum processing power as needed, one example is the object pooling method I implemented, where in the beginning of the game a number of obstacles are created and placed in a queue to be used for spawning them during the game. Doing this eliminates the need to create and destroy objects during run time.