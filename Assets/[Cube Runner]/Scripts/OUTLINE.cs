/*
OUTLINE:
---------
Features:
1. at the start of level click/tap to play screen
2. player goes forward at constant speed after tap to play screen is closed
3. if player hits obstacle round ends and round is then repeated
4. if player hits coin, coin disappears, coin counter increases
    4. i. if player dies all the coins they collected that round resets
    4. ii. player coin info is stored in player prefs
5. if player is out of the bounds of the platform, player will no longer be able to 
    move left/right, "You Died" canvas is enabled and level is restarted
6. level ends when player reaches the end platform, input canvas is disabled after
    level end
7. next level is automatically loaded
8. if all levels are completed, a pop up says "all levels completed" and loop to 
    the first level
-----------
Scripts:
(Main Camera) FollowPlayer -> follows player
(Player) PlayerMovement -> responsible for players' forward and left/right movement
                           : IPointerDownHandler, IDragHandler, IPointerUpHandler
(Player) PlayerCollision -> responsible for player objects collisions (obstacles, coins)
(Input Canvas) InputHandler -> detects hand movement across the canvas and translates
                             to player left/right movement, player movement uses this data
                             : ISinglePointerRunnerInputListener
(Menu Canvas) UIHandler -> detects the correct game phase and enables the appropriate
                            canvas
(Coin Text) CoinText -> updates each time player hits coin (DOTween coin icon hop)
(Event Manager) EventManager -> All listeners of events are defined in this script
-------------
Events:
1. LevelStartEvent -> called after tap to play screen
2. LevelRestartEvent -> called when player hits obstacle or goes out of bounds
3. LevelEndEvent -> called after player hits end trigger, "Level Complete Animation" (if last level instead pop up menu)
4. LoadNextLevelEvent -> called after LevelEndEvent
5. CoinCollectedEvent -> called when player hits coins
6. CoinTextUpdateEvent -> called after CoinCollectedEvent
*/