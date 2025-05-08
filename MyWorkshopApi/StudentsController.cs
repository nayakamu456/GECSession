using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class StudentsController : ControllerBase
{
    private readonly StudentService _service;

    public StudentsController(StudentService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetStudents()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public IActionResult AddStudent(Student student)
    {
        throw new NotImplementedException();
    }
}

public record Student(string Name, string Email, int Age);
