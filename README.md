A Chinese Chess game (Xiangqi) I wrote to acquaint myself with Blazor and get some good practice writing C#.

Features:
- Full moveset for all pieces.
- Legal move checks with visual indicators to show where a piece can move.
- Restrict moves when one's own general (king) is in check.
- Detect checkmate state - end game.

TODO:
- Restart game.
- Button toggle to switch visuals on the pieces - from Chinese characters to pictures.
- Refactor the code for easier debugging. It's all very procedural at the moment : P
- General CSS polish
- Online play
- Computer-controlled AI

I got help from AI with the initial setup (dictionaries, hashsets etc) and program flow early on, CSS/HTML, and some extra tricky parts like the simulated move logic to tell when moves can put one's own king in check.
