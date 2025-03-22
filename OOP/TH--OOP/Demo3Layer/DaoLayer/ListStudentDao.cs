namespace DaoLayer;

public class ListStudentDao
{
    private List<Student> students = new()
    {
        new("An Nguyen", 2005),
        new("Binh Tran", 2004),
        new("Cathy Le", 2006)
    };

    public List<Student> GetStudents()
    {
        return students;
    }
}
