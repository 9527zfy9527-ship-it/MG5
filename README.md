# MG5
## Devlog
### Answer 1
#### I think it’s more advantageous to use a NavMesh when the game requires point-and-click movement, pathfinding, and AI automatically navigating around complex obstacles. Scripting with physics is better when the character's movement relies heavily on gravity, momentum, jumping, and dynamic collisions.
Game that makes sense with NavMesh: League of Legends. It's a MOBA where players click to move, and the characters need to automatically calculate the shortest path to the destination while avoiding walls.
Game that does not make sense with NavMesh: Super Mario Bros or Fall Guys. These are platformers where the core mechanics involve jumping, falling, and physics-based collisions, which NavMesh is not designed to handle.

### Aswer 2
#### Inside the for loop, the code iterates through every single bird stored in the _birds array one by one.
The call to Vector3.Distance is used to calculate the exact distance in 3D space between two points: specifically, the current bird's position and the player's position.
Based on the if statement, only the birds whose distance to the player is less than or equal to the _interactDistance threshold will run away. Birds that are further away than this distance will be ignored and remain where they are.

## Open-Source Assets
- [Quirky animal 3D models](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235)
- [Mountain fantasy environment models](https://www.fab.com/listings/60487a72-3f20-4bb2-aa78-247ed1582656)
