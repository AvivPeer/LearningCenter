# Learning Center Management System 📚
A practical learning center management system born from real-world need. As both a Software Engineering student and Learning Center Manager,
I built this application to solve actual operational challenges I face daily - from tracking student progress and managing teacher assignments to identifying students who need extra support. 

## What This Project Does

This app helps learning center administrators manage their daily operations:
- Keep track of students and their subject status
- Manage teachers and assign them to students  
- See which students need extra help in specific subjects
- Track how often students visit the center

## Tech Stack

- **Language**: C# 
- **UI Framework**: Windows Forms
- **Database**: MySQL
- **IDE**: Visual Studio 2022

## Getting Started

### What You Need
- Visual Studio 2019 or newer
- MySQL Server (I used version 8.0)
- .NET Framework 4.7.2+

### Setting It Up

1. **Clone this repo**
   ```bash
   git clone https://github.com/yourusername/learning-center-management.git
   ```

2. **Set up the database**
   - Open MySQL Workbench
   - Create a new database called `learning_center`
   - Run the SQL scripts in the `/database` folder (or create tables manually - see below)

3. **Update connection string**
   In `DBManager.cs`, change this line with your MySQL credentials:
   ```csharp
   connectionString = "Server=localhost;Database=learning_center;Uid=YOUR_USERNAME;Pwd=YOUR_PASSWORD;";
   ```

4. **Build and run**
   - Open the solution in Visual Studio
   - Hit F5 to run

## Database Tables

The main tables I created:

```sql
-- Students table
CREATE TABLE students (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    student_number VARCHAR(20) UNIQUE NOT NULL,
    student_phone VARCHAR(15),
    class_level INT NOT NULL,
    teacher_id INT,
    center_visits INT DEFAULT 0,
    last_visit_date DATE,
    comments TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Teachers table  
CREATE TABLE teachers (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    phone VARCHAR(15),
    salary DECIMAL(10,2),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Subjects table
CREATE TABLE subjects (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL UNIQUE
);

-- Links students to subjects with performance levels
CREATE TABLE student_subjects (
    id INT AUTO_INCREMENT PRIMARY KEY,
    student_id INT,
    subject_id INT,
    curStatus ENUM('POOR', 'GOOD', 'GREAT', 'EXCELLENT') DEFAULT 'GOOD',
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
```

## How to Use

### Main Menu
When you start the app, you'll see 4 buttons:
- **נתוני תלמיד** - View student details
- **ניהול תלמידים** - Add/edit students  
- **ניהול מורים** - Manage teachers
- **סטטיסטיקות** - See statistics

### Adding a New Student
1. Click "ניהול תלמידים" (Student Management)
2. Fill in student details (name, ID, phone, class level)
3. Click "צור תלמיד חדש" (Create New Student)
4. You can then add subjects and assign a teacher

### Viewing Statistics
1. Click "סטטיסטיקות" (Statistics)
2. Select a subject from the list
3. See which students are struggling (marked as "POOR") organized by grade level
4. View the most frequent visitors to the center

## Project Structure

```
LearningCenter/
├── Models/              # Data classes (Student, Teacher, etc.)
├── Forms/               # All the Windows Forms
├── DBManager.cs         # Handles all database operations
├── Program.cs           # Main entry point
└── README.md
```

## What I Learned

This project helped me practice:
- **Database Design**: Creating normalized tables with proper relationships
- **Windows Forms**: Building desktop UIs with event handling
- **C# OOP**: Using classes, encapsulation, abstraction and proper code organization

## Known Issues & Future Improvements

**Current Issues:**
- No input validation for student ID format
- Database passwords are hardcoded (should use environment variables)
- SQL queries need optimizing.
- No backup/restore functionality

**What I'd Add Next:**
- Input validation with proper error messages
- Export data to Excel/PDF reports
- Improved UI.
- Adding topic to subjects and Assignments class that will organize specific assignment assigned to students

## Screenshots

Main Menu
<img width="799" height="479" alt="image" src="https://github.com/user-attachments/assets/9d1b53ca-235a-45a7-88e3-5ca809e9f971" />

Student Details:
<img width="797" height="485" alt="image" src="https://github.com/user-attachments/assets/b1252c9e-ee29-4dd2-afe2-e2eeb55aeec5" />

Student Management:
<img width="799" height="473" alt="image" src="https://github.com/user-attachments/assets/a7464135-f5e8-4bc1-9fab-d7429eb98d49" />

Statistics
<img width="790" height="475" alt="image" src="https://github.com/user-attachments/assets/e97fd386-61c0-4687-9978-8044776dd6aa" />


## Contributing

This is a student project, but if you want to suggest improvements:
1. Fork the repo
2. Create a feature branch
3. Make your changes
4. Submit a pull request

I'm always looking to learn better coding practices!

## Contact

**Aviv Peer** - Software Engineering Student  
📧 aviv.per@gmail.com  
🔗 https://www.linkedin.com/in/aviv-peer-6225a0188/
📁 https://github.com/AvivPeer

---

*This project was built as part of my Software Engineering studies at Braude in order to assist me in real day to day work . It demonstrates database integration, desktop application development, and software architecture principles.*
