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

### Level Design

This game features 3 main levels **"Hell", "Earth", and "Heaven"**. Each of which features its own music theme as well as custoum VFX and sound effects to fit the atmosphere.

* **Earth:** Difficulty = **Easy**. The field of view is the largest of the 3 levels. The lighting makes it easy to see the obstacles from far away. Jumping effect is a dusty type. This is the only level with a static death scene.

* **Heaven:** Difficulty = **Medium**. This level makes the introduction of clouds. Clouds will rise and fall periodically during the game, covering the platform to keep you guessing where it ends. This level was the last one to be created and features a similar death effect as the Hell level.

* **Hell:** Difficulty = **Hard**. I spent the most amount of time in this level. It features custoum sound effects as well as more agressive VFX. This level introduced the **"Wall of Fire"**, which moves back and forth towards the player with the intention to limit how far the player can see. The death animation slows time and disables floor collisions to fake a disolving effect.

## Developer Goal

Some of my goals for this game is to *reduce processing* power and *practice* my Unity skills, one example is the *Object Pooling* method implemented, where in the beginning of the game a number of obstacles are created and placed in a queue to be used for spawning them during the game. Doing this eliminates the need to create and destroy objects during run time, since we only need to move them around. 

