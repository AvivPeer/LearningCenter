using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;


namespace LearningCenter
{
    internal class DBManager
    {
        private string connectionString;

        public DBManager()
        {
            // Get connection string from app.config or set default
            connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"]?.ConnectionString;
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = "Server=localhost;Database=learning_center;Uid=<ID>;Pwd=<PASS>!;";
            }
        }

        // Constructor with custom connection string
        public DBManager(string server, string database, string username, string password)
        {
            connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
        }

        // Test database connection
        public bool TestConnection()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //Teachers DB Managerment Logic and Fucntions
        // Get all teachers
        public List<Teacher> GetAllTeachers()
        {
            var teachers = new List<Teacher>();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, name, phone,Salary FROM teachers ORDER BY name";

                    using (var command = new MySqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var teacher = new Teacher();
                            teacher.setId(reader.GetInt32("id"));
                            teacher.setName(reader.GetString("name"));
                            teacher.setPhoneNumber(reader.IsDBNull("phone") ? "" : reader.GetString("phone"));
                            teacher.setSalary(reader.GetInt32("Salary"));
                            teachers.Add(teacher);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return teachers;
        }

   
        public Teacher GetTeacherByPhone(string Phone)
        {
            var teacher = new Teacher();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, name, phone,salary  FROM teachers WHERE phone = @phone";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@phone", Phone);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                teacher.setId(reader.GetInt32("id"));
                                teacher.setName(reader.GetString("name"));
                                teacher.setPhoneNumber(Phone);
                                teacher.setSalary(reader.GetInt32("salary"));
                                return teacher;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
        public Teacher GetTeacherById(int id)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, name, phone,salary  FROM teachers WHERE id = @id";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var teacher = new Teacher();
                                teacher.setId(reader.GetInt32("id"));
                                teacher.setName(reader.GetString("name"));
                                teacher.setPhoneNumber(reader.IsDBNull("phone") ? "" : reader.GetString("phone"));
                                teacher.setSalary(reader.GetInt32("salary"));
                                return teacher;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        // Add new teacher
        public bool AddTeacher(Teacher teacher)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO teachers (name, phone,  salary) VALUES (@name, @phone, @salary)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", teacher.getName());
                        command.Parameters.AddWithValue("@phone", teacher.getPhoneNumber());
                        command.Parameters.AddWithValue("@salary", teacher.getSalary());

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }

        public bool DeleteTeacher(string teacherName)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM teachers WHERE name = @subId";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentNumber", teacherName);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Teachers Comments DB Logic and functions

        public bool AddTeacherComment(Teacher teacher, Student student, string comment)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO teacher_comments (teacher_id, student_id,comment, created_at) 
                               VALUES (@teacher_id, @student_id, @comment, @created_at)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@teacher_id", teacher.getId());
                        command.Parameters.AddWithValue("@student_id", student.getId());
                        command.Parameters.AddWithValue("@comment", comment);
                        command.Parameters.AddWithValue("@created_at", DateTime.Now);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
        public List<Comments> getTeacherCmntsByStdID(int stdID)
        {
            var comments = new List<Comments>();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"select id,comment from teacher_comments where student_id = @stdid";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@stdid", stdID);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var comment = new Comments(reader.GetString("comment"), reader.GetInt32("id"));
                                comments.Add(comment);
                            }
                        }
                    }
                }
                return comments;

            }
            catch (Exception ex)
            {
                return comments;
            }

        }

        public bool UpdateTeacher(Teacher teacher)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE teachers SET 
                               name = @name,
                               phone = @phone,
                               Salary = @salary
                                where id = @curTeachId";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@curTeachId", teacher.getId());
                        command.Parameters.AddWithValue("@name", teacher.getName());
                        command.Parameters.AddWithValue("@phone", teacher.getPhoneNumber());
                        command.Parameters.AddWithValue("@salary", teacher.getSalary());

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }

        //Subjects DB Logic and functions

        public List<Subject> getAllSubjectsAvailable()
        {
            List<Subject> subjects = new List<Subject>();
            try
            {
                using(var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM subjects";

                    using(var command = new MySqlCommand(query,connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Subject subject = new Subject();
                                subject.setName(reader.GetString("name"));
                                subject.setId(reader.GetInt32("id"));
                                subjects.Add(subject);
                            }

                        }
                       
                    }
                }
                return subjects;
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                return subjects;
            }
            
        }
        public bool AddSubject(Subject subject)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO subjects (name,  subId) VALUES (@name, @subid)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", subject.getName());
                        command.Parameters.AddWithValue("@subid", subject.getId());

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
        public bool UpdateSubject(Subject subject)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE subjects SET 
                               subID = @subid,
                               name = @name";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", subject.getName());
                        command.Parameters.AddWithValue("@subid", subject.getId());

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
        public bool DeleteSubject(int subId)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM subject WHERE subID = @subId";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentNumber", subId);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }

        //Student DB Logic and functions
        //Add Student Subjects
        public bool AddStudentSubject(Student student,Subject subject,string Status)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO student_subjects (student_id,  subject_id,curStatus) VALUES (@stdid, @subjectid, @status)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@stdid", student.getId());
                        command.Parameters.AddWithValue("@subjectid", subject.getId());
                        command.Parameters.AddWithValue("@status", Status);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
        //Delete Student Subject
        public bool DeleteStudentSubject(Student student,Subject subject)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM student_subjects WHERE subject_id=@subjectid AND student_id = @stid";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@stid", student.getId());
                        command.Parameters.AddWithValue("@subjectid", subject.getId());

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
        // Get students by class level
        public List<Student> GetStudentsByClass(int classLevel)
        {
            var students = new List<Student>();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT id, name, student_number, class_level, teacher_id, 
                               center_visits, 
                               last_visit_date, comments 
                               FROM students 
                               WHERE class_level = @classLevel 
                               ORDER BY name";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@classLevel", classLevel);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var student = new Student();
                                student.setId(reader.GetInt32("id"));
                                student.setName(reader.GetString("name"));
                                student.setstdId(reader.GetString("student_number"));
                                student.setClasLevel(reader.GetInt32("class_level"));
                                student.setTeacherId(reader.IsDBNull("teacher_id") ? 0 : reader.GetInt32("teacher_id"));
                                student.setCenterVisits(reader.GetInt32("center_visits"));
                                student.setLastvisitDate(reader.IsDBNull("last_visit_date") ? null : reader.GetDateTime("last_visit_date"));
                                student.updateCmnt(reader.IsDBNull("comments") ? "" : reader.GetString("comments"));
                                students.Add(student);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return students;
        }
        // Get students by teacher
        public List<Student> GetStudentsByTeacher(Teacher teacher)
        {
            var students = new List<Student>();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT id, name, student_number, class_level, teacher_id, 
                               center_visits, 
                               last_visit_date, comments 
                               FROM students 
                               WHERE teacher_id = @teacherid 
                               ORDER BY name";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@teacherid", teacher.getId());

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var student = new Student();
                                student.setId(reader.GetInt32("id"));
                                student.setName(reader.GetString("name"));
                                student.setstdId(reader.GetString("student_number"));
                                student.setClasLevel(reader.GetInt32("class_level"));
                                student.setTeacherId(reader.IsDBNull("teacher_id") ? 0 : reader.GetInt32("teacher_id"));
                                student.setCenterVisits(reader.GetInt32("center_visits"));
                                student.setLastvisitDate(reader.IsDBNull("last_visit_date") ? null : reader.GetDateTime("last_visit_date"));
                                student.updateCmnt(reader.IsDBNull("comments") ? "" : reader.GetString("comments"));
                                students.Add(student);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return students;
        }

        //GetMaxFreqVisitor
        public List<Student> GetMaxFreqVisitor()
        {
            List<Student> students = new List<Student>();
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * 
                                    FROM students 
                                    WHERE center_visits = (SELECT MAX(center_visits) FROM students);";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var student = new Student();

                                student.setId(reader.GetInt32("id"));
                                student.setName(reader.GetString("name"));
                                student.setstdId(reader.GetString("student_number"));
                                student.setClasLevel(reader.GetInt32("class_level"));
                                student.setTeacherId(reader.IsDBNull("teacher_id") ? 0 : reader.GetInt32("teacher_id"));
                                student.setCenterVisits(reader.GetInt32("center_visits"));
                                student.setLastvisitDate(reader.IsDBNull("last_visit_date") ? null : reader.GetDateTime("last_visit_date"));
                                student.updateCmnt(reader.IsDBNull("comments") ? "" : reader.GetString("comments"));
                                students.Add(student);


                            }
                            return students;
                        }
                    }
                }

            }
            catch(Exception ex) 
            {
                return null;
            }
        }

        // Get all students
        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT id, name, student_number, class_level, teacher_id, 
                               center_visits, 
                               last_visit_date, comments 
                               FROM students";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var student = new Student();
                                student.setId(reader.GetInt32("id"));
                                student.setName(reader.GetString("name"));
                                student.setstdId(reader.GetString("student_number"));
                                student.setClasLevel(reader.GetInt32("class_level"));
                                student.setTeacherId(reader.IsDBNull("teacher_id") ? 0 : reader.GetInt32("teacher_id"));
                                student.setCenterVisits(reader.GetInt32("center_visits"));
                                student.setLastvisitDate(reader.IsDBNull("last_visit_date") ? null : reader.GetDateTime("last_visit_date"));
                                student.updateCmnt(reader.IsDBNull("comments") ? "" : reader.GetString("comments"));
                                students.Add(student);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return students;
        }
        
        public List<Subject> GetPoorSubjectsByStdID(int stdID)
        {
            var subjects = new List<Subject>();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $@"SELECT student_subjects.student_id ,student_subjects.subject_id,subjects.name
                               FROM student_subjects 
                              INNER JOIN subjects
                              ON student_subjects.id = subjects.id
                              WHERE student_subjects.curStatus = 'POOR' AND student_subjects.subject_id= @stdID;"; ;

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@stdID", stdID);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var subject = new Subject();
                                subject.setId(reader.GetInt32("subject_id"));
                                subject.setName(reader.GetString("name"));

                                subjects.Add(subject);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.ToString());   
            }

            return subjects;
        }
        public List<Subject> GetAllSubjectsByStdID(int stdID)
        {
            var subjects = new List<Subject>();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $@"SELECT student_subjects.student_id ,student_subjects.subject_id,subjects.name
                               FROM student_subjects 
                              INNER JOIN subjects
                              ON student_subjects.subject_id = subjects.id
                              WHERE student_subjects.student_id= @stdID"; ;

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@stdID", stdID);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var subject = new Subject();
                                subject.setId(reader.GetInt32("subject_id"));
                                subject.setName(reader.GetString("name"));

                                subjects.Add(subject);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return subjects;
        }
        // student_number is the student personal Id
        public Student GetStudentById(string studentId)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT id, name, student_number, class_level, center_visits, 
                               last_visit_date, teacher_id,comments, created_at ,student_phone
                               FROM students 
                               WHERE student_number = @studentNumber";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentNumber", studentId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var student = new Student();
                                student.setId(reader.GetInt32("id"));
                                student.setName(reader.GetString("name"));
                                student.setstdId(reader.GetString("student_number"));
                                student.setClasLevel(reader.GetInt32("class_level"));
                                student.setTeacherId(reader.IsDBNull("teacher_id") ? 0 : reader.GetInt32("teacher_id"));
                                student.setCenterVisits(reader.GetInt32("center_visits"));
                                student.setLastvisitDate(reader.IsDBNull("last_visit_date") ? null : reader.GetDateTime("last_visit_date"));
                                student.updateCmnt(reader.IsDBNull("comments") ? "" : reader.GetString("comments"));
                                student.setStudentPhone(reader.GetString("student_phone"));
                                return student;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        // Add new student
        public bool AddStudent(Student student)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO students (name, student_number,class_level,teacher_id,center_visits, comments,student_phone) 
                               VALUES (@name, @studentNumber, @classLevel, @teacherId, 
                               @centerVisits, @comments,@stdPhone)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", student.getName());
                        command.Parameters.AddWithValue("@studentNumber", student.getstdId());
                        command.Parameters.AddWithValue("@classLevel", student.getClassLevel());
                        command.Parameters.AddWithValue("@teacherId", student.getTeacherId() == 0 ? (object)DBNull.Value : student.getTeacherId());
                        command.Parameters.AddWithValue("@centerVisits", student.getCenterVisits());
                        command.Parameters.AddWithValue("@comments", student.getCmnt());
                        command.Parameters.AddWithValue("@stdPhone", student.getStudentPhone());

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }

        // Update student
        public bool UpdateStudent(Student student)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE students SET 
                               name = @name, 
                               student_number = @studentnumber,
                               student_phone = @studentPhone,
                               class_level = @classLevel, 
                               teacher_id = @teacherId,
                               center_visits = @centerVisits, 
                               last_visit_date = @lastVisitDate, 
                               comments = @comments 
                               WHERE id = @id";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", student.getName());
                        command.Parameters.AddWithValue("@studentNumber", student.getstdId());
                        command.Parameters.AddWithValue("@studentPhone", student.getStudentPhone());
                        command.Parameters.AddWithValue("@classLevel", student.getClassLevel());
                        command.Parameters.AddWithValue("@teacherId", student.getTeacherId() == 0 ? (object)DBNull.Value : student.getTeacherId());
                        command.Parameters.AddWithValue("@centerVisits", student.getCenterVisits());
                        command.Parameters.AddWithValue("@lastVisitDate", student.getLastVisitDate());
                        command.Parameters.AddWithValue("@comments", student.getCmnt());
                        command.Parameters.AddWithValue("@id", student.getId());

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }

        // Delete student
        public bool DeleteStudent(string studentNumber)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM students WHERE student_number = @studentNumber";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentNumber", studentNumber);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }
        
        // Add student visit using stored procedure
        public bool AddStudentVisit(int studentId, DateTime visitDate)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "CALL AddStudentVisit(@studentId, @visitDate)";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentId", studentId);
                        command.Parameters.AddWithValue("@visitDate", visitDate.Date);

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }


        // Get students with poor grades in specific subject
        public List<Student> GetPoorStudents(string subject)
        {
            var students = new List<Student>();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    if (subject == "") return students;
                    int subjectId = getSubjectIdFromName(subject);
                    string query = $@"SELECT students.id, name, student_number, class_level, teacher_id, center_visits, 
                               last_visit_date, comments, created_at
                               FROM students 
                              INNER JOIN student_subjects
                              ON student_subjects.student_id = students.id
                              WHERE student_subjects.curStatus = 'POOR' AND student_subjects.subject_id= @subject;";

                    using (var command = new MySqlCommand(query, connection))
                    {
                            command.Parameters.AddWithValue("@subject", subjectId);

                            using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var student = new Student();
                                student.setId(reader.GetInt32("id"));
                                student.setName(reader.GetString("name"));
                                student.setstdId(reader.GetString("student_number"));
                                student.setClasLevel(reader.GetInt32("class_level"));
                                student.setTeacherId(reader.IsDBNull("teacher_id") ? 0 : reader.GetInt32("teacher_id"));
                                student.setCenterVisits(reader.GetInt32("center_visits"));
                                student.setLastvisitDate(reader.IsDBNull("last_visit_date") ? null : reader.GetDateTime("last_visit_date"));
                                student.updateCmnt(reader.IsDBNull("comments") ? "" : reader.GetString("comments"));
                                students.Add(student);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return students;
        }

        public int getSubjectIdFromName(string oldSub)
        {
            int subId = -1;

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    if (oldSub == "") return -1;
                    string query = $@" SELECT id from subjects where subjects.name = @oldSub";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@oldSub", oldSub);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                subId = reader.GetInt32("id");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return subId;

        }


        // Get frequent visitors
        public List<Student> GetFrequentVisitors(int minVisits)
        {
            var students = new List<Student>();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT id, name, student_number, class_level, teacher_id, center_visits, 
                               last_visit_date, comments, created_at 
                               FROM students 
                               WHERE center_visits >= @minVisits 
                               ORDER BY center_visits DESC, name";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@minVisits", minVisits);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var student = new Student();
                                student.setId(reader.GetInt32("id"));
                                student.setName(reader.GetString("name"));
                                student.setstdId(reader.GetString("student_number"));
                                student.setClasLevel(reader.GetInt32("class_level"));
                                student.setTeacherId(reader.IsDBNull("teacher_id") ? 0 : reader.GetInt32("teacher_id"));
                                student.setCenterVisits(reader.GetInt32("center_visits"));
                                student.setLastvisitDate(reader.IsDBNull("last_visit_date") ? null : reader.GetDateTime("last_visit_date"));
                                student.updateCmnt(reader.IsDBNull("comments") ? "" : reader.GetString("comments"));
                                students.Add(student);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return students;
        }

        // Search students by name or student number
        public List<Student> SearchStudents(string searchText)
        {
            var students = new List<Student>();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT id, name, student_number, class_level, teacher_id, 
                                 center_visits, 
                               last_visit_date, comments, created_at 
                               FROM students 
                               WHERE name LIKE @search OR student_number LIKE @search 
                               ORDER BY class_level, name";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@search", "%" + searchText + "%");

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var student = new Student();
                                student.setId(reader.GetInt32("id"));
                                student.setName(reader.GetString("name"));
                                student.setstdId(reader.GetString("student_number"));
                                student.setClasLevel(reader.GetInt32("class_level"));
                                student.setTeacherId(reader.IsDBNull("teacher_id") ? 0 : reader.GetInt32("teacher_id"));
                                student.setCenterVisits(reader.GetInt32("center_visits"));
                                student.setLastvisitDate(reader.IsDBNull("last_visit_date") ? null : reader.GetDateTime("last_visit_date"));
                                student.updateCmnt(reader.IsDBNull("comments") ? "" : reader.GetString("comments"));
                                students.Add(student);
                                students.Add(student);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               Console.Write(ex.ToString());
            }

            return students;
        }

        public bool DeleteComment(Comments comment)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM teacher_comments WHERE id = @ID";

                    using (var command = new MySqlCommand(query, connection))
                        {
                        command.Parameters.AddWithValue("@ID", comment.getId());

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }

        //Instructors DB Logic Functions



    }
}