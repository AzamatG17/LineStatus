namespace LineStatus.Api.Models.Entities;

public class TicketStatusResponse
{
    public int Code { get; set; }
    public string Msg { get; set; }
    public List<string> AvailableDesks { get; set; }
    public int AvailableDesksCount => AvailableDesks?.Count ?? 0;
    public string EstimatedWaitingTime { get; set; }
    public List<string> QueueAfter { get; set; }
    public List<string> QueueBefore { get; set; }
    public int QueueSize => QueueBefore?.Count ?? 0;
    public string ServiceName { get; set; }
    public string TaskDate { get; set; }
    public string TaskLang { get; set; }
    public string TaskTime { get; set; }
    public string TaskWaitingTime { get; set; }
    public int TickedClosed { get; set; }
    public int TicketIsCalling { get; set; }
    public string TicketNumber { get; set; }
    public object callingTicketInfo { get; set; }
    public object closedTicketInfo { get; set; }
}
