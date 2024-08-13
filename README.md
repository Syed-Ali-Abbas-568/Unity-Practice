#  Task A: Implementation Strategy
To implement this task in a modular fashion, We would need to do the following:
1. Scene Management:
    * To ensure seamless transitions, we would need to use unity built in scene manager along with additive scene loading.
    * Create a SceneManager script that controls which scenes are loaded and handles the transitions between them.
2. Animations and Transitions:
    * Use Unity’s Animator and Animation components to create shrink and disapper and grow and come in existance effects for objects and title as needed.
    * For the interactive spheres, attach scripts that use coroutine to handle fading and movement when a sphere is selected.
5. Data Persistence Across Scenes:
    * To keep track of which sphere was selected in Scene 2 when moving to Scene 3, use a static class or a Singleton pattern to store the selected sphere’s data, using the destroyOnLoad fuction.
6. Modularity:
    * Write reusable scripts, for orbiting, rotation and on click events. That can be mapped to other projects as well.

#  Task B: Challenges
1. Maintaining State Across Scenes:
    * Managing the state of the game across different scenes, particularly the state of selected spheres, is a challenge. Utilizing static data management or persistent GameObjects effectively is crucial.
2. Performance Optimization:
    * Ensuring smooth transitions and animations while scenes load in the background requires careful management of resources and might necessitate optimizations like asynchronous loading and unloading of assets.
3. UI Consistency:
    * Keeping the timeline UI consistent and functional across all scenes requires careful design to ensure it interacts properly with the scene loading and unloading mechanisms.
4. Handling User Interactions:
    * The interaction with spheres and triggering animations based on these interactions must be handled carefully to ensure a responsive experience.

# Task C and Task D (architecture and implementation are done in code)
