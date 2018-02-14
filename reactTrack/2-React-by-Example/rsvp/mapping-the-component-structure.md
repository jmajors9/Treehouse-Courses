# Mapping the Component Structure
The first step will be to break the app into components. Then, we'll think about how those components should connect to each other. This will give us an idea of where state should be.

## What are the components?
1. one to contain the entire app
    1. Form
    1. Counter
    1. Hide/Show unconfirmed guests
    1. Name tile parent div
        1. Name Tile(s)
            1. Name
            1. Confirmed checkbox
            1. edit button
            1. remove button
        1. Ghost tile (showing as text added.)

## How do the components connect to each other?
1. Main App
    - Name is an example of state shared by Form and Name Tile
    - counter will change based on number of guests
        - needs to know 


## Where should the "state" live?
The more we think about it, the main component should hold the state as it touches all the boxes that need state.
