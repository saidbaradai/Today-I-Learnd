### View
A View is that part of the application that represents the presentation of data.

Views are created by the data collected from the model data. A view requests the model to give information so that it presents the output presentation to the user.

The view also represents the data from charts, diagrams, and tables. For example, any customer view will include all the UI components like text boxes, drop downs, etc.

### Controller
The Controller is that part of the application that handles the user interaction. The controller interprets the mouse and keyboard inputs from the user, informing model and the view to change as appropriate.

A Controller send’s commands to the model to update its state(E.g., Saving a specific document). The controller also sends commands to its associated view to change the view’s presentation (For example scrolling a particular document).

### Model
The model component stores data and its related logic. It represents data that is being transferred between controller components or any other related business logic. For example, a Controller object will retrieve the customer info from the database. It manipulates data and sends back to the database or uses it to render the same data.

It responds to the request from the views and also responds to instructions from the controller to update itself. It is also the lowest level of the pattern which is responsible for maintaining data.![dasd](https://user-images.githubusercontent.com/73998098/178610101-ad5b8e6b-42ca-4a58-90ef-18f6c2ed8df7.png)


[Source](https://www.guru99.com/mvc-tutorial.html)
