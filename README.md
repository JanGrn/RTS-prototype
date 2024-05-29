# RTS-prototype
## General concept
### Gameplay
- Player starts with a main building
- Resource stacks up on a fixed timer
- Resource can be spent in the building to create a variety of units
- Resource can alternatively be spent to increase accumulation speed
- Another building allows buying techs to improve units A, B or C
- After a fixed time, waves spawn that need to be defeated

#### Units
Simple rock paper scissor:
- Units deal 10 dmg by default
- A beats B beats C beats A
- If unit beats another unit, unit deals 15 damage and receives 7 damage

### UI
Start scene: Title text, start button, settings button
- Settings button opens a selection:
  - increase game speed
  - enable fourth unit type
  - hard mode

Main scene:
- Ressource
- Ressource accumulation speed
- Timer to wave
- Wave number indicator
- Tech status
