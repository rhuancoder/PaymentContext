namespace PaymentContext.Domain.Queries
{
    public static class StudentQueries 
    {
        public static Expression<Func<Student, bool>> GetStudentInfo(string document)
        {
            return x => x.document.Number == document;
        }
    }
}