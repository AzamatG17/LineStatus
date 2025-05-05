namespace LineStatus.Api.Models.DTOs;

public class TicketResponseDto
{
    public int Code { get; set; }
    public string Msg { get; set; }
    public List<string> AvailableDesks { get; set; }
    public int AvailableDesksCount { get; set; }
    public string? EstimatedWaitingTime { get; set; }
    public List<string> QueueAfter { get; set; }
    public List<string> QueueBefore { get; set; }
    public int QueueSize { get; set; }
    public string ServiceName { get; set; }
    public string TaskDate { get; set; }
    public string TaskLang { get; set; }
    public string TaskTime { get; set; }
    public string TaskWaitingTime { get; set; }
    public int TickedClosed { get; set; }
    public int TicketIsCalling { get; set; }
    public string TicketNumber { get; set; }
    public object? callingTicketInfo { get; set; }
    public ClosedTicketInfoDto closedTicketInfo { get; set; }
}
