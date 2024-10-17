# User Login Form Application (Windows Forms)

This project showcases a **simple user login system** developed using **C# and Windows Forms**. It consists of two core functionalities:  
1. **User Authentication Form**  
2. **Data Display with DataGridView Form**

## Features  
### 1. Login Form  
- **Credential Verification**: Validates the username and password entered by the user.  
- **Error Handling**: If credentials are incorrect, an error message is shown.  
- **Transition on Success**: On successful login, the application hides the login form and opens the DataGridView form.

### 2. DataGridView Form  
- **Simulates Data Display**: Contains a grid with mock course data (course code, title, marks, grade, and status).  
- **User Interaction**: Allows basic interaction with the data grid.

## Technologies Used  
- **C# .NET**  
- **Windows Forms (WinForms)**  
- **Visual Studio IDE**

## How to Run the Application  
1. Clone this repository to your local machine.  
2. Open the solution file (`.sln`) in **Visual Studio**.  
3. Press **F5** or click the **Start** button to run the application.  
4. Use the following credentials to log in:
   - **Username**: `name`  
   - **Password**: `password`  

## Folder Structure  

```
Login_form/ │ ├── Program.cs // Application entry point
├── LoginForm.cs // Code for login logic
├── LoginForm.Designer.cs // Login form UI components
├── DataGridForm.cs // Code for DataGridView logic
└── DataGridForm.Designer.cs // DataGridView form UI components
```


## Summary  
This project serves as a foundational example of **multi-form Windows applications**. It demonstrates:
- User authentication
- Basic form navigation
- Display of structured data using `DataGridView`

Feel free to fork, modify, or contribute to this project.
