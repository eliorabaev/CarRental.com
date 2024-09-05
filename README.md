# Car Rental Project

This README provides an overview of the Car Rental project, a comprehensive application for managing car rentals. It utilizes Object-Oriented Programming (OOP) principles with a hierarchical class structure, polymorphism, collection management, and data serialization for a robust and flexible system. The application features a user-friendly graphical interface.

# **Features:**

* **Car Inventory:**
  - Manages a list of vehicles, including car types (Family, Sport, Commercial, Truck), prices, fuel types, and unique identification numbers.
  - Allows for adding, removing, editing car information, and swapping cars between parking lots.
  - Visually represents cars in a parking lot-like layout.
* **Sorting and Filtering:**
  - Enables sorting the car inventory by various criteria (car number, company, price, fuel type, car type).
  - Provides filtering capabilities to search for cars based on specific criteria (implemented in the Frontend).
* **Hierarchical Class Structure:**
  - Implements a base class `Vehicle` and derived classes `Car` (further specialized into `FamilyCar`, `SportCar`, etc.) representing different car types.
  - This structure promotes code reusability, extensibility, and polymorphism.
* **Polymorphism:**
  - Utilizes inheritance and method overriding for flexible handling of different car types. For instance, the `GetCarInfo` method can be overridden in derived classes to provide specific car details.
* **Collection Management:**
  - Employs a `BindingList<Vehicle>` in the `CarsManager` class to organize and manage car objects.
  - This collection allows for data binding with the user interface and enables efficient car data manipulation.
* **Event-Driven Programming:**
  - Handle user interactions and system events.
* **Graphical Representation:**
  - The Frontend implementation can visually represent cars in a parking lot layout with user interaction capabilities.
* **Serializations:**
  - Uses `FileUtiles` class (not shown here) for saving and loading car data to/from a file using serialization techniques.
  - This enables persistence of car data across application sessions.

# **Getting Started:**

1. **Clone the Repository:**
  ``` bash
  git clode https://github.com/eliorabaev/CarRental.com.git
  cd CarRental.com\CarRental\bin\Debug
  ```
2. **Open the Project:**

Open the cloned project in your C# development environment (e.g., Visual Studio).

3. **Build the Project:**

Follow the build instructions for your development environment to generate the executable file.

4. **Run the Application:**

Execute the generated executable file to launch the Car Rental application.

# **Usage:**

1. **Login:**
- Upon launching the application, you may be prompted for login credentials. Username: admin, Password: admin.

2. **Navigate the Inventory:**
- Use the provided interface to view, add, remove, or edit cars.
- Hover on a car in the parking lot to view its details.
- Press "Inventory list" to see a table with your car inventory.

3. **Manage Cars:**
- Click the "Add Car" button to add a new car.
- Enter the required information for the new car (e.g., type, price, fuel, company).
- Click the "Remove Car" button to delete a selected car.
- You also have the option to change existing car details. You can press "Change" button after selecting a car.
- The application allows swapping cars between parking lots using the `SwapCars` method. Select 2 cars and swap their locations
- You can also delete a car by selecting it and pressing "Remove" or dragging it to the $ gif.

# **Contributing:**

If you'd like to contribute to this project, please fork the repository and submit a pull request.

