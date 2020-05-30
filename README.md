# Cube Fly

A game developed in Unity, based on Flappy Bird

## What did i learn from this game?

* Time.timeScale = 0; - Stop the game
* Time.timeScale = 1; - Start the game
* SceneManager.LoadScene(0); - Load a scene in screen, in this game i only have one scene, so i can put 0, thats represent the first scene in hierarchy. Other option, is put the name of scene, ex: SceneManager.LoadScene("NameScene");
* Put a image, text and button on screen with UI (Canvas).
* Handle with collision and trigger. OnCollisionEnter2D, OnTriggerEnter2D. The difference between collision and trigger is that collision stop the moviment when collider and when use trigger, do you need put one object how trigger(true), to detect the collision  but dont stop the moviment.
* Instantiate - Clones the object original and returns the clone.
* Destroy gameObject after a few seconds

![cube_fly](https://user-images.githubusercontent.com/8952441/83225291-d705e000-a155-11ea-8f27-677c42d8abfc.png)