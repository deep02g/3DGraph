# 3DGraph
A complete environment for creating and viewing different geometric forms in three dimensions is provided by the 3DGraph simulator. With the use of user controls, custom shaders, and mathematical formulae, this simulator offers an interactive experience. The simulator displays a wide variety of forms, including spheres, ripples, torus, and waves with multiple interferences. Shape generation is accomplished by populating a scene with 100 cubes at a time, which serve as the building blocks of the intricate structures. The simulator adds a third plane, Z, to the original two-dimensional constructions, which were limited to the X-Y plane, to give them a real three-dimensional look. This improvement makes it possible to produce complex three-dimensional forms like spheres and toruses, which give the created structures more depth and realism. Corresponding to their global positions, each cube in the scene is given a different color via a custom shader. 

One of the notable features of this simulator is the integration of animation. By incorporating a time variable, denoted as 't,' and incrementing it based on Time.DeltaTime, the structures within the scene come to life. The animated structures exhibit cyclic movements within a finite range, lending a dynamic aspect to the visualization.

User interaction is facilitated through a thoughtfully designed graphical user interface (UI). The UI presents users with a convenient dropdown menu, enabling the selection of different structures for generation. Furthermore, the simulator incorporates camera controls, empowering users with the ability to freely navigate the scene, lock the camera's position, or restore it to a default viewpoint. Dedicated buttons assigned to each task streamline the user experience and provide intuitive control over the simulation environment. Each of the five structures within the simulator seamlessly transitions into one another, cycling through their respective animations every 2.5 seconds. The mathematical complexities involved in achieving this smooth and captivating transition were a testament to my expertise.

A powerful platform for investigating and visualizing three-dimensional geometric shapes is provided by this simulator. This simulator satisfies the needs of both amateurs and professionals looking to interactively explore and alter complex structures in a virtual environment thanks to its  rendering techniques, dynamic animation capabilities, and user-friendly interface.

-> You can clone this repository to run it under your unity editor ver:2021.3.14f1 and take a look. Here you can play with the math used in this simulator, possibly create new shapes, play with the number of cubes present at the scene creating a janky and delightful scenery. OR
-> You can directly download the lastest windows build and try the simulator there. Here is the build link : 




https://github.com/deep02g/3DGraph/assets/63899250/44e7ad66-cc70-418d-896c-fa54ca37e2bc

