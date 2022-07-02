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







## fetch

Downloads new data from a remote repository (GitHub in our examples).  However, it doesn’t integrate any of the new data into the working files. Fetch is ideal for receiving a view of the modifications that has occurred at the remote repo.

## pull

Updates your current head branch with the latest modifications from the remote repo.  As part of the pull process and pulling down of new data, it also merges the new data into your current files, which can have negative outcomes.

