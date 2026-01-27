namespace Core.Domain
{
    public class DocumentUpload : BaseEntity
    {
        public string? DocumentName { get; set; }
        public string? DocumentPath { get; set; }
        public string? DocumentType { get; set; }
        public int EmployeeId { get; set; }
        public User? User { get; set; }
    }
}
