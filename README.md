# Dodging-Game
A game created using the Unity game engine where the primary goal is to try not to fall from the platform.

![alt text](https://raw.githubusercontent.com/trevinofernando/Dodging-Game/master/New%20Unity%20Project/Assets/Imports/Imgs/DodgingGameIcon.png)

## Description

In this game the player is a cube that can only jump and move left and right. Multiple obstacles will randomly appear in the distance and move towards the player location with the intention to knock the player off the platform, the obstacles speed will increase based on a formula including the time since the game (scene) started.

### How to Play

To start the game, visit the **link:** https://trevinofernando.github.io/Dodging-Game/. Then make sure to adjust, in the **Options menu**, the *volume, quality level* and if you want *fullscreen* or not. Then simply click the **Back** button to return to the main menu. Now you are all set, click **Play**, *select* one ot the 3 *levels* and click **Play** on the preview image.

This game is meant to be played on **PC** with a **keyboard**. Here are the controls:
* **Pause:** "q" / "p"
* **Jump:** "w" / up-arrow / Space bar
* **Move Left:** "a" / Left-arrow
* **Move Right:** "d" / Right-arrow

## Developer Goal

Some of my goals for this game is to *reduce processing* power and *practice* my Unity skills, one example is the *Object Pooling* method implemented, where in the beginning of the game a number of obstacles are created and placed in a queue to be used for spawning them during the game. Doing this eliminates the need to create and destroy objects during run time, since we only need to move them around. 

