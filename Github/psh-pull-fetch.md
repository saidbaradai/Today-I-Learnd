19

Fetch, pull and push are all standard Git commands. 
Type git help fetch, etc. f
rom a console Window for the in-depth details, but it boils down to this:

fetch: bring in changes without merging them
pull: bring in changes and do merge them
push: send out your changes.
Publish is more interesting. Microsoft is expecting people to work in feature branches, 
but to merge those back in to the master branch before pushing (i.e. only share the end result with others,
rather than cluttering up their repositories with short-lived branches). 
The Publish command lets you select branches that you do want to share with other users. 
See the Microsoft docs for further details.
