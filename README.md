# DyM Chart Tool
DyM Chart Tool is a tool used to assist in charting using Dynamaker by allowing for mirroring notes over a period of time and copying notes.

## How to use DyM Chart Tool
Start by loading in a chart file. This can be done by inputting the path to the file in the `in` text box, clicking the button next to it and browsing to it or dragging and dropping the chart onto the application window. Also set the output file while you're here. Once you have done this you can start making "edits" to the chart.

### Mirror
First, select the `Mirror` tab and select whether this edit should affect the entire chart or just notes within a specific timeframe, using the buttons at the top of the window. After that, click one of the buttons corresponding to what action you want to do, Mirroring the left, right or bottom track or swapping the left and right tracks around. Clicking one of these buttons adds that edit to the queue.

### Copy/Merge
First, select the `Copy/Merge` tab and select where to copy notes from (the chart in the `in` text box or another chart file entirely), the copy range's start and end times, and what tracks you want to copy notes from. Then select where in the chart you want to paste these notes and click `Apply` to add the edit to the queue.

### Replace
First, select the `Replace` tab and select whether this edit should affect the entire chart or just notes within a specific timeframe, and which note type to replace notes in the range with (NORMAL or CHAIN). Only NORMAL and CHAIN notes on the bottom track will be replaced, HOLD notes, and notes of any time on the side tracks, are unaffected.

Once you have made all the edits you want, click the `Check edit queue` button to bring up a list of all the edits you have added to the queue. These will run in order from top to bottom. Click the `Apply edits` button to run these edits and save the resulting chart to the output file specified.  
WARNING: If the output file already exists, it will be overwritten with no way to recover it.
