# sobrooms/[FindingWhoAskedInOhio](https://github.com/sobrooms/FindingWhoAskedInOhio)
A game made with Unity.

# About
* Unity 2021.3.20f1 Personal
* I swear the music sounds terrible

# TODO
- [x] Add XLua support
- [x] More proper ui element fit (MainScene)


# To execute Lua scripts
To run Lua scripts using XLua, create these folders:
* `FindingWhoAskedInOhio_Data\lua` (main folder)
* `FindingWhoAskedInOhio_Data\lua\start` (lua files which will run on MainScene scene load)
* `FindingWhoAskedInOhio_Data\lua\update` (lua files which will run per frame)
* `FindingWhoAskedInOhio_Data\lua\fixed_update` (lua files which run per fixed frame)

Note that each line in the Lua file will be executed seperately (ex. 1st line won't be executed at the same time as the second)...
