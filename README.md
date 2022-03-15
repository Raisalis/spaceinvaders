# CST326 - Space Invaders (Part 1 Complete)

### Part 1

- Added Sprites and Sprite Animations.
- Added UI score tracking.
  - High Score stays even between game sessions.
  - Enemy Score Information disappears after 10 seconds.
- Overall Game Implemented
  - Enemy Bullets (only one kind right now) destroy shields/player.
  - Player Bullets destroy enemies/shields and add score if enemies are destroyed based on enemy type.
    - All Bullets get destroyed once they go off screen.
  - Game Over Conditions:
    - Enemies reach player row.
    - Player gets destroyed.
  - Enemy UFOs can spawn up to every 10 seconds based on Randomizer.

### Part 2

- Added more Sprites and Sprite Animations.
  - Sprite Animations all contain at least 3 unique frames.
- Added Main Menu and Credits Scenes.
  - One Credits from Main Menu, another from the Game. The game one has no button and automatically returns to the Main Menu after 5 seconds.
- Fixed End Zones and overall spacing of game elements.
- Added some death sounds for enemies and player.

### Other Information
- Sprites made by me based on original game because I couldn't find any good sprite sheets.
- Font used: https://assetstore.unity.com/packages/2d/fonts/free-pixel-font-thaleah-140059
