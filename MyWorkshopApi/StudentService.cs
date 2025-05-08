using System.Collections.Generic;

public class StudentService
{
    private readonly List<Student> _students = new();

    public StudentService(){
        _students.Add(new Student("Dummy Student","dummy@email.com",0));
    }

    public IEnumerable<Student> GetAll() { 
        
       throw new NotImplementedException();
    }

    
}
