// Deep Skilling - Cognizant Practice
// Author: thrills154
// Module: EFCoreDemo

namespace EFCoreDemo;
public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; }
}
