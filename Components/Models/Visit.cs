public class Visit : BaseModel{
    public int MemberId { get; set; }
    public Member? Member { get; set; }
    public DateTime? CheckOutTime { get;  set; }
    public List<Resource>? VisitResources { get; set; }
}