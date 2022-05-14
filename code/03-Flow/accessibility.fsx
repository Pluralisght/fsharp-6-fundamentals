module MyModule =
    let x = 1
    let public y = 2
    let private z = 3
    let internal w = 4

module AnotherModule =
    open MyModule
    MyModule.w // visible here
    MyModule.x // can be seen
    MyModule.y // can be seen
    MyModule.z // errror - not visible
