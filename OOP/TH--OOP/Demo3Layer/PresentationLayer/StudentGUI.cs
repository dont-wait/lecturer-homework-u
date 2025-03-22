using DaoLayer;
using ServiceLayer;

namespace Demo3Layer;

public class StudentGUI
{
    private StudentService studentService;

    public StudentGUI(StudentService studentService)
    {
        this.studentService = studentService;
    }
    
    public List<Student> GetStudents()
    {
        return studentService.GetStudents();
    }
}